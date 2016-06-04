namespace WindowsFormsApplication1.View
{
    partial class InventoryEditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.new_Lbl = new System.Windows.Forms.Label();
            this.current_Lbl = new System.Windows.Forms.Label();
            this.apply_Btn = new System.Windows.Forms.Button();
            this.description_Box = new System.Windows.Forms.RichTextBox();
            this.description_Lbl = new System.Windows.Forms.Label();
            this.priceValue_Lbl = new System.Windows.Forms.Label();
            this.newPrice_Box = new System.Windows.Forms.RichTextBox();
            this.price_Lbl = new System.Windows.Forms.Label();
            this.instockValue_Lbl = new System.Windows.Forms.Label();
            this.newStock_Box = new System.Windows.Forms.RichTextBox();
            this.instock_Lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.cancel_Btn);
            this.panel1.Controls.Add(this.new_Lbl);
            this.panel1.Controls.Add(this.current_Lbl);
            this.panel1.Controls.Add(this.apply_Btn);
            this.panel1.Controls.Add(this.description_Box);
            this.panel1.Controls.Add(this.description_Lbl);
            this.panel1.Controls.Add(this.priceValue_Lbl);
            this.panel1.Controls.Add(this.newPrice_Box);
            this.panel1.Controls.Add(this.price_Lbl);
            this.panel1.Controls.Add(this.instockValue_Lbl);
            this.panel1.Controls.Add(this.newStock_Box);
            this.panel1.Controls.Add(this.instock_Lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 560);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.Location = new System.Drawing.Point(399, 500);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(127, 48);
            this.cancel_Btn.TabIndex = 15;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = true;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // new_Lbl
            // 
            this.new_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.new_Lbl.AutoSize = true;
            this.new_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Lbl.Location = new System.Drawing.Point(353, 9);
            this.new_Lbl.Name = "new_Lbl";
            this.new_Lbl.Size = new System.Drawing.Size(132, 25);
            this.new_Lbl.TabIndex = 14;
            this.new_Lbl.Text = "New Values:";
            // 
            // current_Lbl
            // 
            this.current_Lbl.AutoSize = true;
            this.current_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_Lbl.Location = new System.Drawing.Point(12, 9);
            this.current_Lbl.Name = "current_Lbl";
            this.current_Lbl.Size = new System.Drawing.Size(155, 25);
            this.current_Lbl.TabIndex = 13;
            this.current_Lbl.Text = "Current Values";
            // 
            // apply_Btn
            // 
            this.apply_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apply_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_Btn.Location = new System.Drawing.Point(67, 500);
            this.apply_Btn.Name = "apply_Btn";
            this.apply_Btn.Size = new System.Drawing.Size(127, 48);
            this.apply_Btn.TabIndex = 11;
            this.apply_Btn.Text = "Apply";
            this.apply_Btn.UseVisualStyleBackColor = true;
            this.apply_Btn.Click += new System.EventHandler(this.apply_Btn_Click);
            // 
            // description_Box
            // 
            this.description_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_Box.Location = new System.Drawing.Point(18, 235);
            this.description_Box.Name = "description_Box";
            this.description_Box.Size = new System.Drawing.Size(562, 259);
            this.description_Box.TabIndex = 10;
            this.description_Box.Text = "";
            // 
            // description_Lbl
            // 
            this.description_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.description_Lbl.AutoSize = true;
            this.description_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_Lbl.Location = new System.Drawing.Point(13, 207);
            this.description_Lbl.Name = "description_Lbl";
            this.description_Lbl.Size = new System.Drawing.Size(120, 25);
            this.description_Lbl.TabIndex = 9;
            this.description_Lbl.Text = "Description";
            // 
            // priceValue_Lbl
            // 
            this.priceValue_Lbl.AutoSize = true;
            this.priceValue_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceValue_Lbl.Location = new System.Drawing.Point(107, 137);
            this.priceValue_Lbl.Name = "priceValue_Lbl";
            this.priceValue_Lbl.Size = new System.Drawing.Size(0, 25);
            this.priceValue_Lbl.TabIndex = 7;
            // 
            // newPrice_Box
            // 
            this.newPrice_Box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newPrice_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrice_Box.Location = new System.Drawing.Point(358, 134);
            this.newPrice_Box.Name = "newPrice_Box";
            this.newPrice_Box.Size = new System.Drawing.Size(127, 42);
            this.newPrice_Box.TabIndex = 6;
            this.newPrice_Box.Text = "";
            this.newPrice_Box.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // price_Lbl
            // 
            this.price_Lbl.AutoSize = true;
            this.price_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_Lbl.Location = new System.Drawing.Point(12, 137);
            this.price_Lbl.Name = "price_Lbl";
            this.price_Lbl.Size = new System.Drawing.Size(61, 25);
            this.price_Lbl.TabIndex = 5;
            this.price_Lbl.Text = "Price";
            // 
            // instockValue_Lbl
            // 
            this.instockValue_Lbl.AutoSize = true;
            this.instockValue_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instockValue_Lbl.Location = new System.Drawing.Point(107, 66);
            this.instockValue_Lbl.Name = "instockValue_Lbl";
            this.instockValue_Lbl.Size = new System.Drawing.Size(0, 25);
            this.instockValue_Lbl.TabIndex = 3;
            // 
            // newStock_Box
            // 
            this.newStock_Box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newStock_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStock_Box.Location = new System.Drawing.Point(358, 63);
            this.newStock_Box.Name = "newStock_Box";
            this.newStock_Box.Size = new System.Drawing.Size(127, 42);
            this.newStock_Box.TabIndex = 2;
            this.newStock_Box.Text = "";
            this.newStock_Box.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // instock_Lbl
            // 
            this.instock_Lbl.AutoSize = true;
            this.instock_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instock_Lbl.Location = new System.Drawing.Point(12, 66);
            this.instock_Lbl.Name = "instock_Lbl";
            this.instock_Lbl.Size = new System.Drawing.Size(89, 25);
            this.instock_Lbl.TabIndex = 0;
            this.instock_Lbl.Text = "InStock:";
            // 
            // InventoryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventoryEditor";
            this.Text = "InventoryEditor";
            this.Load += new System.EventHandler(this.InventoryEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label instockValue_Lbl;
        private System.Windows.Forms.RichTextBox newStock_Box;
        private System.Windows.Forms.Label instock_Lbl;
        private System.Windows.Forms.Button apply_Btn;
        private System.Windows.Forms.RichTextBox description_Box;
        private System.Windows.Forms.Label description_Lbl;
        private System.Windows.Forms.Label priceValue_Lbl;
        private System.Windows.Forms.RichTextBox newPrice_Box;
        private System.Windows.Forms.Label price_Lbl;
        private System.Windows.Forms.Label new_Lbl;
        private System.Windows.Forms.Label current_Lbl;
        private System.Windows.Forms.Button cancel_Btn;
    }
}