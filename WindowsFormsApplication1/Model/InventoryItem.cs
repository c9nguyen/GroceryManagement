using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class InventoryItem
    {
        private string plu;
        private string supplier_id;
        private string minSellRate;
        private string maxSellRate;
        private string inStock;
        private string name;
        private string price;

        public InventoryItem(string plu, string supplier_id, string minSellRate, string maxSellRate,
                             string inStock, string name, string price)
        {
            this.Plu = plu;
            this.Supplier_id = supplier_id;
            this.MinSellRate = minSellRate;
            this.MaxSellRate = maxSellRate;
            this.InStock = inStock;
            this.Name = name;
            this.Price = price;
        }


        public string Supplier_id
        {
            get
            {
                return supplier_id;
            }

            set
            {
                supplier_id = value;
            }
        }

        public string MinSellRate
        {
            get
            {
                return minSellRate;
            }

            set
            {
                minSellRate = value;
            }
        }

        public string MaxSellRate
        {
            get
            {
                return maxSellRate;
            }

            set
            {
                maxSellRate = value;
            }
        }

        public string InStock
        {
            get
            {
                return inStock;
            }

            set
            {
                inStock = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Plu
        {
            get
            {
                return plu;
            }

            set
            {
                plu = value;
            }
        }
    }
}
