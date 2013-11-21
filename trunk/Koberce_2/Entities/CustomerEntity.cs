using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2.Entities
{
    class CustomerEntity : BaseEntity<CustomerEntity>
    {
        /// <summary>
        /// Help class as codelist
        /// </summary>
        public class CCustomerType
        {
            public long id;
            public string name;
            
            public CCustomerType(long id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public override string ToString()
            {
                return name;
            }
        }

        public static CCustomerType[] CustomerTypes = { new CCustomerType(0, "Whole saler"), new CCustomerType(1, "Small customer") };

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
            : base(DBProvider.T_CUSTOMER)
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
            var ret = new List<CustomerEntity>();
            var table = LoadAllValidData(DBProvider.T_CUSTOMER);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var toAdd = new CustomerEntity();
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
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", ID, NAME, ADDRESS, ADDRESS2, PHONE, EMAIL, CUSTOMER_TYPE, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",{6},\"{7}\",{8}",
                Common.NullableLong(Id), Name, Address, Address2, Phone, Email, Common.NullableLong(DCustomerType), Comment, Valid ? "1" : "0"
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
    }
}
