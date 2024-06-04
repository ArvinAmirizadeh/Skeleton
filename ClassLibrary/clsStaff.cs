using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaffId;
        private string mName;
        private string mRole;
        private string mPhoneNumber;
        private string mEmail;
        private Boolean mActiveStatus;

        // Public properties
        public int StaffId
        {
            get { return mStaffId; }
            set { mStaffId = value; }
        }
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public string Role
        {
            get { return mRole; }
            set { mRole = value; }
        }
        public string PhoneNumber
        {
            get { return mPhoneNumber; }
            set { mPhoneNumber = value; }
        }
        public string StaffEmail
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public bool ActiveStatus
        {
            get
            {
                return mActiveStatus;
            }
            set
            {
                mActiveStatus = value;
            }
        }


        // Find method
        public bool Find(int StaffId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the search query
            DB.AddParameter("@StaffId", StaffId);

            // Execute the stored procedure
            DB.Execute("sproc_TableStaff_FilterByStaffId");

            // Check if one record is found
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mRole = Convert.ToString(DB.DataTable.Rows[0]["Role"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                // Return that everything worked OK
                return true;
            }
            else
            {
                // Return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string name, string email, string role, string phoneNumber)
        {
            string error = "";

            // Name validation
            if (string.IsNullOrEmpty(name))
            {
                error += "Name cannot be empty. ";
            }
            if (name.Length > 255)
            {
                error += "Name must be less than 255 characters. ";
            }

            // Email validation
            if (string.IsNullOrEmpty(email))
            {
                error += "Email cannot be empty. ";
            }
            if (email.Length > 255)
            {
                error += "Email must be less than 255 characters. ";
            }

            // Role validation
            if (string.IsNullOrEmpty(role))
            {
                error += "Role cannot be empty. ";
            }
            if (role.Length > 255)
            {
                error += "Role must be less than 255 characters. ";
            }

            // PhoneNumber validation
            if (string.IsNullOrEmpty(phoneNumber))
            {
                error += "Phone number cannot be empty. ";
            }
            if (phoneNumber.Length < 6)
            {
                error += "Phone number must be less than 15 characters. ";
            }
            if (phoneNumber.Length > 15)
            {
                error += "Phone number must be less than 15 characters. ";
            }
            return error;
        }

    }
}
