using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;
using WindowsFormsApplication1.View;

namespace View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                              Application.Run(new Frame());

            //Application.Run(new InventoryEditor());
            //Application.Run(new AddProduct());
            //Application.Run(new InventoryFilter());
        }
    }
}
