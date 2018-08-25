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

        public static int AreaId { get; set; }
        public static int TableId { get; set; }
        public static int CaptainId { get; set; }
        public static int WaiterId { get; set; }
        public static int Pax { get; set; }

        public static bool Valid { get; set; }

        public static int ItemId { get; set; }
    }
}
