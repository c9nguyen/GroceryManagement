using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.View
{
     partial class AddProduct : Form
    {
        private const double DEFAULT_HEIGHT_RATIO = 0.6;
        private const double DEFAULT_WIDTH_RATIO = 0.25;
        private InventoryData inventoryData;
        private List<SupplierItem> supplierList;
        private InventoryItem newItem;

        public AddProduct(InventoryData inventoryData)
        {
            InitializeComponent();
            this.inventoryData = inventoryData;
            this.supplierList = new List<SupplierItem>();
            this.NewItem = null;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * DEFAULT_WIDTH_RATIO);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * DEFAULT_HEIGHT_RATIO);
            this.CenterToScreen();
        }

        /// <summary>
        /// PLU input changed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plu_TextBox_TextChanged(object sender, EventArgs e)
        {
            string plu = plu_TextBox.Text;
            this.supplier_ComboBox.Items.Clear();
            this.supplierList = inventoryData.getSupplierList(plu);
            if (supplierList.Count > 0)
            {
                foreach (SupplierItem item in supplierList)
                {
                    this.supplier_ComboBox.Items.Add(item.Name);
                }
            
            } else
            {
                supplier_ComboBox.Items.Add("Non valid PLU");
            }
        }

        private void apply_Btn_Click(object sender, EventArgs e)
        {
            if (this.supplier_ComboBox.SelectedIndex >= 0)
            {
                int n;
                if (int.TryParse(instock_TextBox.Text, out n))      //Check instock input valid
                {
                    if (int.TryParse(price_TextBox.Text, out n))    //Check price input valid 
                    {
                        string plu = plu_TextBox.Text;
                        string supplier = supplierList[supplier_ComboBox.SelectedIndex].Id;
                        string inStock = instock_TextBox.Text;
                        string price = price_TextBox.Text;
                        string name = this.inventoryData.getProductName(plu_TextBox.Text);

                        NewItem = new InventoryItem(plu, supplier, inStock, name, price);

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Price input");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Instock input");
                }
            }
        }


        public InventoryItem NewItem
        {
            get
            {
                return newItem;
            }

            set
            {
                newItem = value;
            }
        }
    }

}
