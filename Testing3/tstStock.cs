using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        string Quantity = "5";

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
            int TestData = 5;
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
            if (AStock.Quantity != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
