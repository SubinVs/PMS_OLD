using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Utilities.Model.POS
{
    public class ItemRateModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int AreaId { get; set; }
        public double Rate { get; set; }
        public bool Active { get; set; }
    }
}
