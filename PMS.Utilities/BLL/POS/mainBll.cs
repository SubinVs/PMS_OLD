using System;
using System.Collections.Generic;
using System.Text;
using PMS.Utilities.Repository;
using PMS.Utilities.Model.POS;
using Dapper;
using System.Data.SqlClient;
using System.Linq;

namespace PMS.Utilities.BLL.POS
{
    public class MainBll
    {
        public List<AreaModel> GetAreaList()
        {
            posRepositoryList<AreaModel> list = new posRepositoryList<AreaModel>();
            DynamicParameters param = new DynamicParameters();
            return list.returnList("area_AllList", param);
        }

        public List<TableModel> GetTableList(int areaId)
        {
            posRepositoryList<TableModel> list = new posRepositoryList<TableModel>();
            DynamicParameters param = new DynamicParameters();
            param.Add("@areaId", areaId);
            return list.returnList("table_AllList", param);
        }

        public List<CaptainModel> GetCaptainList(int areaId)
        {
            posRepositoryList<CaptainModel> list = new posRepositoryList<CaptainModel>();
            DynamicParameters param = new DynamicParameters();
            param.Add("@areaId", areaId);
            return list.returnList("captain_AllList", param);
        }

        public List<WaiterModel> GetWaiterList(int areaId)
        {
            posRepositoryList<WaiterModel> list = new posRepositoryList<WaiterModel>();
            DynamicParameters param = new DynamicParameters();
            param.Add("@areaId", areaId);
            return list.returnList("waiter_AllList", param);
        }

        public List<ItemModel> GetItemList(int areaId)
        {
            posRepositoryList<ItemModel> list = new posRepositoryList<ItemModel>();
            DynamicParameters param = new DynamicParameters();
            param.Add("@areaId", areaId);
            return list.returnList("item_AllList", param);
        }

        public List<ItemRateModel> GetItemRateList()
        {
            posRepositoryList<ItemRateModel> list = new posRepositoryList<ItemRateModel>();
            DynamicParameters param = new DynamicParameters();
            return list.returnList("rate_AllList", param);
        }
    }

    public class MainHelper : MainBll
    {
        private Dictionary<int, string> areaList;
        private Dictionary<int, string> tableList;
        private Dictionary<int, string> captainList;
        private Dictionary<int, string> waiterList;
        private Dictionary<int, string> itemList;
        private List<ItemRateModel> itemRatesList;

        public MainHelper()
        {
            areaList = new Dictionary<int, string>();
            tableList = new Dictionary<int, string>();
            captainList = new Dictionary<int, string>();
            waiterList = new Dictionary<int, string>();
            itemList = new Dictionary<int, string>();
            itemRatesList = new List<ItemRateModel>();
        }

        public Dictionary<int, string> PopulateAreaDetails()
        {
            areaList = GetAreaList().ToDictionary(n => n.Id, m => m.AreaName);
            Globals.AreaId = Convert.ToInt32(areaList.Select(n => n.Key).First());
            return areaList;
        }

        public Dictionary<int, string> PopulateTableDetails()
        {
            tableList = GetTableList(Globals.AreaId).ToDictionary(n => n.Id, m => m.TableNo);
            return tableList;
        }

        public Dictionary<int, string> PopulateCaptainDetails()
        {
            captainList = GetCaptainList(Globals.AreaId).ToDictionary(n => n.Id, m => m.CaptainName);
            return captainList;
        }

        public Dictionary<int, string> PopulateWaiterDetails()
        {
            waiterList = GetWaiterList(Globals.AreaId).ToDictionary(n => n.Id, m => m.WaiterName);
            return waiterList;
        }

        public Dictionary<int, string> PopulateItemDetails()
        {
            itemList = GetItemList(Globals.AreaId).ToDictionary(n => n.Id, m => m.ItemName);
            return itemList;
        }

        public void GetItemRate()
        {
            itemRatesList = GetItemRateList();
        }

        public double PopulateItemRate()
        {
            return itemRatesList.Where(n => n.ItemId.Equals(Globals.ItemId) && n.AreaId.Equals(Globals.AreaId)).Select(n => n.Rate).First();
        }
    }
}