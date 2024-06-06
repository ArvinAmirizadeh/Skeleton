using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;


namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsStockCollection AllProducts = new clsStockCollection();
            //test to see if it exists
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            //create instance
            clsStockCollection AllProducts = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //Add an item to the list
            //create item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductId = 1;
            TestItem.ProductName = "TestProduct";
            TestItem.Price = 1000;
            TestItem.Brand = "TestBrand";
            TestItem.Size = "L";
            TestItem.Quantity = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //create an instance 
            clsStockCollection AllProducts = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestProduct = new clsStock();
            //set the properties of the test object
            TestProduct.ProductId = 1;
            TestProduct.ProductName = "TestProduct";
            TestProduct.Price = 1000;
            TestProduct.Brand = "TestBrand";
            TestProduct.Size = "L";
            TestProduct.Quantity = 10;
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStockCollection AllProducts = new clsStockCollection();
            //create test data
            //needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductId = 1;
            TestItem.ProductName = "TestProduct";
            TestItem.Price = 1000;
            TestItem.Brand = "TestBrand";
            TestItem.Size = "L";
            TestItem.Quantity = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance
            clsStockCollection AllProducts = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductName = "TestProduct";
            TestItem.Price = 1000;
            TestItem.Brand = "TestBrand";
            TestItem.Size = "L";
            TestItem.Quantity = 10;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key to the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance
            clsStockCollection AllProducts = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductName = "TestProduct";
            TestItem.Price = 1000;
            TestItem.Brand = "TestBrand";
            TestItem.Size = "L";
            TestItem.Quantity = 10;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //modify the test record
            TestItem.ProductName = "NewProduct";
            TestItem.Quantity = 5;
            TestItem.Price = 500;
            //set the record based on the new test data
            AllProducts.ThisProduct = TestItem;
            //update the record
            AllProducts.Update();
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see if ThisProduct matches the test data
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance
            clsStockCollection AllProducts = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductName = "TestProduct";
            TestItem.Price = 1000;
            TestItem.Brand = "TestBrand";
            TestItem.Size = "L";
            TestItem.Quantity = 10;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //delete the record
            AllProducts.Delete();
            //now find the record
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            //create instance
            clsStockCollection AllProducts = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredProducts = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredProducts.ReportByProductName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //create instance
            clsStockCollection FilteredProducts = new clsStockCollection();
            //apply a product name that doesn't exist
            FilteredProducts.ReportByProductName("NonExistentProduct");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            //create instance of filtered data
            clsStockCollection FilteredProducts = new clsStockCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a product name that exists
            FilteredProducts.ReportByProductName("TestProduct");
            //check that the correct number of records are found
            if (FilteredProducts.Count == 2)
            {
                //check to see that the first record is 1
                if (FilteredProducts.ProductList[0].ProductId != 1)
                {
                    OK = false;
                }
                //check to see that the second record is 2
                if (FilteredProducts.ProductList[1].ProductId != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that the records were found correctly
            Assert.IsTrue(OK);
        }
    }
}