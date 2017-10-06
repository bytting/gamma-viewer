/*
	Gamma Viewer - Viewer for gamma spectrums collected with Gamma Analyzer
    Copyright (C) 2017  Norwegian Radiation Protection Authority

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
// Authors: Dag Robole,

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using log4net;
using log4net.Core;
using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;

namespace gamma_viewer
{
    public partial class FormMain : Form
    {
        private static bool LogInitialized = false;
        private static ILog Log = null;

        GVSettings settings = new GVSettings();        
        GMapOverlay overlay = new GMapOverlay();

        private Bitmap bmpBlue = new Bitmap(gamma_viewer.Properties.Resources.marker_blue_10);
        private Bitmap bmpGreen = new Bitmap(gamma_viewer.Properties.Resources.marker_green_10);
        private Bitmap bmpYellow = new Bitmap(gamma_viewer.Properties.Resources.marker_yellow_10);
        private Bitmap bmpOrange = new Bitmap(gamma_viewer.Properties.Resources.marker_orange_10);
        private Bitmap bmpRed = new Bitmap(gamma_viewer.Properties.Resources.marker_red_10);

        List<Spectrum> spectrums = new List<Spectrum>();

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Env.SettingsPath))
                Directory.CreateDirectory(Env.SettingsPath);

            Log = GetLog();
            Log.Info("Starting GammaViewer");

            LoadSettings();

            gmap.Overlays.Add(overlay);
            gmap.Position = new PointLatLng(59.946534, 10.598574);

            gmap.MapProvider = ArcGIS_World_Topo_MapProvider.Instance;
            int idx = cboxMapProviders.FindString("ArcGIS World Topo");
            if (idx >= 0)
            {
                cboxMapProviders.SelectedIndex = idx;
            }

            timer.Interval = settings.RequestFrequency;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public static ILog GetLog()
        {
            if (!LogInitialized)
            {
                LogInitialized = true;

                Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

                PatternLayout patternLayout = new PatternLayout();
                patternLayout.ConversionPattern = "%date [%thread] - %message%newline";
                patternLayout.ActivateOptions();

                RollingFileAppender roller = new RollingFileAppender();
                roller.AppendToFile = false;
                roller.File = Env.SettingsPath + Path.DirectorySeparatorChar + "gamma-viewer.log";
                roller.Layout = patternLayout;
                roller.MaxSizeRollBackups = 3;
                roller.MaximumFileSize = "10MB";
                roller.RollingStyle = RollingFileAppender.RollingMode.Size;
                roller.StaticLogFileName = true;
                roller.ActivateOptions();
                hierarchy.Root.AddAppender(roller);
                hierarchy.Root.Level = Level.All;
                hierarchy.Configured = true;

                Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            }

            return Log;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (lbSessions.SelectedIndices.Count < 1)
                return;

            if (String.IsNullOrEmpty(settings.Hostname)
                || String.IsNullOrEmpty(settings.Username) 
                || String.IsNullOrEmpty(settings.Password))
            {
                Log.Warn("Sync cancelled due to missing settings");
                return;
            }            

            String session = lbSessions.SelectedItems[0] as String;

            DateTime lastSpectrumTime = spectrums[0].StartTime;
            foreach(Spectrum spec in spectrums)
            {
                if (spec.StartTime > lastSpectrumTime)
                    lastSpectrumTime = spec.StartTime;
            }

            lastSpectrumTime.AddSeconds(1.0);
            string timeString = lastSpectrumTime.ToString("yyyyMMdd_hhmmss");

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://" + settings.Hostname + "/get-spectrums/" + session + "/" + timeString);
                string credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(settings.Username + ":" + settings.Password));
                request.Headers.Add("Authorization", "Basic " + credentials);
                request.Timeout = 5000;
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                string jsonText;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var sr = new StreamReader(response.GetResponseStream()))                
                    jsonText = sr.ReadToEnd();

                List<Spectrum> specs = JsonConvert.DeserializeObject<List<Spectrum>>(jsonText);
                foreach (Spectrum spec in specs)
                {
                    spectrums.Add(spec);
                    AddMarker(spec);
                }
            }
            catch(Exception ex)
            {
                Log.Error("Timed request error", ex);
            }
        }

        private void LoadSettings()
        {
            if (!File.Exists(Env.SettingsFile))
                SaveSettings();

            // Deserialize settings from file
            using (StreamReader sr = new StreamReader(Env.SettingsFile))
            {
                XmlSerializer x = new XmlSerializer(settings.GetType());
                settings = x.Deserialize(sr) as GVSettings;
            }
        }

        private void SaveSettings()
        {            
            using (StreamWriter sw = new StreamWriter(Env.SettingsFile))
            {
                XmlSerializer x = new XmlSerializer(settings.GetType());
                x.Serialize(sw, settings);
            }
        }
        
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Log.Info("Exiting GammaViewer");
            Close();
        }

        private void cboxMapProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboxMapProviders.Text))
            {
                switch (cboxMapProviders.Text)
                {
                    case "Google Map":
                        gmap.MapProvider = GoogleMapProvider.Instance;
                        break;
                    case "Google Map Terrain":
                        gmap.MapProvider = GoogleTerrainMapProvider.Instance;
                        break;
                    case "Google Map Satellite":
                        gmap.MapProvider = GoogleSatelliteMapProvider.Instance;
                        break;
                    case "Open Street Map":
                        gmap.MapProvider = OpenStreetMapProvider.Instance;
                        break;
                    case "Open Street Map Quest":
                        gmap.MapProvider = OpenStreetMapQuestProvider.Instance;
                        break;
                    case "ArcGIS World Topo":
                        gmap.MapProvider = ArcGIS_World_Topo_MapProvider.Instance;
                        break;
                    case "ArcGIS World 2D":
                        gmap.MapProvider = ArcGIS_Imagery_World_2D_MapProvider.Instance;
                        break;
                    case "ArcGIS World Shaded":
                        gmap.MapProvider = ArcGIS_World_Shaded_Relief_MapProvider.Instance;
                        break;
                    case "Bing Map":
                        gmap.MapProvider = BingMapProvider.Instance;
                        break;
                    case "Bing Map Hybrid":
                        gmap.MapProvider = BingHybridMapProvider.Instance;
                        break;
                    case "Bing Map Satellite":
                        gmap.MapProvider = BingSatelliteMapProvider.Instance;
                        break;
                    case "Yahoo Map":
                        gmap.MapProvider = YahooMapProvider.Instance;
                        break;
                    case "Yahoo Map Hybrid":
                        gmap.MapProvider = YahooHybridMapProvider.Instance;
                        break;
                    case "Yahoo Map Satellite":
                        gmap.MapProvider = YahooSatelliteMapProvider.Instance;
                        break;
                }
            }
        }

        private void RemoveAllMarkers()
        {
            if (overlay == null)
                return;

            for (int i = 0; i < overlay.Markers.Count; i++)
                overlay.Markers.RemoveAt(i);
            overlay.Markers.Clear();
            overlay.Clear();
            gmap.Overlays.Remove(overlay);

            overlay = new GMapOverlay();
            gmap.Overlays.Add(overlay);
            gmap.Refresh();
        }

        public void AddMarker(Spectrum s)
        {
            Bitmap bmp = null;
            double dose = s.Doserate / 1000.0;

            if (dose <= 1.0)
                bmp = bmpBlue;
            else if (dose <= 5.0)
                bmp = bmpGreen;
            else if (dose <= 10.0)
                bmp = bmpYellow;
            else if (dose <= 20.0)
                bmp = bmpOrange;
            else bmp = bmpRed;

            // Add map marker            
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(s.Latitude, s.Longitude), bmp);
            marker.Tag = s;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = s.ToString()
                + Environment.NewLine + "Latitude: " + s.Latitude
                + Environment.NewLine + "Longitude: " + s.Longitude
                + Environment.NewLine + "Altitude: " + s.Altitude;
            overlay.Markers.Add(marker);
        }

        private void lbSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSessions.SelectedIndices.Count < 1)
                return;

            if (String.IsNullOrEmpty(settings.Hostname)
                || String.IsNullOrEmpty(settings.Username)
                || String.IsNullOrEmpty(settings.Password))
            {
                menuItemSettings_Click(sender, e);
                return;
            }

            try
            {
                String session = lbSessions.SelectedItems[0] as String;
                RemoveAllMarkers();

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://" + settings.Hostname + "/get-spectrums/" + session);
                string credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(settings.Username + ":" + settings.Password));
                request.Headers.Add("Authorization", "Basic " + credentials);
                request.Timeout = 5000;
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                string jsonText;
                HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
                using (var sr = new StreamReader(resp.GetResponseStream()))
                    jsonText = sr.ReadToEnd();

                spectrums.Clear();
                List<Spectrum> specs = JsonConvert.DeserializeObject<List<Spectrum>>(jsonText);
                foreach (Spectrum spec in specs)
                {
                    spectrums.Add(spec);
                    AddMarker(spec);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Session select error", ex);
                MessageBox.Show("Session select error: " + ex.Message);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        private void menuItemSyncSession_Click(object sender, EventArgs e)
        {
            // sync
        }

        private void menuItemSettings_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings(settings);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            SaveSettings();
        }

        private void menuItemRequestSessionList_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(settings.Hostname)
                || String.IsNullOrEmpty(settings.Username)
                || String.IsNullOrEmpty(settings.Password))
            {
                menuItemSettings_Click(sender, e);
                return;
            }

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://" + settings.Hostname + "/get-sessions");
                string credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(settings.Username + ":" + settings.Password));
                request.Headers.Add("Authorization", "Basic " + credentials);
                request.Timeout = 5000;
                request.Method = WebRequestMethods.Http.Get;
                request.Accept = "application/json";

                string jsonText;
                HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
                using (var sr = new StreamReader(resp.GetResponseStream()))
                    jsonText = sr.ReadToEnd();

                lbSessions.Items.Clear();
                List<string> sessions = JsonConvert.DeserializeObject<List<string>>(jsonText);
                foreach (string session in sessions)
                {
                    lbSessions.Items.Add(session);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Get sessions error", ex);
                MessageBox.Show("Get sessions error: " + ex.Message);
            }
        }
    }    
}
