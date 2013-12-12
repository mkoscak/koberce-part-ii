using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2.Entities
{
    class StorageStateEntity : BaseEntity<StorageStateEntity>
    {
        // viditelne polozky
        public string Product
        {
            get
            {
                if (ProductEnt == null)
                    return string.Empty;

                return ProductEnt.ToString();
            }
        }
        // vnutorne struktury
        private long? productId;
        internal long? ProductId
        {
            get
            {
                return productId;
            }

            set
            {
                productId = value;
                // nacitanie pokracujucich entit
                ProductEnt = new ProductEntity();
                ProductEnt.Load(productId ?? -1);

            }
        }
        internal ProductEntity ProductEnt;

        public string Storage
        {
            get
            {
                if (StorageEnt == null)
                    return string.Empty;

                return StorageEnt.ToString();
            }
        }
        // vnutorne struktury
        private long? storageId;
        internal long? StorageId
        {
            get
            {
                return storageId;
            }

            set
            {
                storageId = value;
                // nacitanie pokracujucich entit
                StorageEnt = new StorageEntity();
                StorageEnt.Load(storageId ?? -1);

            }
        }
        internal StorageEntity StorageEnt;

        public long Count { get; set; }
        public long Length { get; set; }
        public long Width { get; set; }

        static string PRODUCT_ID = "PRODUCT_ID";
        static string STORAGE_ID = "STORAGE_ID";
        static string COUNT = "COUNT";
        static string LENGTH = "LENGTH";
        static string WIDTH = "WIDTH";

        public StorageStateEntity()
        {
            Clear();
        }

        public override void Clear()
        {
            base.Clear();

            Count = 1;
            Length = 0;
            Width = 0;
            ProductId = null;
            StorageId = null;
        }

        public static List<StorageStateEntity> LoadAll()
        {
            return BaseEntity<StorageStateEntity>.LoadAll(DBProvider.T_STORAGE_STATE);
        }

        public void Save()
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", ID, PRODUCT_ID, STORAGE_ID, COUNT, LENGTH, WIDTH, COMMENT, VALID),
                string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                Common.NullableLong(Id), Common.NullableLong(ProductId), Common.NullableLong(StorageId), Count, Length, Width, Comment, Valid ? 1 : 0
                ));
        }

        internal override void ParseFromRow(System.Data.DataRow row)
        {
            base.ParseFromRow(row);

            Count = long.Parse(row[COUNT].ToString());
            Length = long.Parse(row[LENGTH].ToString());
            Width = long.Parse(row[WIDTH].ToString());
            ProductId = long.Parse(row[PRODUCT_ID].ToString());
            StorageId = long.Parse(row[STORAGE_ID].ToString());
        }

        public override string ToString()
        {
            return Storage + " - " + Product;
        }

        public override string GetTableName()
        {
            return DBProvider.T_STORAGE_STATE;
        }
    }
}
