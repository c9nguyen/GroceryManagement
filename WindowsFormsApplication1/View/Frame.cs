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
using WindowsFormsApplication1.View;
using static System.Windows.Forms.ListViewItem;

namespace View
{
    public partial class Frame : Form
    {
        private const double DEFAULT_HEIGHT_RATIO = 0.7;
        private const double DEFAULT_WIDTH_RATIO = 0.6;
        private const int MINIMUN_COLUMNS_WIDTH = 50;

        private InventoryData myInventoryData;
        private ArrayList currentList;
        private ArrayList defaultList;
        private InventoryEditor editor;
        private bool lastColumnResizing = false;
        private Dictionary<string, InventoryItem> changesMap;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Frame()
        {
            InitializeComponent();
            splitcontrol_Load();

            //Data
            myInventoryData = new InventoryData();
            defaultList = myInventoryData.loadInventoryData();
            InventoryList_LoadDefault();

            editor = null;
        }

        /// <summary>
        /// Setting up form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            this.Width = (int)(Screen.PrimaryScreen.WorkingArea.Width * DEFAULT_WIDTH_RATIO);
            this.Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * DEFAULT_HEIGHT_RATIO);
            this.CenterToScreen();
        }

        /// <summary>
        /// Setting up container.
        /// </summary>
        private void splitcontrol_Load()
        {
            int width = splitContainer1.Width;
            Console.WriteLine(width);
            this.splitContainer1.SplitterDistance = (int)(width * 0.8);
        }

        /// <summary>
        /// Load data from InventoryData and display on listview
        /// </summary>
        private void InventoryList_LoadDefault()
        {
            currentList = defaultList;

            //Adding columns
            inventory_listview.Columns.Add("PLU", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Name", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Supplier ID", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Min Sell Rate", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Max Sell Rate", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Instock", -2, HorizontalAlignment.Center);
            inventory_listview.Columns.Add("Sell Price", -2, HorizontalAlignment.Center);

            //Adding Items
            foreach (InventoryItem item in currentList)
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Item selecting event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventory_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventory_listview.SelectedItems.Count == 0)
            {
                setEditBtns(false);
            } else if (inventory_listview.SelectedItems.Count == 1)
            {
                setEditBtns(true);
            }         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Editor button listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tools_EditBtn_Click(object sender, EventArgs e)
        {
            //Passing selected item to editor.
            int selectedIndex = inventory_listview.SelectedItems[0].Index;
            InventoryItem selectedItem = (InventoryItem)currentList[selectedIndex];
            editor = new InventoryEditor(selectedItem);
            editor.ShowDialog(this);

            if (selectedItem.StockChanged)
            {
                int stockIndex = inventory_listview.SelectedItems[0].SubItems.Count - 2;        //Stock columns is at second last
                inventory_listview.SelectedItems[0].SubItems[stockIndex].Text = selectedItem.InStock;
                changesMap.Add(selectedItem.Plu + selectedItem.Supplier_id, selectedItem);      //Save the change
            }

            if (selectedItem.PriceChanged)
            {
                foreach (InventoryItem item in currentList)         //Updating price of all same items.
                {                                                   //Because all items with same PLU
                    if (item.Plu.Equals(selectedItem.Plu))          //sell same price.
                    {
                        item.Price = selectedItem.Price;
                        item.ChangeDescription += "\nPrice changed from other item";
                        changesMap.Add(item.Plu + item.Supplier_id, item);  //Save the change
                    }
                }

                int priceIndex = inventory_listview.SelectedItems[0].SubItems.Count - 1;        //Price columns is last.
                foreach (ListViewItem item in inventory_listview.Items)
                {
                    item.SubItems[priceIndex].Text = selectedItem.Price;
                }
            }

            editor.Dispose();

            //Deselect items
            setEditBtns(false);
            inventory_listview.SelectedItems.Clear();
        }

        /// <summary>
        /// Activate/Disactivate edit buttons.
        /// </summary>
        /// <param name="on"></param>
        private void setEditBtns(bool on)
        {
            this.tools_EditBtn.Enabled = on;
            this.tools_UndoBtn.Enabled = on;
            this.tools_ViewChangesBtn.Enabled = on;
        }
    }
}
