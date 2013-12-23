using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2.Entities
{
    class ProductEntity : BaseEntity<ProductEntity>
    {
        public string ProductNr { get; set; }
        public string Description { get; set; }
        public long Hochflor { get; set; }
        public long Knots { get; set; }
        public double Weight { get; set; }
        public double BuyPrice { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string MaterialInside { get; set; }
        public string Form { get; set; }
        public string Supplier
        {
            get
            {
                if (SupplierEnt == null)
                    return string.Empty;

                return SupplierEnt.ToString();
            }
        }

        private long supplierId;
        internal long SupplierId
        {
            get
            {
                return supplierId;
            }

            set
            {
                supplierId = value;
                SupplierEnt = new SupplierEntity();
                SupplierEnt.Load(supplierId);
            }
        }
        public SupplierEntity SupplierEnt;

        static string PRODUCT_NR = "PRODUCT_NR";
        static string DESCIPTION = "DESCRIPTION";
        static string HOCHFLOR = "HOCHFLOR";
        static string KNOTS = "KNOTS";
        static string WEIGHT = "WEIGHT";
        static string BUY_PRICE = "BUY_PRICE";
        static string COLOR = "COLOR";
        static string MATERIAL = "MATERIAL";
        static string MAT_INSIDE = "MAT_INSIDE";
        static string FORM = "FORM";
        static string SUPPLIER_ID = "SUPPLIER_ID";

        public ProductEntity()
        {
            Clear();
        }

        public override void Clear()
        {
            base.Clear();

            ProductNr = string.Empty;
            Description = string.Empty;
            Color = string.Empty;
            Material = string.Empty;
            MaterialInside = string.Empty;
            Form = string.Empty;
        }

        public static List<ProductEntity> LoadAll()
        {
            return BaseEntity<ProductEntity>.LoadAll(DBProvider.T_PRODUCT);
        }

        public static List<ProductEntity> Load(string where, string order)
        {
            return BaseEntity<ProductEntity>.Load(DBProvider.T_PRODUCT, where, order);
        }

        public void Save()
        {
            if (!Id.HasValue)
            {
                ProductNr = SupplierEnt.NumberSerieEnt.NextCode();
                // increment number serie number and save
                SupplierEnt.NumberSerieEnt.LastNr++;
                SupplierEnt.NumberSerieEnt.Save();
            }

            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", ID, PRODUCT_NR, DESCIPTION, HOCHFLOR, KNOTS, WEIGHT, BUY_PRICE, COLOR, MATERIAL, MAT_INSIDE, FORM, SUPPLIER_ID, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",{3},{4},{5},{6},\"{7}\",\"{8}\",\"{9}\",\"{10}\",{11},\"{12}\",{13}",
                Common.NullableLong(Id), ProductNr, Description, Hochflor, Knots, Weight.ToDBString(), BuyPrice.ToDBString(), Color, Material, MaterialInside, Form, SupplierId, Comment, Valid ? 1 : 0
                ));
        }

        internal override void ParseFromRow(System.Data.DataRow row)
        {
            base.ParseFromRow(row);

            ProductNr = row[PRODUCT_NR].ToString();
            Description = row[DESCIPTION].ToString();
            Hochflor = long.Parse(row[HOCHFLOR].ToString());
            Knots = long.Parse(row[KNOTS].ToString());
            Weight = Common.GetPrice(row[WEIGHT].ToString());
            BuyPrice = Common.GetPrice(row[BUY_PRICE].ToString());
            Color = row[COLOR].ToString();
            Material = row[MATERIAL].ToString();
            MaterialInside = row[MAT_INSIDE].ToString();
            Form = row[FORM].ToString();
            SupplierId = long.Parse(row[SUPPLIER_ID].ToString());
        }

        public override string ToString()
        {
            return ProductNr + " " + Description;
        }

        public override string GetTableName()
        {
            return DBProvider.T_PRODUCT;
        }
    }
}
