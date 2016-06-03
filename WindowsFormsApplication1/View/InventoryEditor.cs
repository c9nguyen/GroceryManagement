using System;
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
    public partial class InventoryEditor : Form
    {
        private const double DEFAULT_HEIGHT_RATIO = 0.5;
        private const double DEFAULT_WIDTH_RATIO = 0.25;
        private InventoryItem inventoryItem;

        public InventoryEditor(InventoryItem theItem)
        {
            InitializeComponent();
            inventoryItem = theItem;
            instockValue_Lbl.Text = inventoryItem.InStock;
            priceValue_Lbl.Text = inventoryItem.Price;
            description_Box.Text = inventoryItem.ChangeDescription;
        }



        public InventoryEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Setting size of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryEditor_Load(object sender, EventArgs e)
        {
            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * DEFAULT_WIDTH_RATIO);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * DEFAULT_HEIGHT_RATIO);
            this.CenterToScreen();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void apply_Btn_Click(object sender, EventArgs e)
        {
            //If there is input in InStock
            if (newStock_Box.TextLength > 0)
            {
                int n;
                bool valid = int.TryParse(newStock_Box.Text, out n);
                if (valid)      //Check if input is valid
                {
                    if (int.Parse(inventoryItem.InStock) != n)  //If new value is different from old one
                    {
                        this.inventoryItem.InStock = newStock_Box.Text;
                        this.inventoryItem.StockChanged = true;
                    }
                }
                else        //Not closing if input is invalid, 
                {
                    MessageBox.Show("Invalid input for new InStock!");
                    return;
                }

            }

            //If there is input in Price
            if (newPrice_Box.TextLength > 0)
            {
                double n;
                bool valid = double.TryParse(newPrice_Box.Text, out n);
                if (valid)      //Check if input is valid
                {
                    if (double.Parse(inventoryItem.Price) != n)  //If new value is different from old one
                    {
                        this.inventoryItem.Price = newPrice_Box.Text;
                        this.inventoryItem.PriceChanged = true;
                    }
                }
                else          //Not closing if input is invalid, 
                {
                    MessageBox.Show("Invalid input for new Price!");
                    this.inventoryItem.StockChanged = false;
                    return;
                }
            }
            this.inventoryItem.ChangeDescription = description_Box.Text;
            this.Close();

        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
