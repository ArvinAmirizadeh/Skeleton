using System.Collections.Generic;
using System;

namespace ClassLibrary
{
  
        public class clsOrderCollection
        {
            // Private data member for the list
            private List<clsOrder> mOrderList = new List<clsOrder>();

            // Private member data for ThisOrder
            private clsOrder mThisOrder = new clsOrder();

            // Public property to hold a list of orders
            public List<clsOrder> OrderList
            {
                get { return mOrderList; }
                set { mOrderList = value; }
            }

            // Public property to hold the count of order items
            public int Count
            {
                get { return mOrderList.Count; }
                // We can ignore setting the count, as it is managed by the list itself
            }

            // Public property to hold a single order object
            public clsOrder ThisOrder
            {
                get { return mThisOrder; }
                set { mThisOrder = value; }
            }

            // Method to populate the array with records from the database
            void PopulateArray(clsDataConnection DB)
            {
                // Variable for the index
                int index = 0;
                // Variable to store the record count
                int recordCount = DB.Count;
                // Clear the private list
                mOrderList = new List<clsOrder>();
                // While there are records to process
                while (index < recordCount)
                {
                    // Create a blank order object
                    clsOrder order = new clsOrder();
                    // Read in the fields from the current record
                    order.OrderId = Convert.ToInt32(DB.DataTable.Rows[index]["OrderId"]);
                    order.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[index]["OrderDate"]);
                    order.StaffID = Convert.ToInt32(DB.DataTable.Rows[index]["StaffId"]);
                    order.Amount = Convert.ToDecimal(DB.DataTable.Rows[index]["Amount"]);
                    order.PaymentDate = Convert.ToDateTime(DB.DataTable.Rows[index]["PaymentDate"]);
                    order.PaymentMethod = Convert.ToString(DB.DataTable.Rows[index]["PaymentMethod"]);
                    // Add the record to the private list
                    mOrderList.Add(order);
                    // Point at the next record
                    index++;
                }
            }

            // Constructor for the class
            public clsOrderCollection()
            {
                // Object for data connection
                clsDataConnection DB = new clsDataConnection();
                // Execute the stored procedure
                DB.Execute("sproc_TableOrder_SelectAll");
                // Populate the array with data table
                PopulateArray(DB);
            }

            // Method to add a new order record
            public int Add()
            {
                // Connect to the database
                clsDataConnection DB = new clsDataConnection();
                // Set the parameters for the stored procedure
                DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
                DB.AddParameter("@StaffID", mThisOrder.StaffID);
                DB.AddParameter("@Amount", mThisOrder.Amount);
                DB.AddParameter("@PaymentDate", mThisOrder.PaymentDate);
                DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
                // Execute the query returning the primary key value
                return DB.Execute("sproc_TableOrder_Insert");
            }

            // Method to update an existing order record
            public void Update()
            {
                // Connect to the database
                clsDataConnection DB = new clsDataConnection();
                // Set the parameters for the stored procedure
                DB.AddParameter("@OrderID", mThisOrder.OrderId);
                DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
                DB.AddParameter("@StaffID", mThisOrder.StaffID);
                DB.AddParameter("@Amount", mThisOrder.Amount);
                DB.AddParameter("@PaymentDate", mThisOrder.PaymentDate);
                DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
                // Execute the stored procedure
                DB.Execute("sproc_TableOrder_Update");
            }

            // Method to delete an existing order record
            public void Delete()
            {
                // Connect to the database
                clsDataConnection DB = new clsDataConnection();
                // Set the parameters for the stored procedure
                DB.AddParameter("@OrderID", mThisOrder.OrderId);
                // Execute the stored procedure
                DB.Execute("sproc_TableOrder_Delete");
            }

            // Method to filter records based on payment method
            public void ReportByPaymentMethod(string paymentMethod)
            {
                // Connect to the database
                clsDataConnection DB = new clsDataConnection();
                // Set the payment method parameter
                DB.AddParameter("@PaymentMethod", paymentMethod);
                // Execute the stored procedure
                DB.Execute("sproc_TableOrder_FilterByPaymentMethod");
                // Populate the array with filtered records
                PopulateArray(DB);
            }
        }
    }

