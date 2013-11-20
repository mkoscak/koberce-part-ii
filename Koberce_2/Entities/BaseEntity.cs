using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Koberce_2.Entities
{
    /// <summary>
    /// Base DB entity with basic columns
    /// </summary>
    abstract class BaseEntity
    {
        public string TableName
        {
            get;
            private set;
        }

        // column variables for mapping
        public long? Id { get; set; }
        public string Comment { get; set; }
        public bool Valid { get; set; }

        // basic column names
        public static string ID = "ID";
        public static string COMMENT = "COMMENT";
        public static string VALID = "VALID";

        /// <summary>
        /// Constructor with table name of the entity..
        /// </summary>
        /// <param name="tableName"></param>
        public BaseEntity(string tableName)
        {
            this.TableName = tableName;
            Clear();
        }

        /// <summary>
        /// Clears the basic properties of the entity
        /// </summary>
        public virtual void Clear()
        {
            Id = null;
            Comment = string.Empty;
            Valid = true;
        }

        /// <summary>
        /// Loads all data from table where VALID = 1
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadAllValidData(string tableName)
        {
            var ds = DBProvider.Instance.ExecuteQuery(string.Format("select * from {0} where {1} = {2}", tableName, VALID, 1));
            if (ds == null || ds.Tables == null || ds.Tables.Count == 0)
                return new DataTable();

            return ds.Tables[0];
        }

        /// <summary>
        /// Loads all data from the entity table
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadAllData(string tableName)
        {
            var ds = DBProvider.Instance.ExecuteQuery(string.Format("select * from {0}", tableName));
            if (ds == null || ds.Tables == null || ds.Tables.Count == 0)
                return new DataTable();

            return ds.Tables[0];
        }

        /// <summary>
        /// returns datarow with entity with given ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataRow GetById(long id)
        {
            var ds = DBProvider.Instance.ExecuteQuery(string.Format("select * from {0} where id = {1}", DBProvider.T_NUMBER_SERIE, id));
            if (ds == null || ds.Tables == null || ds.Tables.Count == 0 || ds.Tables[0].Rows == null || ds.Tables[0].Rows.Count == 0)
                return null;

            return ds.Tables[0].Rows[0];
        }

        /// <summary>
        /// Save the changes or insert new entity when Id is null
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="values"></param>
        public void Save(string columns, string values)
        {
            DBProvider.Instance.ExecuteNonQuery(string.Format("insert or replace into {0} ( {1} ) values ( {2} )",
                TableName,
                columns,
                values
                ));
        }

        /// <summary>
        /// Updates entity with given ID
        /// </summary>
        /// <param name="what"></param>
        public virtual void Update(string what)
        {
            DBProvider.Instance.ExecuteNonQuery(string.Format("update {0} set {1} where {2} = {3}",
                TableName,
                what,
                ID, Id
                ));
        }

        /// <summary>
        /// Deletes/invalidates the entity
        /// </summary>
        public virtual void Delete()
        {
            Valid = false;
            Update(string.Format("{0} = {1}", VALID, 0));
        }

        /// <summary>
        /// Parse base properties from data row
        /// </summary>
        /// <param name="row"></param>
        internal virtual void ParseFromRow(System.Data.DataRow row)
        {
            Id = long.Parse(row[ID].ToString());
            Comment = row[COMMENT].ToString();
            Valid = row[VALID].ToString() != "0";
        }
    }
}
