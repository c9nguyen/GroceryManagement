using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    class InventoryData
    {
        enum Database { PLU, Name, Supplier_ID, Min_Sell_Rate, Max_Sell_Rate, In_Stock, Price };  

        private String connectionString;
        private SqlConnection sqlConnection;

        public InventoryData()
        {
            connectionString = "Data Source = chinh.database.windows.net; Initial Catalog = NGUYEN_CHINH_DB; Integrated Security = False; User ID = cnguyen; Password=Concuadatabase123;Connect Timeout = 15; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(connectionString);
        }

        /// <summary>
        ///  Read data from database then return list of items from Database.
        /// 
        /// </summary>
        /// <returns> List of items from database. </returns>
        public ArrayList loadInventoryData()
        {
            ArrayList itemList = new ArrayList();
            try
            {
                sqlConnection.Open();
                SqlCommand theCommand = new SqlCommand("SELECT Inventory.*, Product.Name, Price.Price " +
                                                        "FROM Inventory, Product, Price " +
                                                        "WHERE Inventory.PLU = Product.PLU AND Inventory.PLU = Price.PLU", sqlConnection);
                SqlDataReader theReader = theCommand.ExecuteReader();
       
                while (theReader.Read())
                {
                    InventoryItem item = new InventoryItem(theReader[Database.PLU.ToString()].ToString(),
                                                           theReader[Database.Supplier_ID.ToString()].ToString(),
                                                           theReader[Database.Min_Sell_Rate.ToString()].ToString(),
                                                           theReader[Database.Min_Sell_Rate.ToString()].ToString(),
                                                           theReader[Database.In_Stock.ToString()].ToString(),
                                                           theReader[Database.Name.ToString()].ToString(),
                                                           theReader[Database.Price.ToString()].ToString());
                    itemList.Add(item);
                }
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                sqlConnection.Close();
                Console.WriteLine(e.ToString());
            }

            return itemList;
        }

        public void updateInStock(InventoryItem newItem)
        {

        }
    }
}
