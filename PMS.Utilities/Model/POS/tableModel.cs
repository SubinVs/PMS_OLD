using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Utilities.Model.POS
{
    public class tableModel
    {
        public int id { get; set; }
        public string tableNo { get; set; }
        public bool occupied { get; set; }
        public bool active { get; set; }
    }
}
