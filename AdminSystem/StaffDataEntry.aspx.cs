using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // variable to store the primary key with page level scope
    int StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the staff to be processed
        StaffID = Convert.ToInt32(Session["StaffId"]);
        if (!IsPostBack)
        {
            // if this is not a new record
            if (StaffID != -1)
            {
                // display the current data for the record
                DisplayStaff();
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        // variable to store any error messages
        string Error = "";
        // capture the staff ID
        int StaffID = Convert.ToInt32(Session["StaffId"]);
        // capture the staff name
        string StaffName = txtStaffName.Text;
        // capture the staff email
        string StaffEmail = txtStaffEmail.Text;
        // capture the staff role
        string StaffRole = txtStaffRole.Text;
        // capture the staff phone number
        string PhoneNumber = txtPhoneNumber.Text;
        // validate the data
        Error = AStaff.Valid(StaffName, StaffEmail, StaffRole, PhoneNumber);
        if (Error == "")
        {
            // capture the staff ID
            AStaff.StaffId = StaffID; // DON'T MISS THIS BIT !!!!!!
                                      // capture the staff name
            AStaff.Name = StaffName;
            // capture the staff email
            AStaff.StaffEmail = StaffEmail;
            // capture the staff role
            AStaff.Role = StaffRole;
            // capture the date hired
            AStaff.PhoneNumber = PhoneNumber;
            // create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            // if this is a new record, add the data
            if (StaffID == -1)
            {
                // set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                // add the new record
                StaffList.Add();
            }
            else
            {
                // find the record to update
                StaffList.ThisStaff.Find(StaffID);
                // set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                // update the record
                StaffList.Update();
            }

            // redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff class
        clsStaff staff = new clsStaff();

        // Create a variable to store the primary key
        int StaffId;

        // Create a variable to store the result of the find operation
        Boolean Found = false;

        // Get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffID.Text); // Ensure conversion is safe

        // Find the record
        Found = staff.Find(StaffId);

        // If found
        if (Found)
        {
            // Display the values of the properties in the form
            txtStaffName.Text = staff.Name;
            txtStaffEmail.Text = staff.StaffEmail;
            txtStaffRole.Text = staff.Role;
            txtPhoneNumber.Text = staff.PhoneNumber;
        }
        else
        {

            // Optionally, clear the fields or display a message if not found
            txtStaffName.Text = "";
            txtStaffEmail.Text = "";
            txtStaffRole.Text = "";
            txtPhoneNumber.Text = "";
            // Display a not found message or log as needed
            lblError.Text = "Staff not found.";


        }
    }
    void DisplayStaff()
    {
        // create an instance of the staff collection
        clsStaffCollection StaffCollection = new clsStaffCollection();
        // find the record to update
        StaffCollection.ThisStaff.Find(StaffID);
        // display the data for this record
        txtStaffID.Text = StaffCollection.ThisStaff.StaffId.ToString();
        txtStaffName.Text = StaffCollection.ThisStaff.Name;
        txtStaffEmail.Text = StaffCollection.ThisStaff.StaffEmail;
        txtStaffRole.Text = StaffCollection.ThisStaff.Role;
        txtPhoneNumber.Text = StaffCollection.ThisStaff.PhoneNumber;
       
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // redirect back to the Main Menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}