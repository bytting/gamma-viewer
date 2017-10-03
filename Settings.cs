using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace gamma_viewer
{
    [Serializable()]
    public class GVSettings
    {
        public GVSettings()
        {
            Hostname = "localhost";
        }

        public string Hostname { get; set; }
    }
}
