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
            this.tabControl_Inventory = new System.Windows.Forms.TabControl();
            this.tabPage_Inventory = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.views_SupplierCheck = new System.Windows.Forms.CheckBox();
            this.views_ExtractBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tools_FilterBtn = new System.Windows.Forms.Button();
            this.tools_UndoBtn = new System.Windows.Forms.Button();
            this.tools_ViewChangesBtn = new System.Windows.Forms.Button();
            this.tools_label = new System.Windows.Forms.Label();
            this.tools_EditBtn = new System.Windows.Forms.Button();
            this.tabPage_Order = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.views_SaleRateCheck = new System.Windows.Forms.CheckBox();
            this.tabControl_Inventory.SuspendLayout();
            this.tabPage_Inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl_Inventory.Size = new System.Drawing.Size(1219, 610);
            this.tabControl_Inventory.TabIndex = 0;
            // 
            // tabPage_Inventory
            // 
            this.tabPage_Inventory.Controls.Add(this.splitContainer1);
            this.tabPage_Inventory.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Inventory.Name = "tabPage_Inventory";
            this.tabPage_Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Inventory.Size = new System.Drawing.Size(1211, 572);
            this.tabPage_Inventory.TabIndex = 0;
            this.tabPage_Inventory.Text = "Inventory";
            this.tabPage_Inventory.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.views_SaleRateCheck);
            this.splitContainer1.Panel2.Controls.Add(this.views_SupplierCheck);
            this.splitContainer1.Panel2.Controls.Add(this.views_ExtractBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Tools_FilterBtn);
            this.splitContainer1.Panel2.Controls.Add(this.tools_UndoBtn);
            this.splitContainer1.Panel2.Controls.Add(this.tools_ViewChangesBtn);
            this.splitContainer1.Panel2.Controls.Add(this.tools_label);
            this.splitContainer1.Panel2.Controls.Add(this.tools_EditBtn);
            this.splitContainer1.Size = new System.Drawing.Size(1205, 566);
            this.splitContainer1.SplitterDistance = 918;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(918, 566);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Supplier";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Setll Rate";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sett rate max";
            this.columnHeader4.Width = 143;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "InStock";
            this.columnHeader5.Width = 641;
            // 
            // views_SupplierCheck
            // 
            this.views_SupplierCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.views_SupplierCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.views_SupplierCheck.Location = new System.Drawing.Point(34, 354);
            this.views_SupplierCheck.Name = "views_SupplierCheck";
            this.views_SupplierCheck.Size = new System.Drawing.Size(212, 35);
            this.views_SupplierCheck.TabIndex = 9;
            this.views_SupplierCheck.Text = "No Supplier";
            this.views_SupplierCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.views_SupplierCheck.UseVisualStyleBackColor = true;
            // 
            // views_ExtractBtn
            // 
            this.views_ExtractBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.views_ExtractBtn.Location = new System.Drawing.Point(34, 470);
            this.views_ExtractBtn.Name = "views_ExtractBtn";
            this.views_ExtractBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.views_ExtractBtn.Size = new System.Drawing.Size(212, 36);
            this.views_ExtractBtn.TabIndex = 8;
            this.views_ExtractBtn.Text = "ExtractWindow";
            this.views_ExtractBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Views";
            // 
            // Tools_FilterBtn
            // 
            this.Tools_FilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tools_FilterBtn.Location = new System.Drawing.Point(34, 233);
            this.Tools_FilterBtn.Name = "Tools_FilterBtn";
            this.Tools_FilterBtn.Size = new System.Drawing.Size(212, 36);
            this.Tools_FilterBtn.TabIndex = 4;
            this.Tools_FilterBtn.Text = "Filter";
            this.Tools_FilterBtn.UseVisualStyleBackColor = true;
            // 
            // tools_UndoBtn
            // 
            this.tools_UndoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tools_UndoBtn.Location = new System.Drawing.Point(34, 172);
            this.tools_UndoBtn.Name = "tools_UndoBtn";
            this.tools_UndoBtn.Size = new System.Drawing.Size(212, 36);
            this.tools_UndoBtn.TabIndex = 3;
            this.tools_UndoBtn.Text = "Undo";
            this.tools_UndoBtn.UseVisualStyleBackColor = true;
            // 
            // tools_ViewChangesBtn
            // 
            this.tools_ViewChangesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tools_ViewChangesBtn.Location = new System.Drawing.Point(34, 113);
            this.tools_ViewChangesBtn.Name = "tools_ViewChangesBtn";
            this.tools_ViewChangesBtn.Size = new System.Drawing.Size(212, 36);
            this.tools_ViewChangesBtn.TabIndex = 2;
            this.tools_ViewChangesBtn.Text = "View Changes";
            this.tools_ViewChangesBtn.UseVisualStyleBackColor = true;
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
            // tools_EditBtn
            // 
            this.tools_EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tools_EditBtn.Location = new System.Drawing.Point(34, 57);
            this.tools_EditBtn.Name = "tools_EditBtn";
            this.tools_EditBtn.Size = new System.Drawing.Size(212, 36);
            this.tools_EditBtn.TabIndex = 0;
            this.tools_EditBtn.Text = "Edit";
            this.tools_EditBtn.UseVisualStyleBackColor = true;
            this.tools_EditBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage_Order
            // 
            this.tabPage_Order.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Order.Name = "tabPage_Order";
            this.tabPage_Order.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Order.Size = new System.Drawing.Size(1211, 572);
            this.tabPage_Order.TabIndex = 1;
            this.tabPage_Order.Text = "Order";
            this.tabPage_Order.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1211, 572);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // views_SaleRateCheck
            // 
            this.views_SaleRateCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.views_SaleRateCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.views_SaleRateCheck.Location = new System.Drawing.Point(34, 413);
            this.views_SaleRateCheck.Name = "views_SaleRateCheck";
            this.views_SaleRateCheck.Size = new System.Drawing.Size(212, 35);
            this.views_SaleRateCheck.TabIndex = 10;
            this.views_SaleRateCheck.Text = "No Sale Rate";
            this.views_SaleRateCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.views_SaleRateCheck.UseVisualStyleBackColor = true;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 610);
            this.Controls.Add(this.tabControl_Inventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_Inventory.ResumeLayout(false);
            this.tabPage_Inventory.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl_Inventory;
        private TabPage tabPage_Inventory;
        private TabPage tabPage_Order;
        private SplitContainer splitContainer1;
        private ListView listView1;
        private ColumnHeader Product;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button tools_EditBtn;
        private TabPage tabPage1;
        private Button views_ExtractBtn;
        private Label label2;
        private Button Tools_FilterBtn;
        private Button tools_UndoBtn;
        private Button tools_ViewChangesBtn;
        private Label tools_label;
        private CheckBox views_SupplierCheck;
        private CheckBox views_SaleRateCheck;
    }
}

