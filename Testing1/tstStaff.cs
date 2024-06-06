using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStaff
{
    [TestClass]
    public class tstStaff
    {

        // Create good test data
        string StaffId = "100";
        string Name = "Lena greenwood";
        string StaffEmail = "lenaGRw@example.com";
        string Role = "Shopkeeper";
        string PhoneNumber = "0796899669";
        

        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // create some test data to assign to the property
            string TestData = "Lena Greenwood";
            // assign the data to the property
            AStaff.Name = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }

        [TestMethod]
        public void StaffStaffEmailPropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            string TestData = "LenaGRw@example.com";
            AStaff.StaffEmail = TestData;
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            string TestData = "Shopkeeper";
            AStaff.Role = TestData;
            Assert.AreEqual(AStaff.Role, TestData);
        }

        [TestMethod]
        public void StaffPhonePropertyOK()
        {
            // similar setup as StaffNamePropertyOK
            clsStaff AStaff = new clsStaff();
            string TestData = "0796899668";
            AStaff.PhoneNumber = TestData;
            Assert.AreEqual(AStaff.PhoneNumber, TestData);
        }
        
        [TestMethod]
        public void ActiveStatusPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = false;
            AStaff.ActiveStatus = TestData;
            Assert.AreEqual(AStaff.ActiveStatus, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 17;  // Changed from 21 to 8
            Found = aStaff.Find(StaffId);
            Assert.IsTrue(Found, "Error: The staff member could not be found.");
        }

        [TestMethod]
        public void TestStaffIdIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 17;  // Changed from 21 to 8
            Found = aStaff.Find(StaffId);
            if (aStaff.StaffId != 17) { OK = false; }  // Changed from 21 to 8
            Assert.IsTrue(OK, "Staff ID not found correctly.");
        }

        [TestMethod]
        public void TestNameIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(17);  // Changed from 21 to 8
            if (aStaff.Name != "Lena Greenwood") { OK = false; }
            Assert.IsTrue(OK, "Name not found correctly.");
        }

        [TestMethod]
        public void TestRoleIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(17);  // Changed from 21 to 8
            if (aStaff.Role != "Shopkeeper") { OK = false; }
            Assert.IsTrue(OK, "Role not found correctly.");
        }

        [TestMethod]
        public void TestPhoneIsFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Found = aStaff.Find(17);  // Changed from 21 to 8
            if (aStaff.PhoneNumber != "0796899668") { OK = false; }
            Assert.IsTrue(OK, "Phone number not found correctly.");
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();
            // String variable to store any error message
            string Error = "";
            // Invoke the method
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual("", Error, "Validation failed when it should have passed.");
        }

        // Name validation tests
        [TestMethod]
        public void NameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void NameMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = "a";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = "aa";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = new string('a', 254);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void NameMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = new string('a', 255);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = new string('a', 256);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Name = new string('a', 500);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        // StaffEmail validation tests
        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffEmailMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "a";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffEmail = "aa";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffEmail = new string('a', 254);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffEmail = new string('a', 255);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffEmail = new string('a', 256);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string StaffEmail = new string('a', 500);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        // Role validation tests
        [TestMethod]
        public void RoleMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = "";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void RoleMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = "a";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = "aa";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = new string('a', 254);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = new string('a', 255);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void RoleMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = new string('a', 256);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void RoleExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string Role = new string('a', 500);
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        // PhoneNumber validation tests
        [TestMethod]
        public void PhoneNumberExtremeMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string PhoneNumber = "";
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string PhoneNumber = "12345"; // Assuming min length is 6
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string PhoneNumber = "123456"; // Assuming min length is 6
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string PhoneNumber = "1234567"; // Assuming min length is 6
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string PhoneNumber = new string('1', 21); // Assuming max length is 20
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string PhoneNumber = new string('1', 14); // Assuming max length is 20
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            string Error = "";
            string PhoneNumber = new string('1', 13); // Assuming max length is 20
            Error = aStaff.Valid(Name, StaffEmail, Role, PhoneNumber);
            Assert.AreEqual("", Error);
        }

    }
}
