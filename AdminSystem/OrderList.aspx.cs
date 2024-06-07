using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "PaymentMethod";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderCollection = new clsOrderCollection();
        OrderCollection.ReportByStaffId("");
        txtFilter.Text = "";
        lstOrderList.DataSource = OrderCollection.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "PaymentMethod";
        lstOrderList.DataBind();
    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderCollection = new clsOrderCollection();
        OrderCollection.ReportByStaffId(txtFilter.Text);
        lstOrderList.DataSource = OrderCollection.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "PaymentMethod";
        lstOrderList.DataBind();
    }
}

public class clsOrderCollection
{
    public List<clsOrder> OrderList { get; set; }

    public clsOrderCollection()
    {
        OrderList = new List<clsOrder>();
    }

    public void ReportByStaffId(string StaffId)
    {
        // implement filtering logic here
    }
}

public class clsOrder
{
    public int OrderId { get; set; }

    private DateTime paymentMethod;

    public DateTime GetPaymentMethod()
    {
        return paymentMethod;
    }

    public void SetPaymentMethod(DateTime value)
    {
        paymentMethod = value;
    }

    public int StaffId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; }
}