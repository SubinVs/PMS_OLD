namespace POS.Helper
{
    public class TableOrderDetails
    {
        public TableOrderDetails(int tableId, int areaId, int captainId, int waiterId, int itemId, int qty, double rate, double total, string itemPreference = null, bool deleted = false)
        {
            this.TableId = tableId; this.AreaId = areaId; this.CaptainId = captainId; this.WaiterId = waiterId; this.ItemId = itemId; this.Qty = qty; this.Rate = rate; this.Total = total; this.ItemPreference = itemPreference; this.Deleted = deleted;
        }

        private int TableId { get; set; }
        private int AreaId { get; set; }
        private int CaptainId { get; set; }
        private int WaiterId { get; set; }
        private int ItemId { get; set; }
        private int Qty { get; set; }
        private double Rate { get; set; }
        private double Total { get; set; }
        private string ItemPreference { get; set; }
        private bool Deleted { get; set; }
    }
}
