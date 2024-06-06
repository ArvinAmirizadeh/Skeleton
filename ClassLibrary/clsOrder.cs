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

        public string Valid(string orderDate, string paymentMethod, string paymentDate)
        {
            string error = "";
            DateTime dateTemp;

            // OrderDate validation
            if (!DateTime.TryParse(orderDate, out dateTemp))
            {
                error += "The order date was not a valid date. ";
            }
            else
            {
                if (dateTemp > DateTime.Now.Date)
                {
                    error += "The order date cannot be in the future. ";
                }
                if (dateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    error += "The order date cannot be more than 100 years ago. ";
                }
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
            else if (paymentMethod != "visa" && paymentMethod != "master card" && paymentMethod != "paypal")
            {
                error += "Payment method must be 'visa', 'master card' or 'paypal'. ";
            }

            // PaymentDate validation
            if (!DateTime.TryParse(paymentDate, out dateTemp))
            {
                error += "The payment date was not a valid date. ";
            }
            else
            {
                if (dateTemp > DateTime.Now.Date)
                {
                    error += "The payment date cannot be in the future. ";
                }
                if (dateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    error += "The payment date cannot be more than 100 years ago. ";
                }
            }

            return error;
        }
    }
}