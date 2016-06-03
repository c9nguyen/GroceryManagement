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

namespace View
{
    public partial class Frame : Form
    {
        private const double DEFAULT_HEIGHT_RATIO = 0.7;
        private const double DEFAULT_WIDTH_RATIO = 0.6;
        private const int MINIMUN_COLUMNS_WIDTH = 50;

        private InventoryData myInventoryData;
        private bool lastColumnResizing = false;

        public Frame()
        {
            InitializeComponent();
            splitcontrol_Load();

            //Data
            myInventoryData = new InventoryData();
            InventoryList_Load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * DEFAULT_WIDTH_RATIO);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * DEFAULT_HEIGHT_RATIO);
            this.CenterToScreen();
        }

        private void splitcontrol_Load()
        {
            int width = splitContainer1.Width;
            Console.WriteLine(width);
            this.splitContainer1.SplitterDistance = (int)(width * 0.8);
        }

        /// <summary>
        /// Load data from InventoryData and display on listview
        /// </summary>
        private void InventoryList_Load()
        {
            ArrayList itemList = myInventoryData.loadInventoryData();

            //Adding columns
            inventory_listview.Columns.Add("PLU", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Name", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Supplier ID", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Min Sell Rate", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Max Sell Rate", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Instock", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Sell Price", -2, HorizontalAlignment.Center);

            //Adding Items
            foreach (InventoryItem item in itemList)
            {
                string[] stringItems = { item.Plu, item.Name, item.Supplier_id, item.MinSellRate,
                                        item.MaxSellRate, item.InStock, item.Price };
                var listviewItem = new ListViewItem(stringItems);
                inventory_listview.Items.Add(listviewItem);
            }
   
        }

        /// <summary>
        /// Automatically resize the columns to fist the list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listview_SizeChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            ListView listview = sender as ListView;

            //Prevent calling this statement from excuting while size changing
            if (!lastColumnResizing)
            {
                lastColumnResizing = true;    
                if (listview != null)
                {
                    int columnsCount = listview.Columns.Count;
                    listview.Columns[columnsCount - 1].Width = -2;
                }

                lastColumnResizing = false;
            }

            //If prevent width from getting too small
            if (listview.Columns[e.ColumnIndex].Width < MINIMUN_COLUMNS_WIDTH)
            {
                listview.Columns[e.ColumnIndex].Width = MINIMUN_COLUMNS_WIDTH;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventory_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventory_listview.SelectedItems.Count == 0)
            {
                this.tools_EditBtn.Enabled = false;
                this.tools_UndoBtn.Enabled = false;
                this.tools_ViewChangesBtn.Enabled = false;
            } else
            {
                this.tools_EditBtn.Enabled = true;
            }         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
