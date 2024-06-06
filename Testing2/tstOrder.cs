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
        public void StaffIDPropertyOK()
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
        public void FindMethodOK()
        {
            // create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // create a boolean variable to store the results of the validation
            Boolean Found = false;
            // create some test data to use with the method
            Int32 OrderId = 4;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            // create an instance of the class
            clsOrder AnOrder = new clsOrder();
            // create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            // create test data
            Int32 OrderId = 1;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the OrderId
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            // create an instance of the class
            clsOrder AnOrder = new clsOrder();
            // create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            // create test data
            Int32 OrderId = 1;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the OrderDate property
            if (AnOrder.OrderDate != Convert.ToDateTime("12/05/2024"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            // create an instance of the class
            clsOrder AnOrder = new clsOrder();
            // create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            // create test data
            Int32 OrderId = 4;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the StaffId property
            if (AnOrder.StaffID != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountFound()
        {
            // create an instance of the class
            clsOrder AnOrder = new clsOrder();
            // create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            // create test data
            Int32 OrderId = 4;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the Amount property
            if (AnOrder.Amount != 979)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentDateFound()
        {
            // create an instance of the class
            clsOrder AnOrder = new clsOrder();
            // create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            // create test data
            Int32 OrderId = 4;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the PaymentDate property
            if (AnOrder.PaymentDate != Convert.ToDateTime("12/10/2024"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentMethodFound()
        {
            // create an instance of the class
            clsOrder AnOrder = new clsOrder();
            // create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            // create test data
            Int32 OrderId = 4;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // check the PaymentMethod property
            if (AnOrder.PaymentMethod != "Credit Card")
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // String variable to store any error message
            string Error = "";
            // Invoke the method
            Error = AnOrder.Valid(this.OrderDate, this.PaymentMethod, this.PaymentDate, this.Amount, this.StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate,Amount, StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate,Amount, StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate,Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder aOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = aOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string OrderDate = "this is not a date!";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentMethodRequired()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentMethodValid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentMethod = "paypal";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
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
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PaymentDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentDate = "this is not a date!";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void AmountExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            decimal Amount = 0;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void AmountMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            decimal Amount = 0.01m;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void AmountMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            decimal Amount = 1.00m;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void AmountMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            decimal Amount = 1.01m;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void AmountMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            decimal Amount = 999999.99m;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void AmountMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            decimal Amount = 1000000.00m;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void AmountMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            decimal Amount = 1000000.01m;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void AmountExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            decimal Amount = decimal.MaxValue;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void AmountInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Amount = "this is not a valid amount!";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }
        [TestMethod]
        public void StaffIdExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            int StaffID = Int32.MinValue;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            int StaffID = -1;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            int StaffID = 0;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            int StaffID = 1;
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffIdInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string StaffID = "this is not a valid staff ID!";
            Error = AnOrder.Valid(OrderDate, PaymentMethod, PaymentDate, Amount, StaffID);
            Assert.AreNotEqual("", Error);
        }

    }
}
