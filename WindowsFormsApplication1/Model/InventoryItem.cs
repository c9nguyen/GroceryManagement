using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    public class InventoryItem
    {
        private string plu;
        private string supplier_id;
        private string inStock;
        private string name;
        private string price;
        private string changeDescription;
        private string previousStock;
        private string previousPrice;

        public InventoryItem(string plu, string supplier_id, string inStock, string name, string price)
        {
            this.Plu = plu;
            this.Supplier_id = supplier_id;
            this.InStock = inStock;
            this.Name = name;
            this.Price = price;
            ChangeDescription = "";
            PreviousStock = null;
            PreviousPrice = null;
        }

        public void changeStock(string newStock)
        {
            this.PreviousStock = this.InStock;
            this.InStock = newStock;
        }

        public void changePrice(string newPrice)
        {
            this.PreviousPrice = this.Price;
            this.Price = newPrice;
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

        public string ChangeDescription
        {
            get
            {
                return changeDescription;
            }

            set
            {
                changeDescription = value;
            }
        }

        public string PreviousStock
        {
            get
            {
                return previousStock;
            }

            set
            {
                previousStock = value;
            }
        }

        public string PreviousPrice
        {
            get
            {
                return previousPrice;
            }

            set
            {
                previousPrice = value;
            }
        }
    }
}
