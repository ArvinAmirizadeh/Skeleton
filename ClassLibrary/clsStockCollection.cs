using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //constructor for the class
        public clsStockCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_StockTable_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //private data member for the list
        List<clsStock> mProductList = new List<clsStock>();
        //private data member for thisProduct
        clsStock mThisProduct = new clsStock();

        public List<clsStock> ProductList
        {
            get
            {
                //return private data member
                return mProductList;
            }
            set
            {
                //set the private data
                mProductList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mProductList.Count;
            }
            set
            {
                //to be done later
            }
        }

        //public property for ThisProduct
        public clsStock ThisProduct
        {
            get
            {
                //return private data member
                return mThisProduct;
            }
            set
            {
                //set the private data
                mThisProduct = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisProduct
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Brand", mThisProduct.Brand);
            DB.AddParameter("@Size", mThisProduct.Size);
            DB.AddParameter("@Quantity", mThisProduct.Quantity);
            //execute the query returning the primary key value
            return DB.Execute("sproc_StockTable_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of ThisProduct
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored proc
            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Brand", mThisProduct.Brand);
            DB.AddParameter("@Size", mThisProduct.Size);
            DB.AddParameter("@Quantity", mThisProduct.Quantity);
            //execute the stored procedure
            DB.Execute("sproc_StockTable_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisProduct
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            //execute sproc
            DB.Execute("sproc_StockTable_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            //filters the records based on a full or partial ProductName
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //send the product name param to db
            DB.AddParameter("@ProductName", ProductName);
            //execute the sproc
            DB.Execute("sproc_TableStock_FilterByProductName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter db
            //variable for index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mProductList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank product object 
                clsStock ProductItem = new clsStock();
                //read in the fields from the current record
                ProductItem.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                ProductItem.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                ProductItem.Price = (decimal)Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                ProductItem.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                ProductItem.Size = Convert.ToString(DB.DataTable.Rows[Index]["Size"]);
                ProductItem.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //add the record to the private data member list
                mProductList.Add(ProductItem);
                //next record
                Index++;
            }
        }
    }
}