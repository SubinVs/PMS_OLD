using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PMS.Utilities
{
    public static class Globals
    {
        public static string connPos = "";
        public static string path = string.Format("{0}/Connection.xml", Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
    }
}
