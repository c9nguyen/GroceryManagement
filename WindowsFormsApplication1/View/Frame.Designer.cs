using System.Windows.Forms;

namespace View
{
    partial class Frame
    {
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage_Order = new System.Windows.Forms.TabPage();
            this.order_LeftPanel = new System.Windows.Forms.Panel();
            this.order_panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.order_All_listview = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.order_currentListview = new System.Windows.Forms.ListView();
            this.order_CenterPanel = new System.Windows.Forms.Panel();
            this.order_PLULbl = new System.Windows.Forms.Label();
            this.order_PLUTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.order_quantity = new System.Windows.Forms.TextBox();
            this.order_SupplierLbl = new System.Windows.Forms.Label();
            this.order_Supplier = new System.Windows.Forms.ComboBox();
            this.order_AddBtn = new System.Windows.Forms.Button();
            this.order_NextBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.order_number = new System.Windows.Forms.Label();
            this.tabPage_Inventory = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Tools_AddBtn = new System.Windows.Forms.Button();
            this.tools_EditBtn = new System.Windows.Forms.Button();
            this.tools_label = new System.Windows.Forms.Label();
            this.tools_ViewChangesBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exc_ProcessBtn = new System.Windows.Forms.Button();
            this.view_FilterBtn = new System.Windows.Forms.Button();
            this.exc_CancelBtn = new System.Windows.Forms.Button();
            this.inventory_listview = new System.Windows.Forms.ListView();
            this.tabControl_Inventory = new System.Windows.Forms.TabControl();
            this.tabPage_Order.SuspendLayout();
            this.order_LeftPanel.SuspendLayout();
            this.order_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.order_CenterPanel.SuspendLayout();
            this.tabPage_Inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl_Inventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1072, 565);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage_Order
            // 
            this.tabPage_Order.Controls.Add(this.order_CenterPanel);
            this.tabPage_Order.Controls.Add(this.order_LeftPanel);
            this.tabPage_Order.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Order.Name = "tabPage_Order";
            this.tabPage_Order.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Order.Size = new System.Drawing.Size(1072, 565);
            this.tabPage_Order.TabIndex = 1;
            this.tabPage_Order.Text = "Order";
            this.tabPage_Order.UseVisualStyleBackColor = true;
            // 
            // order_LeftPanel
            // 
            this.order_LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_LeftPanel.Controls.Add(this.order_panel);
            this.order_LeftPanel.Location = new System.Drawing.Point(0, 3);
            this.order_LeftPanel.Name = "order_LeftPanel";
            this.order_LeftPanel.Size = new System.Drawing.Size(675, 562);
            this.order_LeftPanel.TabIndex = 0;
            // 
            // order_panel
            // 
            this.order_panel.Controls.Add(this.tabControl1);
            this.order_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_panel.Location = new System.Drawing.Point(0, 0);
            this.order_panel.Name = "order_panel";
            this.order_panel.Size = new System.Drawing.Size(675, 562);
            this.order_panel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 562);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.order_All_listview);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(667, 524);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "All Orders";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // order_All_listview
            // 
            this.order_All_listview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_All_listview.GridLines = true;
            this.order_All_listview.Location = new System.Drawing.Point(3, 3);
            this.order_All_listview.Name = "order_All_listview";
            this.order_All_listview.Size = new System.Drawing.Size(661, 518);
            this.order_All_listview.TabIndex = 0;
            this.order_All_listview.UseCompatibleStateImageBehavior = false;
            this.order_All_listview.View = System.Windows.Forms.View.Details;
            this.order_All_listview.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listview_SizeChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.order_currentListview);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 524);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Current Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // order_currentListview
            // 
            this.order_currentListview.GridLines = true;
            this.order_currentListview.Location = new System.Drawing.Point(3, 5);
            this.order_currentListview.Name = "order_currentListview";
            this.order_currentListview.Size = new System.Drawing.Size(663, 526);
            this.order_currentListview.TabIndex = 0;
            this.order_currentListview.UseCompatibleStateImageBehavior = false;
            this.order_currentListview.View = System.Windows.Forms.View.Details;
            this.order_currentListview.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listview_SizeChanged);
            // 
            // order_CenterPanel
            // 
            this.order_CenterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_CenterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.order_CenterPanel.Controls.Add(this.order_number);
            this.order_CenterPanel.Controls.Add(this.monthCalendar1);
            this.order_CenterPanel.Controls.Add(this.order_NextBtn);
            this.order_CenterPanel.Controls.Add(this.order_AddBtn);
            this.order_CenterPanel.Controls.Add(this.order_Supplier);
            this.order_CenterPanel.Controls.Add(this.order_SupplierLbl);
            this.order_CenterPanel.Controls.Add(this.order_quantity);
            this.order_CenterPanel.Controls.Add(this.label3);
            this.order_CenterPanel.Controls.Add(this.order_PLUTextBox);
            this.order_CenterPanel.Controls.Add(this.order_PLULbl);
            this.order_CenterPanel.Location = new System.Drawing.Point(681, 3);
            this.order_CenterPanel.Name = "order_CenterPanel";
            this.order_CenterPanel.Size = new System.Drawing.Size(391, 562);
            this.order_CenterPanel.TabIndex = 1;
            // 
            // order_PLULbl
            // 
            this.order_PLULbl.AutoSize = true;
            this.order_PLULbl.Location = new System.Drawing.Point(48, 23);
            this.order_PLULbl.Name = "order_PLULbl";
            this.order_PLULbl.Size = new System.Drawing.Size(53, 25);
            this.order_PLULbl.TabIndex = 0;
            this.order_PLULbl.Text = "PLU";
            // 
            // order_PLUTextBox
            // 
            this.order_PLUTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_PLUTextBox.Location = new System.Drawing.Point(166, 24);
            this.order_PLUTextBox.Name = "order_PLUTextBox";
            this.order_PLUTextBox.Size = new System.Drawing.Size(174, 31);
            this.order_PLUTextBox.TabIndex = 1;
            this.order_PLUTextBox.TextChanged += new System.EventHandler(this.order_PLUTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // order_quantity
            // 
            this.order_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.order_quantity.Location = new System.Drawing.Point(166, 195);
            this.order_quantity.Name = "order_quantity";
            this.order_quantity.Size = new System.Drawing.Size(174, 31);
            this.order_quantity.TabIndex = 3;
            // 
            // order_SupplierLbl
            // 
            this.order_SupplierLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.order_SupplierLbl.AutoSize = true;
            this.order_SupplierLbl.Location = new System.Drawing.Point(48, 107);
            this.order_SupplierLbl.Name = "order_SupplierLbl";
            this.order_SupplierLbl.Size = new System.Drawing.Size(91, 25);
            this.order_SupplierLbl.TabIndex = 4;
            this.order_SupplierLbl.Text = "Supplier";
            // 
            // order_Supplier
            // 
            this.order_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.order_Supplier.FormattingEnabled = true;
            this.order_Supplier.Location = new System.Drawing.Point(165, 102);
            this.order_Supplier.Name = "order_Supplier";
            this.order_Supplier.Size = new System.Drawing.Size(175, 33);
            this.order_Supplier.TabIndex = 5;
            // 
            // order_AddBtn
            // 
            this.order_AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_AddBtn.Location = new System.Drawing.Point(165, 256);
            this.order_AddBtn.Name = "order_AddBtn";
            this.order_AddBtn.Size = new System.Drawing.Size(103, 41);
            this.order_AddBtn.TabIndex = 6;
            this.order_AddBtn.Text = "Add";
            this.order_AddBtn.UseVisualStyleBackColor = true;
            this.order_AddBtn.Click += new System.EventHandler(this.order_AddBtn_Click);
            // 
            // order_NextBtn
            // 
            this.order_NextBtn.Location = new System.Drawing.Point(165, 330);
            this.order_NextBtn.Name = "order_NextBtn";
            this.order_NextBtn.Size = new System.Drawing.Size(103, 45);
            this.order_NextBtn.TabIndex = 7;
            this.order_NextBtn.Text = "Process";
            this.order_NextBtn.UseVisualStyleBackColor = true;
            this.order_NextBtn.Click += new System.EventHandler(this.order_NextBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(99, 387);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // order_number
            // 
            this.order_number.AutoSize = true;
            this.order_number.Location = new System.Drawing.Point(184, 340);
            this.order_number.Name = "order_number";
            this.order_number.Size = new System.Drawing.Size(0, 25);
            this.order_number.TabIndex = 8;
            // 
            // tabPage_Inventory
            // 
            this.tabPage_Inventory.Controls.Add(this.splitContainer1);
            this.tabPage_Inventory.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Inventory.Name = "tabPage_Inventory";
            this.tabPage_Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Inventory.Size = new System.Drawing.Size(1072, 565);
            this.tabPage_Inventory.TabIndex = 0;
            this.tabPage_Inventory.Text = "Inventory";
            this.tabPage_Inventory.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.inventory_listview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.exc_CancelBtn);
            this.splitContainer1.Panel2.Controls.Add(this.view_FilterBtn);
            this.splitContainer1.Panel2.Controls.Add(this.exc_ProcessBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.tools_ViewChangesBtn);
            this.splitContainer1.Panel2.Controls.Add(this.tools_label);
            this.splitContainer1.Panel2.Controls.Add(this.tools_EditBtn);
            this.splitContainer1.Panel2.Controls.Add(this.Tools_AddBtn);
            this.splitContainer1.Size = new System.Drawing.Size(1066, 559);
            this.splitContainer1.SplitterDistance = 810;
            this.splitContainer1.TabIndex = 0;
            // 
            // Tools_AddBtn
            // 
            this.Tools_AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tools_AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tools_AddBtn.Location = new System.Drawing.Point(34, 154);
            this.Tools_AddBtn.Name = "Tools_AddBtn";
            this.Tools_AddBtn.Size = new System.Drawing.Size(181, 36);
            this.Tools_AddBtn.TabIndex = 4;
            this.Tools_AddBtn.Text = "Add Product";
            this.Tools_AddBtn.UseVisualStyleBackColor = true;
            this.Tools_AddBtn.Click += new System.EventHandler(this.Tools_AddBtn_Click);
            // 
            // tools_EditBtn
            // 
            this.tools_EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tools_EditBtn.Enabled = false;
            this.tools_EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tools_EditBtn.Location = new System.Drawing.Point(34, 38);
            this.tools_EditBtn.Name = "tools_EditBtn";
            this.tools_EditBtn.Size = new System.Drawing.Size(181, 36);
            this.tools_EditBtn.TabIndex = 0;
            this.tools_EditBtn.Text = "Edit";
            this.tools_EditBtn.UseVisualStyleBackColor = true;
            this.tools_EditBtn.Click += new System.EventHandler(this.tools_EditBtn_Click);
            // 
            // tools_label
            // 
            this.tools_label.AutoSize = true;
            this.tools_label.Location = new System.Drawing.Point(5, 10);
            this.tools_label.Name = "tools_label";
            this.tools_label.Size = new System.Drawing.Size(65, 25);
            this.tools_label.TabIndex = 1;
            this.tools_label.Text = "Tools";
            // 
            // tools_ViewChangesBtn
            // 
            this.tools_ViewChangesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tools_ViewChangesBtn.Enabled = false;
            this.tools_ViewChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tools_ViewChangesBtn.Location = new System.Drawing.Point(34, 96);
            this.tools_ViewChangesBtn.Name = "tools_ViewChangesBtn";
            this.tools_ViewChangesBtn.Size = new System.Drawing.Size(181, 36);
            this.tools_ViewChangesBtn.TabIndex = 2;
            this.tools_ViewChangesBtn.Text = "View Change";
            this.tools_ViewChangesBtn.UseVisualStyleBackColor = true;
            this.tools_ViewChangesBtn.Click += new System.EventHandler(this.tools_ViewChangesBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Views";
            // 
            // exc_ProcessBtn
            // 
            this.exc_ProcessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exc_ProcessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exc_ProcessBtn.Location = new System.Drawing.Point(34, 454);
            this.exc_ProcessBtn.Name = "exc_ProcessBtn";
            this.exc_ProcessBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exc_ProcessBtn.Size = new System.Drawing.Size(181, 36);
            this.exc_ProcessBtn.TabIndex = 8;
            this.exc_ProcessBtn.Text = "Process";
            this.exc_ProcessBtn.UseVisualStyleBackColor = true;
            this.exc_ProcessBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // view_FilterBtn
            // 
            this.view_FilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_FilterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_FilterBtn.Location = new System.Drawing.Point(34, 221);
            this.view_FilterBtn.Name = "view_FilterBtn";
            this.view_FilterBtn.Size = new System.Drawing.Size(181, 36);
            this.view_FilterBtn.TabIndex = 10;
            this.view_FilterBtn.Text = "Filter";
            this.view_FilterBtn.UseVisualStyleBackColor = true;
            this.view_FilterBtn.Click += new System.EventHandler(this.view_FilterBtn_Click);
            // 
            // exc_CancelBtn
            // 
            this.exc_CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exc_CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exc_CancelBtn.Location = new System.Drawing.Point(34, 518);
            this.exc_CancelBtn.Name = "exc_CancelBtn";
            this.exc_CancelBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exc_CancelBtn.Size = new System.Drawing.Size(181, 36);
            this.exc_CancelBtn.TabIndex = 11;
            this.exc_CancelBtn.Text = "Cancel";
            this.exc_CancelBtn.UseVisualStyleBackColor = true;
            this.exc_CancelBtn.Click += new System.EventHandler(this.exc_CancelBtn_Click);
            // 
            // inventory_listview
            // 
            this.inventory_listview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory_listview.FullRowSelect = true;
            this.inventory_listview.GridLines = true;
            this.inventory_listview.HideSelection = false;
            this.inventory_listview.Location = new System.Drawing.Point(0, 0);
            this.inventory_listview.MultiSelect = false;
            this.inventory_listview.Name = "inventory_listview";
            this.inventory_listview.Size = new System.Drawing.Size(810, 559);
            this.inventory_listview.TabIndex = 0;
            this.inventory_listview.UseCompatibleStateImageBehavior = false;
            this.inventory_listview.View = System.Windows.Forms.View.Details;
            this.inventory_listview.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listview_SizeChanged);
            this.inventory_listview.SelectedIndexChanged += new System.EventHandler(this.inventory_listview_SelectedIndexChanged);
            // 
            // tabControl_Inventory
            // 
            this.tabControl_Inventory.Controls.Add(this.tabPage_Inventory);
            this.tabControl_Inventory.Controls.Add(this.tabPage_Order);
            this.tabControl_Inventory.Controls.Add(this.tabPage1);
            this.tabControl_Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Inventory.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl_Inventory.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Inventory.Name = "tabControl_Inventory";
            this.tabControl_Inventory.SelectedIndex = 0;
            this.tabControl_Inventory.Size = new System.Drawing.Size(1080, 603);
            this.tabControl_Inventory.TabIndex = 0;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 603);
            this.Controls.Add(this.tabControl_Inventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frame";
            this.Text = "Grocery Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage_Order.ResumeLayout(false);
            this.order_LeftPanel.ResumeLayout(false);
            this.order_panel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.order_CenterPanel.ResumeLayout(false);
            this.order_CenterPanel.PerformLayout();
            this.tabPage_Inventory.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl_Inventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private TabPage tabPage_Order;
        private Panel order_CenterPanel;
        private Label order_number;
        private MonthCalendar monthCalendar1;
        private Button order_NextBtn;
        private Button order_AddBtn;
        private ComboBox order_Supplier;
        private Label order_SupplierLbl;
        private TextBox order_quantity;
        private Label label3;
        private TextBox order_PLUTextBox;
        private Label order_PLULbl;
        private Panel order_LeftPanel;
        private Panel order_panel;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private ListView order_currentListview;
        private TabPage tabPage3;
        private ListView order_All_listview;
        private TabPage tabPage_Inventory;
        private SplitContainer splitContainer1;
        private ListView inventory_listview;
        private Button exc_CancelBtn;
        private Button view_FilterBtn;
        private Button exc_ProcessBtn;
        private Label label2;
        private Button tools_ViewChangesBtn;
        private Label tools_label;
        private Button tools_EditBtn;
        private Button Tools_AddBtn;
        private TabControl tabControl_Inventory;
    }
}

