using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderId;
        public int OrderId
        {
            get { return mOrderId; }
            set { mOrderId = value; }
        }

        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }

        private Int32 mStaffID;
        public int StaffID
        {
            get { return mStaffID; }
            set { mStaffID = value; }
        }

        private decimal mAmount;
        public decimal Amount
        {
            get { return mAmount; }
            set { mAmount = value; }
        }

        private DateTime mPaymentDate;
        public DateTime PaymentDate
        {
            get { return mPaymentDate; }
            set { mPaymentDate = value; }
        }

        private string mPaymentMethod;
        public string PaymentMethod
        {
            get { return mPaymentMethod; }
            set { mPaymentMethod = value; }
        }

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order ID to search for
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");

            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string orderDate, string paymentMethod, string paymentDate, decimal amount, int staffId)
        {
            string error = "";

            // OrderDate validation
            DateTime dateTemp;
            if (string.IsNullOrEmpty(orderDate))
            {
                error += "Order date cannot be empty. ";
            }
            else if (!DateTime.TryParse(orderDate, out dateTemp))
            {
                error += "Order date is not a valid date. ";
            }
            else if (dateTemp < DateTime.Now.Date.AddYears(-100) || dateTemp > DateTime.Now.Date)
            {
                error += "Order date must be within the last 100 years and not in the future. ";
            }

            // PaymentMethod validation
            if (string.IsNullOrEmpty(paymentMethod))
            {
                error += "Payment method cannot be empty. ";
            }
            else if (paymentMethod.Length > 50)
            {
                error += "Payment method must be less than 50 characters. ";
            }

            // PaymentDate validation
            if (string.IsNullOrEmpty(paymentDate))
            {
                error += "Payment date cannot be empty. ";
            }
            else if (!DateTime.TryParse(paymentDate, out dateTemp))
            {
                error += "Payment date is not a valid date. ";
            }
            else if (dateTemp < DateTime.Now.Date.AddYears(-100) || dateTemp > DateTime.Now.Date)
            {
                error += "Payment date must be within the last 100 years and not in the future. ";
            }

            // Amount validation
            if (amount < 0)
            {
                error += "Amount cannot be negative. ";
            }
            else if (amount > 1000000)
            {
                error += "Amount must be less than or equal to 1,000,000. ";
            }

            // StaffId validation
            if (staffId < 0)
            {
                error += "Staff ID cannot be negative. ";
            }

            return error;
        }


        public string Valid(string orderDate, string paymentMethod, string paymentDate, string amount, string staffID)
        {
            return "";
        }

        public string Valid(string orderDate, string paymentMethod, string paymentDate, decimal amount, string staffID)
        {
            return "";
        }

        public string Valid(string orderDate, string paymentMethod, string paymentDate, string amount, int staffID)
        {
            return "";
        }
    }
}