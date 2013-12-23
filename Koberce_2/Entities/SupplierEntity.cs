using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2.Entities
{
    class SupplierEntity : BaseEntity<SupplierEntity>
    {
        // viditelne polozky
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string NumberSerie
        {
            get
            {
                if (NumberSerieEnt == null)
                    return string.Empty;

                return NumberSerieEnt.ToString();
            }
        }

        // vnutorne struktury
        private long? nrSerieId;
        internal long? NrSerieId
        {
            get
            {
                return nrSerieId;
            }

            set
            {
                nrSerieId = value;
                // nacitanie pokracujucich entit
                NumberSerieEnt = new NumberSerieEntity();
                NumberSerieEnt.Load(nrSerieId ?? -1);

            }
        }
        internal NumberSerieEntity NumberSerieEnt;

        static string NAME = "NAME";
        static string ADDRESS = "ADDRESS";
        static string ADDRESS2 = "ADDRESS2";
        static string PHONE = "PHONE";
        static string EMAIL = "EMAIL";
        static string NR_SERIE_ID = "NR_SERIE_ID";

        public SupplierEntity()
        {
            Clear();
        }

        public override void Clear()
        {
            base.Clear();

            Name = string.Empty;
            Address = string.Empty;
            Address2 = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NrSerieId = null;
        }

        public static List<SupplierEntity> LoadAll()
        {
            return BaseEntity<SupplierEntity>.LoadAll(DBProvider.T_SUPPLIER);
        }

        public static List<SupplierEntity> Load(string where, string order)
        {
            return BaseEntity<SupplierEntity>.Load(DBProvider.T_SUPPLIER, where, order);
        }

        public void Save()
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", ID, NAME, ADDRESS, ADDRESS2, PHONE, EMAIL, NR_SERIE_ID, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",{6},\"{7}\",{8}",
                Common.NullableLong(Id), Name, Address, Address2, Phone, Email, Common.NullableLong(NrSerieId), Comment, Valid ? 1 : 0
                ));
        }

        internal override void ParseFromRow(System.Data.DataRow row)
        {
            base.ParseFromRow(row);

            Name = row[NAME].ToString();
            Address = row[ADDRESS].ToString();
            Address2 = row[ADDRESS2].ToString();
            Phone = row[PHONE].ToString();
            Email = row[EMAIL].ToString();
            NrSerieId = long.Parse(row[NR_SERIE_ID].ToString());
        }

        public override string ToString()
        {
            return Name;
        }

        public override string GetTableName()
        {
            return DBProvider.T_SUPPLIER;
        }
    }
}
