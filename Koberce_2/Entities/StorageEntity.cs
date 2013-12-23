using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2.Entities
{
    class StorageEntity : BaseEntity<StorageEntity>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        static string NAME = "NAME";
        static string ADDRESS = "ADDRESS";
        static string ADDRESS2 = "ADDRESS2";
        static string PHONE = "PHONE";
        static string EMAIL = "EMAIL";

        public StorageEntity()
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
        }

        public static List<StorageEntity> LoadAll()
        {
            return BaseEntity<StorageEntity>.LoadAll(DBProvider.T_STORAGE);
        }

        public static List<StorageEntity> Load(string where, string order)
        {
            return BaseEntity<StorageEntity>.Load(DBProvider.T_STORAGE, where, order);
        }

        public void Save()
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", ID, NAME, ADDRESS, ADDRESS2, PHONE, EMAIL, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",{7}",
                Common.NullableLong(Id), Name, Address, Address2, Phone, Email, Comment, Valid ? 1 : 0
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
        }

        public override string ToString()
        {
            return Name;
        }

        public override string GetTableName()
        {
            return DBProvider.T_STORAGE;
        }
    }
}
