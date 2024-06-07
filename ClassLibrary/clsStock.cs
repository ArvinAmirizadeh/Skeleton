using System;

namespace ClassLibrary
{

        public class clsStock
        {
            //private data member for the product id property
            private Int32 mProductId;
            //product id public property
            public int ProductId
            {
                get
                {
                    //sends data out of the property
                    return mProductId;
                }
                set
                {
                    //allows data into the property
                    mProductId = value;
                }
            }

            //private data member for the product name property
            private String mProductName;
            //product name public property
            public string ProductName
            {
                get
                {
                    //sends data out of the property
                    return mProductName;
                }
                set
                {
                    //allows data into the property
                    mProductName = value;
                }
            }

            //private data member for the price property
            private decimal mPrice;
            //price public property
            public decimal Price
            {
                get
                {
                    //sends data out of the property
                    return mPrice;
                }
                set
                {
                    //allows data into the property
                    mPrice = value;
                }
            }

            //private data member for the brand property
            private String mBrand;
            //brand public property
            public string Brand
            {
                get
                {
                    //sends data out of the property
                    return mBrand;
                }
                set
                {
                    //allows data into the property
                    mBrand = value;
                }
            }

            //private data member for the size property
            private String mSize;
            //size public property
            public string Size
            {
                get
                {
                    //sends data out of the property
                    return mSize;
                }
                set
                {
                    //allows data into the property
                    mSize = value;
                }
            }

            //private data member for the quantity property
            private Int32 mQuantity;
            //quantity public property
            public int Quantity
            {
                get
                {
                    //sends data out of the property
                    return mQuantity;
                }
                set
                {
                    //allows data into the property
                    mQuantity = value;
                }
            }

            public bool Find(int productId)
            {
                //create an instance of the data connection
                clsDataConnection DB = new clsDataConnection();
                //add the parameter for the product id to search for
                DB.AddParameter("@ProductId", productId);
                //execute stored procedure
                DB.Execute("sproc_StockTable_FilterByProductId");

                //if one record is found (Either one or zero)
                if (DB.Count == 1)
                {
                    //copy data from the database to the private data members
                    mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                    mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                    mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                    mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                    mSize = Convert.ToString(DB.DataTable.Rows[0]["Size"]);
                    mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);

                    //return that everything is OK
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public string Valid(string productName, string price, string brand, string size, string quantity)
            {
                //create a string variable to store the error
                String Error = "";

                //create temporary variable to store the int values
                int QuantityTemp;

                //create temporary variable to store decimal values
                decimal PriceTemp;

                //if the ProductName is blank
                if (productName.Length == 0) //test the productName param in method, not the public property ProductName
                {
                    //record the error
                    Error = Error + "The product name may not be blank : ";
                }

                //if the product name is greater than 50 chars
                if (productName.Length > 50)
                {
                    //record the error
                    Error = Error + "The product name must be less than 50 characters : ";
                }

                if (brand.Length == 0)
                {
                    //record the error
                    Error = Error + "The brand may not be blank : ";
                }

                if (brand.Length > 30)
                {
                    //record the error
                    Error = Error + "The brand must be less than 30 characters : ";
                }

            if (int.Parse(size) > 1000)
            {
                Error += "The size cannot be more than 1000.";
            }

            // Other validation logic...

            return Error;

                if ( Convert.ToInt32(quantity) ==0 || quantity.ToString().Length == 0 )
                {
                    Error = Error + "Quantity cannot be left blank or 0 : ";
                }
                else
                {
                    try
                    {
                        QuantityTemp = Convert.ToInt32(quantity);

                        if (QuantityTemp < 0)
                        {
                            Error = Error + "The quantity cannot be less than 0 : ";
                        }

                        if (QuantityTemp > 1000)
                        {
                            Error = Error + "The quantity cannot be greater than 1000 : ";
                        }
                    }
                    catch
                    {
                        Error = Error + "The quantity was not valid : ";
                    }
                }

                if (price == null || price == "")
                {
                    Error = Error + "Price cannot be left blank : ";
                }
                else
                {
                    try
                    {
                        PriceTemp = Convert.ToDecimal(price);

                        if (PriceTemp < 0.01m)
                        {
                            Error = Error + "Price cannot be less than 0.01 : ";
                        }

                        if (PriceTemp > 10000.00m)
                        {
                            Error = Error + "Price cannot be greater than 10,000 : ";
                        }
                    }
                    catch
                    {
                        Error = Error + "The price was not valid : ";
                    }
                }

                //return any error messages
                return Error;
            }

        
    }
    }
