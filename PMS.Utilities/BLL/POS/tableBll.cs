using System;
using System.Collections.Generic;
using System.Text;
using PMS.Utilities.Repository;
using PMS.Utilities.Model.POS;
using Dapper;
using System.Data.SqlClient;

namespace PMS.Utilities.BLL.POS
{
    public class tableBll
    {
        public List<tableModel> TableList()
        {
            posRepositoryList<tableModel> list = new posRepositoryList<tableModel>();
            DynamicParameters param = new DynamicParameters();
            return list.returnList("table_AllList", param);
        }
    }
}
