using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2.Entities
{
    class NumberSerieEntity : BaseEntity<NumberSerieEntity>
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
        public long LastNr { get; set; }

        static string NAME = "NAME";
        static string PREFIX = "PREFIX";
        static string LAST_NR = "LAST_NR";

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="db"></param>
        public NumberSerieEntity()
        {
            Clear();
        }

        public override void Clear()
        {
            base.Clear();

            Name = string.Empty;
            Prefix = string.Empty;
            LastNr = 0;
        }

        public static List<NumberSerieEntity> LoadAll()
        {
            return BaseEntity<NumberSerieEntity>.LoadAll(DBProvider.T_NUMBER_SERIE);
        }

        public void Save()
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5}", ID, NAME, PREFIX, LAST_NR, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",{3},\"{4}\",{5}",
                    Common.NullableLong(Id), Name, Prefix, LastNr, Comment, Valid ? 1 : 0
                ));
        }

        internal override void ParseFromRow(System.Data.DataRow row)
        {
            base.ParseFromRow(row);

            Name = row[NAME].ToString();
            Prefix = row[PREFIX].ToString();
            LastNr = long.Parse(row[LAST_NR].ToString());
        }

        public string NextCode()
        {
            return Prefix + (LastNr + 1);
        }

        public override string ToString()
        {
            return Name;
        }

        public override string GetTableName()
        {
            return DBProvider.T_NUMBER_SERIE;
        }
    }
}
