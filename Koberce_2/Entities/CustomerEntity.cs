using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2.Entities
{
    class CustomerEntity : BaseEntity<CustomerEntity>
    {
        public static CodeList[] CustomerTypes = { new CodeList(0, "Whole saler"), new CodeList(1, "Small customer") };

        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        internal long? DCustomerType { get; set; }
        public string CustomerType
        {
            get
            {
                var ret = CustomerTypes.Where(c => c.id == DCustomerType).SingleOrDefault();

                return ret == null ? string.Empty : ret.name;
            }
        }

        static string NAME = "NAME";
        static string ADDRESS = "ADDRESS";
        static string ADDRESS2 = "ADDRESS2";
        static string PHONE = "PHONE";
        static string EMAIL = "EMAIL";
        static string CUSTOMER_TYPE = "CUSTOMER_TYPE";

        public CustomerEntity()
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
            DCustomerType = null;
        }

        public static List<CustomerEntity> LoadAll()
        {
            return BaseEntity<CustomerEntity>.LoadAll(DBProvider.T_CUSTOMER);
        }

        public static List<CustomerEntity> Load(string where, string order)
        {
            return BaseEntity<CustomerEntity>.Load(DBProvider.T_CUSTOMER, where, order);
        }

        public void Save()
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", ID, NAME, ADDRESS, ADDRESS2, PHONE, EMAIL, CUSTOMER_TYPE, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",{6},\"{7}\",{8}",
                Common.NullableLong(Id), Name, Address, Address2, Phone, Email, Common.NullableLong(DCustomerType), Comment, Valid ? 1 : 0
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
            DCustomerType = long.Parse(row[CUSTOMER_TYPE].ToString());
        }

        public override string ToString()
        {
            return Name;
        }

        public override string GetTableName()
        {
            return DBProvider.T_CUSTOMER;
        }
    }
}
