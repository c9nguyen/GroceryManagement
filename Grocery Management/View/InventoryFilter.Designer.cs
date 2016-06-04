namespace WindowsFormsApplication1.View
{
    partial class InventoryFilter
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
            this.from_Lbl = new System.Windows.Forms.Label();
            this.to_Lbl = new System.Windows.Forms.Label();
            this.plu_Lbl = new System.Windows.Forms.Label();
            this.inStock_Lbl = new System.Windows.Forms.Label();
            this.price_Lbl = new System.Windows.Forms.Label();
            this.pluFrom_TxtBox = new System.Windows.Forms.TextBox();
            this.pluTo_TxtBox = new System.Windows.Forms.TextBox();
            this.stockTo_TxtBox = new System.Windows.Forms.TextBox();
            this.stockFrom_TxtBox = new System.Windows.Forms.TextBox();
            this.priceTo_TxtBox = new System.Windows.Forms.TextBox();
            this.priceFrom_TxtBox = new System.Windows.Forms.TextBox();
            this.apply_Btn = new System.Windows.Forms.Button();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // from_Lbl
            // 
            this.from_Lbl.AutoSize = true;
            this.from_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_Lbl.Location = new System.Drawing.Point(165, 26);
            this.from_Lbl.Name = "from_Lbl";
            this.from_Lbl.Size = new System.Drawing.Size(56, 20);
            this.from_Lbl.TabIndex = 0;
            this.from_Lbl.Text = "FROM";
            // 
            // to_Lbl
            // 
            this.to_Lbl.AutoSize = true;
            this.to_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_Lbl.Location = new System.Drawing.Point(275, 26);
            this.to_Lbl.Name = "to_Lbl";
            this.to_Lbl.Size = new System.Drawing.Size(30, 20);
            this.to_Lbl.TabIndex = 1;
            this.to_Lbl.Text = "TO";
            // 
            // plu_Lbl
            // 
            this.plu_Lbl.AutoSize = true;
            this.plu_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plu_Lbl.Location = new System.Drawing.Point(23, 55);
            this.plu_Lbl.Name = "plu_Lbl";
            this.plu_Lbl.Size = new System.Drawing.Size(40, 20);
            this.plu_Lbl.TabIndex = 2;
            this.plu_Lbl.Text = "PLU";
            // 
            // inStock_Lbl
            // 
            this.inStock_Lbl.AutoSize = true;
            this.inStock_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStock_Lbl.Location = new System.Drawing.Point(23, 133);
            this.inStock_Lbl.Name = "inStock_Lbl";
            this.inStock_Lbl.Size = new System.Drawing.Size(64, 20);
            this.inStock_Lbl.TabIndex = 3;
            this.inStock_Lbl.Text = "InStock";
            // 
            // price_Lbl
            // 
            this.price_Lbl.AutoSize = true;
            this.price_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_Lbl.Location = new System.Drawing.Point(23, 205);
            this.price_Lbl.Name = "price_Lbl";
            this.price_Lbl.Size = new System.Drawing.Size(44, 20);
            this.price_Lbl.TabIndex = 4;
            this.price_Lbl.Text = "Price";
            // 
            // pluFrom_TxtBox
            // 
            this.pluFrom_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluFrom_TxtBox.Location = new System.Drawing.Point(134, 52);
            this.pluFrom_TxtBox.Name = "pluFrom_TxtBox";
            this.pluFrom_TxtBox.Size = new System.Drawing.Size(92, 26);
            this.pluFrom_TxtBox.TabIndex = 5;
            // 
            // pluTo_TxtBox
            // 
            this.pluTo_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluTo_TxtBox.Location = new System.Drawing.Point(245, 52);
            this.pluTo_TxtBox.Name = "pluTo_TxtBox";
            this.pluTo_TxtBox.Size = new System.Drawing.Size(92, 26);
            this.pluTo_TxtBox.TabIndex = 6;
            // 
            // stockTo_TxtBox
            // 
            this.stockTo_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTo_TxtBox.Location = new System.Drawing.Point(245, 130);
            this.stockTo_TxtBox.Name = "stockTo_TxtBox";
            this.stockTo_TxtBox.Size = new System.Drawing.Size(92, 26);
            this.stockTo_TxtBox.TabIndex = 8;
            // 
            // stockFrom_TxtBox
            // 
            this.stockFrom_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockFrom_TxtBox.Location = new System.Drawing.Point(134, 130);
            this.stockFrom_TxtBox.Name = "stockFrom_TxtBox";
            this.stockFrom_TxtBox.Size = new System.Drawing.Size(92, 26);
            this.stockFrom_TxtBox.TabIndex = 7;
            // 
            // priceTo_TxtBox
            // 
            this.priceTo_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTo_TxtBox.Location = new System.Drawing.Point(245, 202);
            this.priceTo_TxtBox.Name = "priceTo_TxtBox";
            this.priceTo_TxtBox.Size = new System.Drawing.Size(92, 26);
            this.priceTo_TxtBox.TabIndex = 10;
            // 
            // priceFrom_TxtBox
            // 
            this.priceFrom_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceFrom_TxtBox.Location = new System.Drawing.Point(134, 202);
            this.priceFrom_TxtBox.Name = "priceFrom_TxtBox";
            this.priceFrom_TxtBox.Size = new System.Drawing.Size(92, 26);
            this.priceFrom_TxtBox.TabIndex = 9;
            // 
            // apply_Btn
            // 
            this.apply_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apply_Btn.Location = new System.Drawing.Point(26, 252);
            this.apply_Btn.Name = "apply_Btn";
            this.apply_Btn.Size = new System.Drawing.Size(115, 47);
            this.apply_Btn.TabIndex = 11;
            this.apply_Btn.Text = "Apply";
            this.apply_Btn.UseVisualStyleBackColor = true;
            this.apply_Btn.Click += new System.EventHandler(this.apply_Btn_Click);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Btn.Location = new System.Drawing.Point(222, 252);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(115, 47);
            this.cancel_Btn.TabIndex = 12;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = true;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // InventoryFilter
            // 
            this.AcceptButton = this.apply_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_Btn;
            this.ClientSize = new System.Drawing.Size(368, 317);
            this.Controls.Add(this.cancel_Btn);
            this.Controls.Add(this.apply_Btn);
            this.Controls.Add(this.priceTo_TxtBox);
            this.Controls.Add(this.priceFrom_TxtBox);
            this.Controls.Add(this.stockTo_TxtBox);
            this.Controls.Add(this.stockFrom_TxtBox);
            this.Controls.Add(this.pluTo_TxtBox);
            this.Controls.Add(this.pluFrom_TxtBox);
            this.Controls.Add(this.price_Lbl);
            this.Controls.Add(this.inStock_Lbl);
            this.Controls.Add(this.plu_Lbl);
            this.Controls.Add(this.to_Lbl);
            this.Controls.Add(this.from_Lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventoryFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryFilter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label from_Lbl;
        private System.Windows.Forms.Label to_Lbl;
        private System.Windows.Forms.Label plu_Lbl;
        private System.Windows.Forms.Label inStock_Lbl;
        private System.Windows.Forms.Label price_Lbl;
        private System.Windows.Forms.TextBox pluFrom_TxtBox;
        private System.Windows.Forms.TextBox pluTo_TxtBox;
        private System.Windows.Forms.TextBox stockTo_TxtBox;
        private System.Windows.Forms.TextBox stockFrom_TxtBox;
        private System.Windows.Forms.TextBox priceTo_TxtBox;
        private System.Windows.Forms.TextBox priceFrom_TxtBox;
        private System.Windows.Forms.Button apply_Btn;
        private System.Windows.Forms.Button cancel_Btn;
    }
}