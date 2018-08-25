using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Utilities.Model.POS
{
    public class CaptainModel
    {
        public int Id { get; set; }
        public string CaptainName { get; set; }
        public int AreaId { get; set; }
        public bool Active { get; set; }
    }
}
