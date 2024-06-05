using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
       
        string StaffID = "1";
        string Amount = "20.10";
        string PaymentMethod = "visa";
        string OrderDate = DateTime.Now.ToShortDateString(); 
        string PaymentDate = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOk()
        {
            //create the instance 
            clsOrder AnOrder = new clsOrder();
            // test the existence 
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffID, TestData);
        }

        [TestMethod]
        public void AmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            decimal TestData = 100.00M;
            //assign the data to the property
            AnOrder.Amount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Amount, TestData);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.PaymentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentDate, TestData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Master Card";
            //assign the data to the property
            AnOrder.PaymentMethod = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.PaymentMethod, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // Invoke the method
            Error = AnOrder.Valid(this.OrderDate, this.PaymentMethod, this.PaymentDate);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderDate = "this is not a date!";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentMethodRequired()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentMethodValid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "paypal";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string PaymentDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string PaymentDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string PaymentDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string PaymentDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string PaymentDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentDate = "this is not a date!";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate);
            Assert.AreNotEqual("", Error);
        }
    }
}
