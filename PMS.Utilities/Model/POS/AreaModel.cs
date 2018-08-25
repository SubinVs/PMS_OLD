using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Utilities.Model.POS
{
    public class AreaModel
    {
        public int Id { get; set; }
        public string AreaName { get; set; }
        public int DefaultCaptainId { get; set; }
        public int DefaultWaiterId { get; set; }
        public int DefaultSettlementId { get; set; }
        public bool Active { get; set; }
    }
}
