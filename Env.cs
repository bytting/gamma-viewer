using System;
using System.IO;
using System.Text;

namespace gamma_viewer
{
    public static class Env
    {
        // Settings path
        public static string SettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + Path.DirectorySeparatorChar + "GammaViewer";        

        // Settings filename
        public static string SettingsFile = SettingsPath + Path.DirectorySeparatorChar + "settings.xml";
    }
}
