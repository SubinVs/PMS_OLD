using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace PMS.Utilities.Repository
{
    public class posRepository
    {
        private SqlConnection con;

        private void Connection()
        {
            Globals.connPos = ConnectionDB.xml_conn(Globals.path);
            con = new SqlConnection(Globals.connPos);
        }

        public string executeNonQuery(string query, DynamicParameters param)
        {
            try
            {
                Connection();
                con.Open();
                con.Execute(query, param, commandType: System.Data.CommandType.StoredProcedure);
                con.Close();
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }

    public class posRepositoryList<T> where T : class
    {
        private SqlConnection con;

        private void Connection()
        {
            Globals.connPos = ConnectionDB.xml_conn(Globals.path);
            con = new SqlConnection(Globals.connPos);
        }

        public List<T> returnList(string query, DynamicParameters param)
        {
            try
            {
                Connection();
                con.Open();
                IList<T> list = SqlMapper.Query<T>(con, query, param, null, true, null, commandType: System.Data.CommandType.StoredProcedure).ToList();
                con.Close();
                return list.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}