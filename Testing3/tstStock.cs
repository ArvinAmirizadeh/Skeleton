using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        string ProductId = "1";
        string ProductName = "Air Force1";
        string Price = "110";
        string Brand = "Nike";
        string Size = "10,9,11";
        string Quantity = "10";

        [TestMethod]
        public void InstanceOk()
        {
            //create the instance 
            clsStock AStock = new clsStock();
            // test the existence 
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ProductId, TestData);
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Running Shoes";
            //assign the data to the property
            AStock.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ProductName, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 120.00M;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Nike";
            //assign the data to the property
            AStock.Brand = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Brand, TestData);
        }

        [TestMethod]
        public void SizePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "10";
            //assign the data to the property
            AStock.Size = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Size, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 10;
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductId = 1;
            //invoke the method
            Found = AStock.Find(ProductId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestProductIdFound()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductId = 1;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the ProductId
            if (AStock.ProductId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductId = 1;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the ProductName property
            if (AStock.ProductName != "Air Force1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductId = 1;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the Price property
            if (AStock.Price != 110)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBrandFound()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductId = 1;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the Brand property
            if (AStock.Brand != "Nike")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSizeFound()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductId = 1;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the Size property
            if (AStock.Size != "10,9,11")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create test data
            Int32 ProductId = 1;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the Quantity property
            if (AStock.Quantity != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
 
            [TestMethod]
            public void ValidMethodOK()
            {
                //create an instance of the class 
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data
                string ProductName = "Test Product";
                decimal Price = 100;
                string Brand = "Nike";
                string Size = "10,9,11";
                int Quantity = 10;
                //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see if the result is correct
                Assert.AreEqual(Error, "");
            }

            /******************PARAMETER TESTS (TEST LOG)******************/

            [TestMethod]
            public void ProductNameMinLessOne()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
              
                string ProductName = ""; //this should throw error
                decimal Price = 100;
                string Brand = "Nike";
                string Size = "10,9,11";
                int Quantity = 10;
                //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreNotEqual(Error, ""); //if there is an error the strings won't match
            }

            [TestMethod]
            public void ProductNameMin()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
               
                string ProductName = "a"; //this should pass
                decimal Price = 100;
                string Brand = "Nike";
                string Size = "10,9,11";
                int Quantity = 10;
                //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMinPlusOne()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
               
                string ProductName = "aa"; //this should be ok
                decimal Price = 100;
                string Brand = "Nike";
                string Size = "10,9,11";
                int Quantity = 10;
                //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        [TestMethod]
        public void ProductNameMid()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string StockName = "";
            StockName = StockName.PadRight(35, 'a'); //this should pass
                                                     //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
            public void ProductNameMaxLessOne()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
            
                string ProductName = "";
                ProductName = ProductName.PadRight(49, 'a'); //this should pass
                decimal Price = 100;
                string Brand = "Nike";
                string Size = "10,9,11";
                int Quantity = 10;
                //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMax()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
            
                string ProductName = "";
                ProductName = ProductName.PadRight(100, 'a'); //this should pass
                decimal Price = 100;
                string Brand = "Nike";
                string Size = "10,9,11";
                int Quantity = 10;
                //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameMaxPlusOne()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method

                string ProductName = "";
                ProductName = ProductName.PadRight(101, 'a'); //this should fail
                decimal Price = 100;
                string Brand = "Nike";
                string Size = "10,9,11";
                int Quantity = 10;
                //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void ProductNameExtremeMax()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
               
                string ProductName = "";
                ProductName = ProductName.PadRight(1000, 'a'); //this should fail
                decimal Price = 100;
                string Brand = "Nike";
                string Size = "10,9,11";
                int Quantity = 10;
                //invoke method
                Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }
   
            [TestMethod]
            public void BrandMinLessOne()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
                string Brand = ""; //this should throw error
                                   //invoke method
                Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreNotEqual(Error, ""); //if there is an error the strings won't match
            }

            [TestMethod]
            public void BrandMin()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
                string Brand = "a"; //this should pass
                                    //invoke method
                Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void BrandMinPlusOne()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
                string Brand = "aa"; //this should be ok
                                     //invoke method
                Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }
        [TestMethod]
        public void BrandMid()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            int TestInt;
            //assign an extreme max value
            TestInt = 999;
            //convert to string
            string Quantity = TestInt.ToString();
            //create test data (override the good data) to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(35, 'a'); //this should pass
                                             //invoke method
            Error = StockItem.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
            public void BrandMaxLessOne()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
                string Brand = "";
                Brand = Brand.PadRight(49, 'a'); //this should pass
                                                 //invoke method
                Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void BrandMax()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
                string Brand = "";
                Brand = Brand.PadRight(50, 'a'); //this should pass
                                                 //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void BrandMaxPlusOne()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
                string Brand = "";
                Brand = Brand.PadRight(51, 'a'); //this should fail
                                                 //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
                //test to see that the result is correct
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void BrandExtremeMax()
            {
                //create instance
                clsStock AStock = new clsStock();
                //string variable to store any error message
                String Error = "";
                //create test data (override the good data) to pass to the method
                string Brand = "";
                Brand = Brand.PadRight(500, 'a'); //this should fail
                                                  //invoke method
                Error = AStock.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
          
                Assert.AreNotEqual(Error, "");
            }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            decimal Price = -0.01m; //this should throw error
                                    //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //if there is an error the strings won't match
        }

        [TestMethod]
        public void PriceMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            double Price = 0.00; //this should pass
                                   //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            decimal Price = 0.01m; //this should be ok
                                   //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            decimal Price = 500.00m; //this should pass
                                     //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            decimal Price = 999.99m; //this should pass
                                     //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            decimal Price = 1000.00m; //this should pass
                                      //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            double Price = 1000.01; //this should fail
                                      //invoke method
            Error = StockItem.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            decimal Price = decimal.MaxValue; //this should fail
                                              //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            decimal Price = decimal.MinValue; //this should fail
                                              //invoke method
            Error = StockItem.Valid( ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SizeMinLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string Size = "-1"; //this should throw error
                                //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size.ToString(), Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //if there is an error the strings won't match
        }

        [TestMethod]
        public void SizeMin()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string Size = "1"; //this should pass
                               //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMinPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string Size = "2"; //this should be ok
                               //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxLessOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string Size = "100"; //this should pass
                                 //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string Size = "1000"; //this should pass
                                  //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SizeMaxPlusOne()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string Size = "1001"; //this should fail
                                  //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SizeExtremeMax()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string Size = new string('9', int.MaxValue / 9); //this should fail
                                                             //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create instance
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method

            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = -1; //this should throw error
                               //invoke method
            Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); //if there is an error the strings won't match
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create instance
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method

            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = 0; //this should pass
                              //invoke method
            Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create instance
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method

            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = 1; //this should be ok
                              //invoke method
            Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create instance
            clsStock StockItem = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method
            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = 50; //this should pass
                               //invoke method
            Error = StockItem.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create instance
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method

            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = 99; //this should pass
                               //invoke method
            Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create instance
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method

            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = 100; //this should pass
                                //invoke method
            Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create instance
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method

            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = 101; //this should fail
                                //invoke method
            Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //testto see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create instance
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method

            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = int.MaxValue; //this should fail
                                         //invoke method
            Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMin()
        {
            //create instance
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create test data (override the good data) to pass to the method

            string ProductName = "Product";
            decimal Price = 100;
            string Brand = "Nike";
            string Size = "10,9,11";
            int Quantity = int.MinValue; //this should fail
                                         //invoke method
            Error = AStock.Valid(ProductName, Price.ToString(), Brand, Size, Quantity.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}
   

    
  



