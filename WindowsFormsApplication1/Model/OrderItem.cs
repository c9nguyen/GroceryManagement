using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class OrderItem
    {
        private string order_PLU;
        private string order_Number;
        private string order_Date;
        private string order_Quantity;
        private string order_SupplierName;
        private string order_Name;

        public OrderItem(string order_PLU, string order_Number, string order_Date, string order_Quantity, string order_SupplierName, string order_Name)
        {
            this.Order_PLU = order_PLU;
            this.Order_Number = order_Number;
            this.Order_Date = order_Date;
            this.Order_Quantity = order_Quantity;
            this.Order_SupplierName = order_SupplierName;
            this.Order_Name = order_Name;
        }

        public string Order_Number
        {
            get
            {
                return order_Number;
            }

            set
            {
                order_Number = value;
            }
        }

        public string Order_Date
        {
            get
            {
                return order_Date;
            }

            set
            {
                order_Date = value;
            }
        }

        public string Order_Quantity
        {
            get
            {
                return order_Quantity;
            }

            set
            {
                order_Quantity = value;
            }
        }

        public string Order_SupplierName
        {
            get
            {
                return order_SupplierName;
            }

            set
            {
                order_SupplierName = value;
            }
        }

        public string Order_Name
        {
            get
            {
                return order_Name;
            }

            set
            {
                order_Name = value;
            }
        }

        public string Order_PLU
        {
            get
            {
                return order_PLU;
            }

            set
            {
                order_PLU = value;
            }
        }
    }
}
