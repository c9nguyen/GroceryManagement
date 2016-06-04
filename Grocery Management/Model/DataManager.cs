using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
     class DataManager
    {
        enum Database { PLU, Name, Supplier_ID, Supplier_Name, In_Stock, Price, Order_Number,
                        Order_Date, Quantity};  

        private String connectionString;
        private SqlConnection sqlConnection;

        public DataManager()
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
                                                           theReader[Database.In_Stock.ToString()].ToString(),
                                                           theReader[Database.Name.ToString()].ToString(),
                                                           theReader[Database.Price.ToString()].ToString());
                    itemList.Add(item);
                }
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                itemList = null;
                sqlConnection.Close();
                Console.WriteLine(e.ToString());
            }

            return itemList;
        }

        /// <summary>
        /// Get list of supplier from PLU
        /// </summary>
        /// <param name="plu"></param>
        /// <returns></returns>
        public List<SupplierItem> getSupplierList(string plu)
        {
            List<SupplierItem> itemList = new List<SupplierItem>();
            try
            {
                sqlConnection.Open();
                SqlCommand theCommand = new SqlCommand("SELECT DISTINCT Supplier.* " +
                                                        "FROM Supplier_Product, Supplier " +
                                                        "WHERE Supplier_Product.PLU = " + plu +
                                                        "AND Supplier_Product.Supplier_ID = Supplier.Supplier_ID", sqlConnection);
                SqlDataReader theReader = theCommand.ExecuteReader();

                while (theReader.Read())
                {
                    SupplierItem item = new SupplierItem(theReader[Database.Supplier_ID.ToString()].ToString(),
                                                           theReader[Database.Supplier_Name.ToString()].ToString());
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

        /// <summary>
        /// Search for product name base on PLU
        /// </summary>
        /// <param name="plu"></param>
        /// <returns></returns>
        public string getProductName(string plu)
        {
            string product = "";

            try
            {
                sqlConnection.Open();
                SqlCommand theCommand = new SqlCommand("SELECT DISTINCT Name " +
                                                        "FROM Product  " +
                                                        "WHERE Product.PLU = " + plu, sqlConnection);
                SqlDataReader theReader = theCommand.ExecuteReader();
                theReader.Read();
                product = theReader[Database.Name.ToString()].ToString();     
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                sqlConnection.Close();
                Console.WriteLine(e.ToString());
            }

            return product;
        }

        /// <summary>
        /// Get all changes then update to the database
        /// </summary>
        /// <param name="changesList"></param>
        public void updateDatabase(List<InventoryItem> changesList)
        {
            foreach(InventoryItem item in changesList)
            {
                try
                {                  
                    SqlCommand theCommand;
                    if (item.NewItem)       //Insert if it's new item
                    {
                        theCommand = new SqlCommand("INSERT INTO Inventory VALUES (@PLU, @Supplier_ID, @In_Stock) " +
                                                    "INSERT INTO Price VALUES (@PLU, @Price)");
                        theCommand.CommandType = System.Data.CommandType.Text;
                        theCommand.Parameters.AddWithValue("@PLU", item.Plu);
                        theCommand.Parameters.AddWithValue("@Supplier_ID", item.Supplier_id);
                        theCommand.Parameters.AddWithValue("@In_Stock", item.InStock);
                        theCommand.Parameters.AddWithValue("@Price", item.Price);
                    }
                    else                    //Otherwise, update
                    {


                       theCommand = new SqlCommand("UPDATE Inventory " +
                                                   "SET In_Stock = " + item.InStock +
                                                   " WHERE PLU = " + item.Plu +
                                                   " AND " + " Supplier_ID = " + item.Supplier_id +
                                                   "UPDATE Price " +
                                                   "SET Price = " + item.Price +
                                                   " WHERE PLU = " + item.Plu);

                    }
                    sqlConnection.Open();
                    theCommand.Connection = sqlConnection;
                    theCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception e)
                {
                    sqlConnection.Close();
                    Console.WriteLine(e.ToString());
                }
            }
        }


        //////////////////
        /// Order Tab ///
        ////////////////

        /// <summary>
        ///  Read data from database then return list of items from Database.
        /// 
        /// </summary>
        /// <returns> List of items from database. </returns>
        public ArrayList loadOrderData()
        {
            ArrayList itemList = new ArrayList();
            try
            {
                sqlConnection.Open();
                SqlCommand theCommand = new SqlCommand("SELECT Supply_Order.*, Order_Include.Quantity, Supplier.*, Product.Name, Product.PLU " +
                                                        "FROM Supply_Order, Order_Include, Supplier, Product " +
                                                        "WHERE Supply_Order.Order_Number = Order_Include.Order_Number " +
                                                        " AND Supplier.Supplier_ID = Order_Include.Supplier_ID " +
                                                        " AND Product.PLU = Order_Include.PLU" , sqlConnection);
                SqlDataReader theReader = theCommand.ExecuteReader();

                while (theReader.Read())
                {
                    OrderItem item = new OrderItem(theReader[Database.PLU.ToString()].ToString(), 
                                                    theReader[Database.Order_Number.ToString()].ToString(),
                                                    theReader[Database.Order_Date.ToString()].ToString(),
                                                    theReader[Database.Quantity.ToString()].ToString(),
                                                    theReader[Database.Supplier_Name.ToString()].ToString(),
                                                    theReader[Database.Supplier_ID.ToString()].ToString(),
                                                    theReader[Database.Name.ToString()].ToString());
                    itemList.Add(item);
                }
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                itemList = null;
                sqlConnection.Close();
                Console.WriteLine(e.ToString());
            }

            return itemList;
        }

        public string getLargestOrderNumber()
        {
            string orderNumber;
            try
            {
                sqlConnection.Open();
                SqlCommand theCommand = new SqlCommand("SELECT MAX(Order_Number) AS LatestOrder FROM Supply_Order", sqlConnection);
                SqlDataReader theReader = theCommand.ExecuteReader();

                theReader.Read();
                orderNumber = theReader["LatestOrder"].ToString();
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                orderNumber = null;
                sqlConnection.Close();
                Console.WriteLine(e.ToString());
            }

            return orderNumber;
        }

        /// <summary>
        /// 
        /// Initial Order number.
        /// </summary>
        public void initialOrder()
        {
            try
            {
                SqlCommand theCommand;
                sqlConnection.Open();

                //Supply Order
                theCommand = new SqlCommand("INSERT INTO Supply_Order (Order_Date) VALUES (@Date) ", sqlConnection);
                theCommand.CommandType = System.Data.CommandType.Text;
                theCommand.Parameters.AddWithValue("@Date", DateTime.Now);

                theCommand.Connection = sqlConnection;
                theCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// Get all changes then update to the database
        /// </summary>
        /// <param name="changesList"></param>
        public void updateOrderDatabase(List<OrderItem> changesList)
        {
            initialOrder();

            string orderNumber = this.getLargestOrderNumber();

            foreach (OrderItem item in changesList)
            {
                try
                {
                    SqlCommand theCommand;
                    sqlConnection.Open();

                    //Supply Order
                    theCommand = new SqlCommand("INSERT INTO Order_Include (Order_Number, PLU, Supplier_ID, Quantity) " + 
                                                 "VALUES (@Order_Number, @PLU, @Supplier_ID, @Quantity)");
                    theCommand.CommandType = System.Data.CommandType.Text;
                    theCommand.Parameters.AddWithValue("@Order_Number", orderNumber);
                    theCommand.Parameters.AddWithValue("@PLU", item.Order_PLU);
                    theCommand.Parameters.AddWithValue("@Supplier_ID", item.Order_Supplier_ID);
                    theCommand.Parameters.AddWithValue("@Quantity", item.Order_Quantity);                            
                    
                    theCommand.Connection = sqlConnection;
                    theCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch (Exception e)
                {
                    sqlConnection.Close();
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
