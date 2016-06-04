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
        public const double DEFAULT_HEIGHT_RATIO = 0.7;
        public const double DEFAULT_WIDTH_RATIO = 0.6;
        public const int MINIMUN_COLUMNS_WIDTH = 50;
        private int DEFAULT_FONT_SIZE = (Screen.PrimaryScreen.WorkingArea.Width / 100);

        private DataManager dataManager;
        private ArrayList currentList;
        private ArrayList defaultList;
        private ArrayList allOrderList;   
        private InventoryEditor editor;
        private bool lastColumnResizing = false;
        private Dictionary<String, InventoryItem> changesMap;
        private InventoryFilter invetoryFilter;
        private List<OrderItem> currentOrderList;
        private List<SupplierItem> supplierList;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Frame()
        {
            InitializeComponent();
            splitcontrol_Load();
            fontLoad();


            /// Loading database

            //Inventory tab
            dataManager = new DataManager();
            invetoryFilter = new InventoryFilter();
            defaultList = dataManager.loadInventoryData();
            if (defaultList == null)
            {
                MessageBox.Show("Failed to load Inventory");
                this.Close();
            }
            else
            {
                InventoryList_LoadDefault();
                changesMap = new Dictionary<string, InventoryItem>();
                editor = null;
            }

            //Order Tab
            allOrderList = dataManager.loadOrderData();
            currentOrderList = new List<OrderItem>();

            if (allOrderList == null)
            {
                MessageBox.Show("Failed to load order");
                this.Close();
            }
            else
            {
                AllOrderList_LoadDefault();
                OrderList_LoadDefault();
            }
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
            this.splitContainer1.SplitterDistance = (int)(width * 0.7);

        }


        /// <summary>
        /// Load font size.
        /// </summary>
        private void fontLoad()
        {
            int smallSize = DEFAULT_FONT_SIZE - 7;
            this.view_FilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", smallSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exc_ProcessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", smallSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tools_ViewChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", smallSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tools_EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", smallSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", smallSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            int largeSize = DEFAULT_FONT_SIZE - 5;
            this.tabControl_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", largeSize, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        /// <summary>
        /// Load data from InventoryData and display on listview
        /// </summary>
        private void InventoryList_LoadDefault()
        {
            currentList = defaultList;

            //Adding columns
            this.inventory_listview.Columns.Add("PLU", -2, HorizontalAlignment.Center);
            this.inventory_listview.Columns.Add("Name", -2, HorizontalAlignment.Center);
            this.inventory_listview.Columns.Add("Supplier ID", -2, HorizontalAlignment.Center);
            this.inventory_listview.Columns.Add("Instock", -2, HorizontalAlignment.Center);
            this.inventory_listview.Columns.Add("Sell Price", -2, HorizontalAlignment.Center);

            filledInventoryListView();
        }


        /// <summary>
        /// Get all items from currentList to fill in listview.
        /// </summary>
        private void filledInventoryListView()
        {
            inventory_listview.Items.Clear();

            //Adding Items
            foreach (InventoryItem item in currentList)
            {
                string[] stringItems = { item.Plu, item.Name, item.Supplier_id,
                                        item.InStock, item.Price };
                var listviewItem = new ListViewItem(stringItems);
                this.inventory_listview.Items.Add(listviewItem);
            }
        }

        /// <summary>
        /// Load data from InventoryData and display on listview
        /// </summary>
        private void OrderList_LoadDefault()
        {
            currentList = defaultList;

            //Adding columns
            this.order_currentListview.Columns.Add("PLU", -2, HorizontalAlignment.Center);
            this.order_currentListview.Columns.Add("Name", -2, HorizontalAlignment.Center);
            this.order_currentListview.Columns.Add("Supplier Name", -2, HorizontalAlignment.Center);
            this.order_currentListview.Columns.Add("Quantity", -2, HorizontalAlignment.Center);

            //          filledOrderListView();
        }

        /// <summary>
        /// Get all items from currentList to fill in listview.
        /// </summary>
        private void filledOrderListView()
        {
            order_All_listview.Items.Clear();

            //Adding Items
            foreach (OrderItem item in allOrderList)
            {
                string[] stringItems = { item.Order_PLU, item.Order_Date, item.Order_Name,
                                        item.Order_SupplierName, item.Order_Quantity };
                var listviewItem = new ListViewItem(stringItems);
                this.order_All_listview.Items.Add(listviewItem);
            }
        }

        /// <summary>
        /// Load data from InventoryData and display on listview
        /// </summary>
        private void AllOrderList_LoadDefault()
        {
            currentList = defaultList;

            //Adding columns
            this.order_All_listview.Columns.Add("Order Number", -2, HorizontalAlignment.Center);
            this.order_All_listview.Columns.Add("Name", -2, HorizontalAlignment.Center);
            this.order_All_listview.Columns.Add("Supplier Name", -2, HorizontalAlignment.Center);
            this.order_All_listview.Columns.Add("Quantity", -2, HorizontalAlignment.Center);
            this.order_All_listview.Columns.Add("Date", -2, HorizontalAlignment.Center);

            filledAllOrderListView();
        }

        /// <summary>
        /// Get all items from currentList to fill in listview.
        /// </summary>
        private void filledAllOrderListView()
        {
            order_All_listview.Items.Clear();

            allOrderList = this.dataManager.loadOrderData();

            //Adding Items
            foreach (OrderItem item in allOrderList)
            {
                string[] stringItems = { item.Order_Number, item.Order_Name,
                                        item.Order_SupplierName, item.Order_Quantity , item.Order_Date};
                var listviewItem = new ListViewItem(stringItems);
                this.order_All_listview.Items.Add(listviewItem);
            }
        }


        /// <summary>
        /// Activate/Disactivate edit buttons.
        /// </summary>
        /// <param name="on"></param>
        private void setEditBtns()
        {
            if (inventory_listview.SelectedItems.Count > 0)
            {

                //Selected item
                int selectedIndex = inventory_listview.SelectedItems[0].Index;
                InventoryItem selectedItem = (InventoryItem)currentList[selectedIndex];
                string key = selectedItem.Plu + selectedItem.Supplier_id;  //Changes map key

                this.tools_EditBtn.Enabled = true;
                if (changesMap.ContainsKey(key))
                {
                    this.tools_ViewChangesBtn.Enabled = true;
                }

            }
            else
            {
                this.tools_EditBtn.Enabled = false;
                this.tools_ViewChangesBtn.Enabled = false;
            }
        }


        /// 
        /// Controller
        /// Event handlers.
        /// 

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

        /// <summary>
        /// Item selecting event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inventory_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            setEditBtns();
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

            if (editor.StockChanged)
            {
                int stockIndex = inventory_listview.SelectedItems[0].SubItems.Count - 2;        //Stock columns is at second last
                inventory_listview.SelectedItems[0].SubItems[stockIndex].Text = selectedItem.InStock;
                string key = selectedItem.Plu + selectedItem.Supplier_id;   //Key for changes map
                if (!changesMap.ContainsKey(key))
                    changesMap.Add(key, selectedItem);      //Save the change
            }

            if (editor.PriceChanged)
            {
                int priceIndex = inventory_listview.SelectedItems[0].SubItems.Count - 1;    //Price columns is last.
                for (int i = 0; i < currentList.Count; i++)                                 //Updating price of all same items.
                {
                    InventoryItem item = (InventoryItem)currentList[i];                     //Because all items with same PLU
                    if (item.Plu.Equals(selectedItem.Plu))                                   //sell same price.
                    {
                        item.changePrice(selectedItem.Price);
                        item.ChangeDescription += "\nPrice changed from other item";
                        inventory_listview.Items[i].SubItems[priceIndex].Text = item.Price;                  //Update on the list
                        string key = item.Plu + item.Supplier_id;   //Key for changes map
                        if (!changesMap.ContainsKey(key))
                            changesMap.Add(key, item);      //Save the change
                    }
                }
            }

            editor.Dispose();

            //Deselect items
            setEditBtns();
            inventory_listview.SelectedItems.Clear();
        }

        /// <summary>
        /// View changes handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tools_ViewChangesBtn_Click(object sender, EventArgs e)
        {
            //Selected item
            int selectedIndex = inventory_listview.SelectedItems[0].Index;
            InventoryItem selectedItem = (InventoryItem)currentList[selectedIndex];

            StringBuilder sb = new StringBuilder();

            if (selectedItem.PreviousStock != null)
            {
                sb.Append("InStock change:\t");
                sb.Append(selectedItem.PreviousStock + " --> " + selectedItem.InStock + "\n");
            }

            if (selectedItem.PreviousPrice != null)
            {
                sb.Append("Price change:\t");
                sb.Append(selectedItem.PreviousPrice + " --> " + selectedItem.Price + "\n");
            }

            sb.Append("\nDescription:\n");
            sb.Append(selectedItem.ChangeDescription);

            MessageBox.Show(sb.ToString());
        }

        /// <summary>
        /// Button for adding new product to stock.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tools_AddBtn_Click(object sender, EventArgs e)
        {
            InventoryAdd addProduct = new InventoryAdd(this.dataManager);
            addProduct.ShowDialog(this);

            if (addProduct.NewItem != null)
            {
                InventoryItem newItem = addProduct.NewItem;

                changesMap.Add(newItem.Plu + newItem.Supplier_id, newItem);

                this.defaultList.Add(newItem);

                string[] stringItems = { newItem.Plu, newItem.Name, newItem.Supplier_id,
                                        newItem.InStock, newItem.Price };
                var listviewItem = new ListViewItem(stringItems);
                this.inventory_listview.Items.Add(listviewItem);
            }

            addProduct.Dispose();
        }

        /// <summary>
        /// Filter btn handler
        /// Send all items to the Filter Form to filter items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void view_FilterBtn_Click(object sender, EventArgs e)
        {
            invetoryFilter.filter(defaultList);
            invetoryFilter.ShowDialog(this);
            if (invetoryFilter.NewList.Count > 0)
            {
                this.currentList = invetoryFilter.NewList;
                filledInventoryListView();
            }
            invetoryFilter.Hide();
        }

        /// <summary>
        /// Process buttons in inventory to add changes to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void processBtn_Click(object sender, EventArgs e)
        {
            ProcessDialog dialog = new ProcessDialog("Process all the changes?");
            dialog.ShowDialog(this);
            if (dialog.Result)
            {
                dataManager.updateDatabase(changesMap.Values.ToList());
                invetoryFilter = new InventoryFilter();
                defaultList = dataManager.loadInventoryData();
                changesMap = new Dictionary<string, InventoryItem>();
            }
            dialog.Close();
        }

        /// <summary>
        /// Cancel button in inventory to cancel changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exc_CancelBtn_Click(object sender, EventArgs e)
        {
            ProcessDialog dialog = new ProcessDialog("Cancel all the changes?");
            dialog.ShowDialog(this);
            if (dialog.Result)
            {
                invetoryFilter = new InventoryFilter();
                defaultList = dataManager.loadInventoryData();
                currentList = defaultList;
                changesMap = new Dictionary<string, InventoryItem>();
                filledInventoryListView();
            }
            dialog.Close();
        }

        /// <summary>
        /// Add order to the list and database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void order_AddBtn_Click(object sender, EventArgs e)
        {
            if (this.order_Supplier.SelectedIndex >= 0)
            {
                int n;
                if (int.TryParse(order_quantity.Text, out n))      //Check instock input valid
                {

                    string plu = this.order_PLUTextBox.Text;
                    string supplier = this.order_Supplier.SelectedItem.ToString();
                    string quantity = this.order_quantity.Text;
                    string name = this.dataManager.getProductName(plu);
                    string supplier_id = supplierList[this.order_Supplier.SelectedIndex].Id;

                    OrderItem newItem = new OrderItem(plu, null, DateTime.Now.Date.ToString("MM-DD-YYYY"), quantity, supplier, supplier_id, name);

                    currentOrderList.Add(newItem);

                    string[] stringItems = { newItem.Order_PLU, newItem.Order_Name,
                                             newItem.Order_SupplierName, newItem.Order_Quantity };
                    var listviewItem = new ListViewItem(stringItems);
                    this.order_currentListview.Items.Add(listviewItem);
                }
                else
                {
                    MessageBox.Show("Invalid Instock input");
                }
            }
        }

        /// <summary>
        /// PLU text box event handler
        /// Searching for the supplier name base on input PLU
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void order_PLUTextBox_TextChanged(object sender, EventArgs e)
        {
            string plu = order_PLUTextBox.Text;
            this.order_Supplier.Items.Clear();
            supplierList = dataManager.getSupplierList(plu);
            if (supplierList.Count > 0)
            {
                foreach (SupplierItem item in supplierList)
                {
                    this.order_Supplier.Items.Add(item.Name);
                }

            }
            else
            {
                order_Supplier.Items.Add("Non valid PLU");
            }
        }

        /// <summary>
        /// Insert all new changes to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void order_NextBtn_Click(object sender, EventArgs e)
        {
            this.dataManager.updateOrderDatabase(this.currentOrderList);
            currentOrderList = new List<OrderItem>();
            order_currentListview.Items.Clear();
            filledAllOrderListView();
        }

    }
}
