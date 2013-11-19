using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Koberce_2
{
    public class DBProvider
    {
        public static string[] Tables = { "T_GLOBAL", "T_STOCK", "T_STOCK_STATE", "T_NUMBER_SERIE", "T_SUPPLIER", "T_PURCHASER", "T_INVOICE", "T_SOLD_ITEM" };

        // table names
        public string T_GLOBAL = Tables[0];
        public string T_STOCK = Tables[1];
        public string T_STOCK_STATE = Tables[2];
        public string T_NUMBER_SERIE = Tables[3];
        public string T_SUPPLIER = Tables[4];
        public string T_PURCHASER = Tables[5];
        public string T_INVOICE = Tables[6];
        public string T_SOLD_ITEM = Tables[7];

        public static string DataSource
        {
            get
            {
                return @".\global.db";
            }
        }

        public DBProvider()
        {
            // vytvorenie DB suboru
            if (!File.Exists(DataSource))
            {
                SQLiteConnection.CreateFile(DataSource);
            }
        }

        public SQLiteConnection GetConnection()
        {
            try
            {
                var sql_con = new SQLiteConnection(@"Data Source=" + DataSource + "; Version=3;");

                return sql_con;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Error while creating DB connection!", "GetConnection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public void ExecuteNonQuery(string txtQuery)
        {
            using (var sql_con = GetConnection())
            {
                sql_con.Open();
                var sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
        }

        public DataSet ExecuteQuery(string query)
        {
            DataSet DS = new DataSet();

            using (var sql_con = GetConnection())
            {
                sql_con.Open();
                var sql_cmd = sql_con.CreateCommand();
                var DB = new SQLiteDataAdapter(query, sql_con);
                DS.Reset();
                DB.Fill(DS);
                sql_con.Close();
            }
            return DS;
        }

        public DataSet ExecuteQuery(string tableName, string where, string order)
        {
            DataSet DS = new DataSet();

            using (var sql_con = GetConnection())
            {
                sql_con.Open();
                var sql_cmd = sql_con.CreateCommand();
                string CommandText = "select * from " + tableName + " A " + where + " " + order;
                var DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                sql_con.Close();
            }
            return DS;
        }

        static string DBPrice(double price)
        {
            return price.ToString().Replace(',','.');
        }
    }
}
