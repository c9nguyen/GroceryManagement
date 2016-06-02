using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Frame : Form
    {
        public static double DEFAULT_HEIGHT_RATIO = 0.7;
        public static double DEFAULT_WIDTH_RATIO = 0.6;

        private bool lastColumnResizing = false;

        public Frame()
        {
            InitializeComponent();
            splitcontrol_Load();
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


        private void listview_SizeChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (!lastColumnResizing)
            {
                lastColumnResizing = true;

                ListView listview = sender as ListView;
                if (listview != null)
                {
                    int columnsCount = listview.Columns.Count;
                    listview.Columns[columnsCount - 1].Width = -2;
                    Console.WriteLine(listview.Columns[columnsCount - 1].Width);
                }

                lastColumnResizing = false;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listView1.Columns.RemoveAt(0);
        }
    }
}
