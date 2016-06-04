using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.View
{
    public partial class ProcessDialog : Form
    {
        private bool result = false;

        public ProcessDialog(string message)
        {
            InitializeComponent();
            this.label1.Text = message;
        }

        public bool Result
        {
            get
            {
                return result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.result = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
