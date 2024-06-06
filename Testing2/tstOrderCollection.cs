using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();
            // add an item to the list
            clsOrder TestItem = new clsOrder();
            // set its properties
            TestItem.OrderId = 1;
            TestItem.StaffID = 20;
            TestItem.Amount = 100.00m;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "visa";
            TestItem.OrderDate = DateTime.Now.Date;
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            // set the properties of the test object
            TestOrder.OrderId = 1;
            TestOrder.StaffID = 20;
            TestOrder.Amount = 100.00m;
            TestOrder.PaymentDate = DateTime.Now.Date;
            TestOrder.PaymentMethod = "visa";
            TestOrder.OrderDate = DateTime.Now.Date;
            // assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();
            // add an item to the list
            clsOrder TestItem = new clsOrder();
            // set its properties
            TestItem.OrderId = 1;
            TestItem.StaffID = 20;
            TestItem.Amount = 100.00m;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "visa";
            TestItem.OrderDate = DateTime.Now.Date;
            // add the item to the test list
            TestList.Add(TestItem);

            // create another item of test data
            TestItem = new clsOrder();
            // set its properties
            TestItem.OrderId = 2;
            TestItem.StaffID = 21;
            TestItem.Amount = 200.00m;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "master card";
            TestItem.OrderDate = DateTime.Now.Date;
            // add the item to the test list
            TestList.Add(TestItem);

            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.StaffID = 20;
            TestItem.Amount = 100.00m;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "visa";
            TestItem.OrderDate = DateTime.Now.Date;
            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.StaffID = 20;
            TestItem.Amount = 100.00m;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "visa";
            TestItem.OrderDate = DateTime.Now.Date;
            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // modify the test record
            TestItem.StaffID = 21;
            TestItem.Amount = 200.00m;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "master card";
            TestItem.OrderDate = DateTime.Now.Date;
            // set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            // update the record
            AllOrders.Update();
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test to see if ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create the item of test data
            clsOrder TestItem = new clsOrder();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set its properties
            TestItem.StaffID = 20;
            TestItem.Amount = 100.00m;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "visa";
            TestItem.OrderDate = DateTime.Now.Date;
            // set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // delete the record
            AllOrders.Delete();
            // now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByPaymentMethodOK()
        {
            // create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply a blank string (should return all records)
            FilteredOrders.ReportByPaymentMethod("");
            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByPaymentMethodNoneFound()
        {
            // create an instance of the class we want to create
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply a payment method that doesn't exist
            FilteredOrders.ReportByPaymentMethod("NonExistentMethod");
            // test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByPaymentMethodTestDataFound()
        {
            // Create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // Variable to store the outcome
            Boolean OK = true;
            // Apply a payment method that doesn't exist
            FilteredOrders.ReportByPaymentMethod("visa");
            // Check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                // Check to see that the first record is 8
                if (FilteredOrders.OrderList[0].OrderId != 8)
                {
                    OK = false;
                }
                // Check to see that the second record is 125
                if (FilteredOrders.OrderList[1].OrderId != 125)
                {
                    OK = false;
                }
            }
            else
            {
                OK = true;
            }
            // Test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
