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

namespace WindowsFormsApplication1.View
{
    public partial class InventoryFilter : Form
    {
        private int DEFAULT_FONT_SIZE = (Screen.PrimaryScreen.WorkingArea.Width / 100);
        private ArrayList currentList;
        private ArrayList newList;

        public InventoryFilter()
        {
            InitializeComponent();
    
        }

        private void setFrontSize()
        {
            int size = DEFAULT_FONT_SIZE + 5;
            this.from_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plu_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStock_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluFrom_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluTo_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTo_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockFrom_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTo_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceFrom_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        /// <summary>
        /// Get item data from man list.
        /// </summary>
        /// <param name="currentList"></param>
        public void filter(ArrayList itemList)
        {
            this.CurrentList = itemList;
            this.NewList = new ArrayList();
        }

        /// <summary>
        /// Get data from box text and filter items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void apply_Btn_Click(object sender, EventArgs e)
        {
            double valid = 0;
            double pluFr, pluTo, stockFr, stockTo, priceFr, priceTo;
            bool check = true;

            //Check valid inputs
            valid += double.TryParse(pluFrom_TxtBox.Text, out pluFr) || pluFrom_TxtBox.Text.Length == 0 ? 1 : 0;
            valid += double.TryParse(pluTo_TxtBox.Text, out pluTo) || pluTo_TxtBox.Text.Length == 0 ? 1 : 0;
            valid += double.TryParse(stockFrom_TxtBox.Text, out stockFr) || stockFrom_TxtBox.Text.Length == 0 ? 1 : 0;
            valid += double.TryParse(stockTo_TxtBox.Text, out stockTo) || stockTo_TxtBox.Text.Length == 0 ? 1 : 0;
            valid += double.TryParse(priceFrom_TxtBox.Text, out priceFr) || priceFrom_TxtBox.Text.Length == 0 ? 1 : 0;
            valid += double.TryParse(priceTo_TxtBox.Text, out priceTo) || priceTo_TxtBox.Text.Length == 0 ? 1 : 0;

            if (valid == 6)
            {
                NewList = new ArrayList();           
                foreach (InventoryItem item in CurrentList) //Filtering items
                {
                    check = true;
                    
                    //Check plu
                    valid = double.Parse(item.Plu);
                    if (pluFrom_TxtBox.Text.Length > 0 && valid < pluFr) check = false;
                    if (pluTo_TxtBox.Text.Length > 0 && valid > pluTo) check = false;

                    if (check)
                    {
                        //Check instock
                        valid = double.Parse(item.InStock);
                        if (stockFrom_TxtBox.Text.Length > 0 && valid < stockFr) check = false;
                        if (stockTo_TxtBox.Text.Length > 0 && valid > stockTo) check = false;

                        if (check)
                        {
                            //Check price
                            valid = double.Parse(item.Price);
                            if (priceFrom_TxtBox.Text.Length > 0 && valid < priceFr) check = false;
                            if (priceTo_TxtBox.Text.Length > 0 && valid > priceTo) check = false;
                        }     
                    }
                    // If item meets all requirements, add to new list.
                    if (check)
                    {
                        NewList.Add(item);
                    }
                }

                this.Hide();
            }
        }


        /// <summary>
        /// 
        /// Hide filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public ArrayList CurrentList
        {
            get
            {
                return currentList;
            }

            set
            {
                currentList = value;
            }
        }

        public ArrayList NewList
        {
            get
            {
                return newList;
            }

            set
            {
                newList = value;
            }
        }

    }
}
