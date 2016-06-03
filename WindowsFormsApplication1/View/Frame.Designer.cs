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
            this.inventory_listview = new System.Windows.Forms.ListView();
            this.view_FilterBtn = new System.Windows.Forms.Button();
            this.views_SupplierCheck = new System.Windows.Forms.CheckBox();
            this.views_ExtractBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tools_AddBtn = new System.Windows.Forms.Button();
            this.tools_UndoBtn = new System.Windows.Forms.Button();
            this.tools_ViewChangesBtn = new System.Windows.Forms.Button();
            this.tools_label = new System.Windows.Forms.Label();
            this.tools_EditBtn = new System.Windows.Forms.Button();
            this.tabPage_Order = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.splitContainer1.Panel1.Controls.Add(this.inventory_listview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.view_FilterBtn);
            this.splitContainer1.Panel2.Controls.Add(this.views_SupplierCheck);
            this.splitContainer1.Panel2.Controls.Add(this.views_ExtractBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Tools_AddBtn);
            this.splitContainer1.Panel2.Controls.Add(this.tools_UndoBtn);
            this.splitContainer1.Panel2.Controls.Add(this.tools_ViewChangesBtn);
            this.splitContainer1.Panel2.Controls.Add(this.tools_label);
            this.splitContainer1.Panel2.Controls.Add(this.tools_EditBtn);
            this.splitContainer1.Size = new System.Drawing.Size(1205, 566);
            this.splitContainer1.SplitterDistance = 918;
            this.splitContainer1.TabIndex = 0;
            // 
            // inventory_listview
            // 
            this.inventory_listview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory_listview.FullRowSelect = true;
            this.inventory_listview.GridLines = true;
            this.inventory_listview.Location = new System.Drawing.Point(0, 0);
            this.inventory_listview.Name = "inventory_listview";
            this.inventory_listview.Size = new System.Drawing.Size(918, 566);
            this.inventory_listview.TabIndex = 0;
            this.inventory_listview.UseCompatibleStateImageBehavior = false;
            this.inventory_listview.View = System.Windows.Forms.View.Details;
            this.inventory_listview.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listview_SizeChanged);
            this.inventory_listview.SelectedIndexChanged += new System.EventHandler(this.inventory_listview_SelectedIndexChanged);
            // 
            // view_FilterBtn
            // 
            this.view_FilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_FilterBtn.Location = new System.Drawing.Point(34, 295);
            this.view_FilterBtn.Name = "view_FilterBtn";
            this.view_FilterBtn.Size = new System.Drawing.Size(212, 36);
            this.view_FilterBtn.TabIndex = 10;
            this.view_FilterBtn.Text = "Filter";
            this.view_FilterBtn.UseVisualStyleBackColor = true;
            // 
            // views_SupplierCheck
            // 
            this.views_SupplierCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.views_SupplierCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.views_SupplierCheck.Location = new System.Drawing.Point(34, 411);
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
            this.views_ExtractBtn.Location = new System.Drawing.Point(34, 353);
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
            this.label2.Location = new System.Drawing.Point(5, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Views";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tools_AddBtn
            // 
            this.Tools_AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tools_AddBtn.Location = new System.Drawing.Point(34, 212);
            this.Tools_AddBtn.Name = "Tools_AddBtn";
            this.Tools_AddBtn.Size = new System.Drawing.Size(212, 36);
            this.Tools_AddBtn.TabIndex = 4;
            this.Tools_AddBtn.Text = "Add Product";
            this.Tools_AddBtn.UseVisualStyleBackColor = true;
            // 
            // tools_UndoBtn
            // 
            this.tools_UndoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tools_UndoBtn.Enabled = false;
            this.tools_UndoBtn.Location = new System.Drawing.Point(34, 154);
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
            this.tools_ViewChangesBtn.Enabled = false;
            this.tools_ViewChangesBtn.Location = new System.Drawing.Point(34, 96);
            this.tools_ViewChangesBtn.Name = "tools_ViewChangesBtn";
            this.tools_ViewChangesBtn.Size = new System.Drawing.Size(212, 36);
            this.tools_ViewChangesBtn.TabIndex = 2;
            this.tools_ViewChangesBtn.Text = "View Change";
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
            this.tools_EditBtn.Enabled = false;
            this.tools_EditBtn.Location = new System.Drawing.Point(34, 38);
            this.tools_EditBtn.Name = "tools_EditBtn";
            this.tools_EditBtn.Size = new System.Drawing.Size(212, 36);
            this.tools_EditBtn.TabIndex = 0;
            this.tools_EditBtn.Text = "Edit";
            this.tools_EditBtn.UseVisualStyleBackColor = true;
            this.tools_EditBtn.Click += new System.EventHandler(this.tools_EditBtn_Click);
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
        private ListView inventory_listview;
        private Button tools_EditBtn;
        private TabPage tabPage1;
        private Button views_ExtractBtn;
        private Label label2;
        private Button Tools_AddBtn;
        private Button tools_UndoBtn;
        private Button tools_ViewChangesBtn;
        private Label tools_label;
        private CheckBox views_SupplierCheck;
        private Button view_FilterBtn;
    }
}

