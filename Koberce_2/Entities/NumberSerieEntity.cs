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
            : base(DBProvider.T_NUMBER_SERIE)
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
            var ret = new List<NumberSerieEntity>();
            var table = LoadAllValidData(DBProvider.T_NUMBER_SERIE);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var toAdd = new NumberSerieEntity();
                toAdd.ParseFromRow(table.Rows[i]);

                ret.Add(toAdd);
            }

            return ret;
        }

        public void Load(long id)
        {
            Clear();

            var row = base.GetById(id);
            if (row == null)
                return;

            ParseFromRow(row);
        }

        public void Save()
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5}", ID, NAME, PREFIX, LAST_NR, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",{3},\"{4}\",{5}",
                    Id.HasValue ? Id.Value.ToString() : "null", Name, Prefix, LastNr, Comment, Valid ? "1" : "0"
                ));
        }

        internal override void ParseFromRow(System.Data.DataRow row)
        {
            base.ParseFromRow(row);

            Name = row[NAME].ToString();
            Prefix = row[PREFIX].ToString();
            LastNr = long.Parse(row[LAST_NR].ToString());
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
