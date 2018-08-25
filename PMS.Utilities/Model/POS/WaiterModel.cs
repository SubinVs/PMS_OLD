using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Utilities.Model.POS
{
    public class WaiterModel
    {
        public int Id { get; set; }
        public string WaiterName { get; set; }
        public int AreaId { get; set; }
        public bool Active { get; set; }
    }
}
