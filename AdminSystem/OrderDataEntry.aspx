<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
               body {
            font-family: Arial, sans-serif;
            background-color: #000000; /* Changed to black */
            color: #ffffff;
            margin: 0;
            padding: 20px;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        form {
            background-color: #34495e;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            width: 305px;
            height: 573px;
        }
        .form-group {
            margin-bottom: 15px;
            text-align: center;
        }
        label {
            display: block;
            margin-bottom: 5px;
        }
        input[type="text"], input[type="number"], input[type="email"], input[type="date"], .form-control {
            width: 100%;
            padding: 8px;
            border: none;
            border-radius: 4px;
            box-sizing: border-box;
        }
        .button-group {
            display: flex;
            justify-content: space-between;
        }
        input[type="submit"], input[type="button"], button {
            background-color: #e74c3c; /* Changed to red */
            color: white;
            border: none;
            padding: 10px;
            text-transform: uppercase;
            border-radius: 4px;
            cursor: pointer;
            width: 48%;
            box-shadow: 0 2px 4px rgba(0,0,0,0.2);
            transition: background 0.3s ease;
        }
        input[type="submit"]:hover, input[type="button"]:hover, button:hover {
            background-color: #c0392b; /* Darker shade of red on hover */
        }
        
        .error-label {
            color: red;
            font-weight: bold;
            margin-top: 15px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="idk">
            <div>
                <asp:Label ID="lblOrderID" runat="server" Text="Order ID" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtOrderID" runat="server" CssClass="form-input" MaxLength="4" TextMode="Number"></asp:TextBox>
                <asp:Button ID="BtnFind" runat="server"  Text="Find" CssClass="form-button" />
            </div>
            <div>
     <asp:Label ID="Label1" runat="server" Text="Staff ID" CssClass="form-label"></asp:Label>
     <asp:TextBox ID="TextBox1" runat="server" CssClass="form-input" MaxLength="4" TextMode="Number"></asp:TextBox>
     <asp:Button ID="Button2" runat="server"  Text="Find" CssClass="form-button" />
 </div>
            <div>
    <asp:Label ID="Labelamont" runat="server" Text="Amount Of Order" CssClass="form-label"></asp:Label>
    <asp:TextBox ID="TextAmount" runat="server" CssClass="form-input"></asp:TextBox>
</div>
            <div>
                <asp:Label ID="lblOrderDate" runat="server" Text="Date Of Order" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtOrderDate" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblPaymentDate" runat="server" Text="Date Of Payment" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtPaymentDate" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            
               <div class="form-group">
            <label for="ddlPaymentMethod">Payment Method</label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Height="16px" Width="230px">
                <asp:ListItem Text="Visa" Value="visa"></asp:ListItem>
                <asp:ListItem Text="Master Card" Value="master card"></asp:ListItem>
                <asp:ListItem Text="Paypal" Value="paypal"></asp:ListItem>
            </asp:DropDownList>
       
            </div>
            <div>
                <asp:Label ID="lblError" runat="server" CssClass="form-label"></asp:Label>
            </div>
            <div>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="form-button"  />
                <asp:Button ID="btnOk" runat="server" Text="Ok" CssClass="form-button" />
            </div>
             
        </div>
    </form>
</body>
</html>
