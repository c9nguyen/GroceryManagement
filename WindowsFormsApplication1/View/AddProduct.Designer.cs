namespace WindowsFormsApplication1.View
{
    partial class AddProduct
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
            this.addPanel = new System.Windows.Forms.Panel();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.apply_Btn = new System.Windows.Forms.Button();
            this.description_TextBox = new System.Windows.Forms.RichTextBox();
            this.price_TextBox = new System.Windows.Forms.TextBox();
            this.instock_TextBox = new System.Windows.Forms.TextBox();
            this.plu_TextBox = new System.Windows.Forms.TextBox();
            this.description_Lbl = new System.Windows.Forms.Label();
            this.price_Lbl = new System.Windows.Forms.Label();
            this.instock_Lbl = new System.Windows.Forms.Label();
            this.supplier_ComboBox = new System.Windows.Forms.ComboBox();
            this.supplier_Lbl = new System.Windows.Forms.Label();
            this.plu_Lbl = new System.Windows.Forms.Label();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.cancel_Btn);
            this.addPanel.Controls.Add(this.apply_Btn);
            this.addPanel.Controls.Add(this.description_TextBox);
            this.addPanel.Controls.Add(this.price_TextBox);
            this.addPanel.Controls.Add(this.instock_TextBox);
            this.addPanel.Controls.Add(this.plu_TextBox);
            this.addPanel.Controls.Add(this.description_Lbl);
            this.addPanel.Controls.Add(this.price_Lbl);
            this.addPanel.Controls.Add(this.instock_Lbl);
            this.addPanel.Controls.Add(this.supplier_ComboBox);
            this.addPanel.Controls.Add(this.supplier_Lbl);
            this.addPanel.Controls.Add(this.plu_Lbl);
            this.addPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPanel.Location = new System.Drawing.Point(0, 0);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(508, 553);
            this.addPanel.TabIndex = 0;
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.Location = new System.Drawing.Point(323, 478);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(160, 61);
            this.cancel_Btn.TabIndex = 14;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // apply_Btn
            // 
            this.apply_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apply_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_Btn.Location = new System.Drawing.Point(28, 478);
            this.apply_Btn.Name = "apply_Btn";
            this.apply_Btn.Size = new System.Drawing.Size(160, 61);
            this.apply_Btn.TabIndex = 13;
            this.apply_Btn.Text = "Apply";
            this.apply_Btn.UseVisualStyleBackColor = true;
            this.apply_Btn.Click += new System.EventHandler(this.apply_Btn_Click);
            // 
            // description_TextBox
            // 
            this.description_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.description_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_TextBox.Location = new System.Drawing.Point(33, 302);
            this.description_TextBox.Name = "description_TextBox";
            this.description_TextBox.Size = new System.Drawing.Size(450, 150);
            this.description_TextBox.TabIndex = 12;
            this.description_TextBox.Text = "";
            // 
            // price_TextBox
            // 
            this.price_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.price_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_TextBox.Location = new System.Drawing.Point(255, 213);
            this.price_TextBox.Name = "price_TextBox";
            this.price_TextBox.Size = new System.Drawing.Size(229, 31);
            this.price_TextBox.TabIndex = 11;
            // 
            // instock_TextBox
            // 
            this.instock_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instock_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instock_TextBox.Location = new System.Drawing.Point(255, 145);
            this.instock_TextBox.Name = "instock_TextBox";
            this.instock_TextBox.Size = new System.Drawing.Size(228, 31);
            this.instock_TextBox.TabIndex = 10;
            // 
            // plu_TextBox
            // 
            this.plu_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plu_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plu_TextBox.Location = new System.Drawing.Point(255, 22);
            this.plu_TextBox.Name = "plu_TextBox";
            this.plu_TextBox.Size = new System.Drawing.Size(228, 31);
            this.plu_TextBox.TabIndex = 9;
            this.plu_TextBox.TextChanged += new System.EventHandler(this.plu_TextBox_TextChanged);
            // 
            // description_Lbl
            // 
            this.description_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.description_Lbl.AutoSize = true;
            this.description_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_Lbl.Location = new System.Drawing.Point(28, 274);
            this.description_Lbl.Name = "description_Lbl";
            this.description_Lbl.Size = new System.Drawing.Size(120, 25);
            this.description_Lbl.TabIndex = 8;
            this.description_Lbl.Text = "Description";
            // 
            // price_Lbl
            // 
            this.price_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.price_Lbl.AutoSize = true;
            this.price_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_Lbl.Location = new System.Drawing.Point(28, 216);
            this.price_Lbl.Name = "price_Lbl";
            this.price_Lbl.Size = new System.Drawing.Size(61, 25);
            this.price_Lbl.TabIndex = 6;
            this.price_Lbl.Text = "Price";
            // 
            // instock_Lbl
            // 
            this.instock_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.instock_Lbl.AutoSize = true;
            this.instock_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instock_Lbl.Location = new System.Drawing.Point(28, 148);
            this.instock_Lbl.Name = "instock_Lbl";
            this.instock_Lbl.Size = new System.Drawing.Size(83, 25);
            this.instock_Lbl.TabIndex = 4;
            this.instock_Lbl.Text = "InStock";
            // 
            // supplier_ComboBox
            // 
            this.supplier_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplier_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplier_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_ComboBox.FormattingEnabled = true;
            this.supplier_ComboBox.Location = new System.Drawing.Point(255, 84);
            this.supplier_ComboBox.Name = "supplier_ComboBox";
            this.supplier_ComboBox.Size = new System.Drawing.Size(216, 33);
            this.supplier_ComboBox.TabIndex = 3;
            // 
            // supplier_Lbl
            // 
            this.supplier_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.supplier_Lbl.AutoSize = true;
            this.supplier_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_Lbl.Location = new System.Drawing.Point(28, 87);
            this.supplier_Lbl.Name = "supplier_Lbl";
            this.supplier_Lbl.Size = new System.Drawing.Size(91, 25);
            this.supplier_Lbl.TabIndex = 2;
            this.supplier_Lbl.Text = "Supplier";
            // 
            // plu_Lbl
            // 
            this.plu_Lbl.AutoSize = true;
            this.plu_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plu_Lbl.Location = new System.Drawing.Point(28, 22);
            this.plu_Lbl.Name = "plu_Lbl";
            this.plu_Lbl.Size = new System.Drawing.Size(53, 25);
            this.plu_Lbl.TabIndex = 0;
            this.plu_Lbl.Text = "PLU";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 553);
            this.Controls.Add(this.addPanel);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button cancel_Btn;
        private System.Windows.Forms.Button apply_Btn;
        private System.Windows.Forms.RichTextBox description_TextBox;
        private System.Windows.Forms.TextBox price_TextBox;
        private System.Windows.Forms.TextBox instock_TextBox;
        private System.Windows.Forms.TextBox plu_TextBox;
        private System.Windows.Forms.Label description_Lbl;
        private System.Windows.Forms.Label price_Lbl;
        private System.Windows.Forms.Label instock_Lbl;
        private System.Windows.Forms.ComboBox supplier_ComboBox;
        private System.Windows.Forms.Label supplier_Lbl;
        private System.Windows.Forms.Label plu_Lbl;
    }
}