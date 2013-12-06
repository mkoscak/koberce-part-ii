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
        public static string[] Tables = { "T_PRODUCT", "T_STORAGE", "T_STORAGE_STATE", "T_NUMBER_SERIE", "T_SUPPLIER", "T_CUSTOMER", "T_INVOICE", "T_SOLD_ITEM" };

        // table names
        public static string T_PRODUCT = Tables[0];
        public static string T_STORAGE = Tables[1];
        public static string T_STORAGE_STATE = Tables[2];
        public static string T_NUMBER_SERIE = Tables[3];
        public static string T_SUPPLIER = Tables[4];
        public static string T_CUSTOMER = Tables[5];
        public static string T_INVOICE = Tables[6];
        public static string T_SOLD_ITEM = Tables[7];

        public static string DataSource
        {
            get
            {
                return @".\global.db";
            }
        }

        /// <summary>
        /// Singleton..
        /// </summary>
        private DBProvider()
        {
            // vytvorenie DB suboru
            if (!File.Exists(DataSource))
            {
                SQLiteConnection.CreateFile(DataSource);
            }
        }
        private static DBProvider db;
        public static DBProvider Instance
        {
            get
            {
                if (db == null)
                    db = new DBProvider();

                return db;
            }
        }
        /// <summary>
        /// End of singleton
        /// </summary>
        /// <returns></returns>

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
