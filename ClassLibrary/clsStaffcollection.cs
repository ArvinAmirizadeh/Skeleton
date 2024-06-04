using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        // private member data for ThisStaff
        clsStaff mThisStaff = new clsStaff();

        // Public property to hold a list of staff
        public List<clsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }

        // Public property to hold the count of staff items
        public int Count
        {
            get { return mStaffList.Count; }
            set { /* We can ignore setting the count, as it is managed by the list itself */ }
        }

        // Public property to hold a single staff object
        public clsStaff ThisStaff
        {
            get
            {
                // return the private data
                return mThisStaff;
            }
            set
            {
                // set the private data
                mThisStaff = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff object
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AStaff.Role = Convert.ToString(DB.DataTable.Rows[Index]["Role"]);
                AStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

        public clsStaffCollection()
        {
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_TableStaff_SelectAll");
            //populate the array list with data table
            PopulateArray(DB);
        }

        public int Add()
        {
            // adds a record to the database based on the values of mThisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.StaffEmail);
            DB.AddParameter("@Role", mThisStaff.Role);
            DB.AddParameter("@Phone", mThisStaff.PhoneNumber);
            DB.AddParameter("@ActiveStatus", mThisStaff.ActiveStatus);
            // execute the query returning the primary key value
            return DB.Execute("sproc_TableStaff_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of ThisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@StaffID", ThisStaff.StaffId);
            DB.AddParameter("@Name", ThisStaff.Name);
            DB.AddParameter("@Email", ThisStaff.StaffEmail);
            DB.AddParameter("@Role", ThisStaff.Role);
            DB.AddParameter("@Phone", ThisStaff.PhoneNumber);
            DB.AddParameter("@ActiveStatus", ThisStaff.ActiveStatus);
            // execute the stored procedure
            DB.Execute("sproc_TableStaff_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by thisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            // execute the stored procedure
            DB.Execute("sproc_TableStaff_Delete");
        }

        public void ReportByRole(string Name)
        {
            //filters the records based on a full or partial role
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Role parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_TableStaff_FilterByName");
            PopulateArray(DB);
        }
    }
}

