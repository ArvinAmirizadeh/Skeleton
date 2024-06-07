<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    %@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #000000; 
            color: #ffffff;
            margin: 0;
            padding: 20px;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        form {
            background-color: #000000;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            width: 453px;
        }
        .form-group {
            margin-bottom: 15px;
            text-align: center;
        }
        label {
            display: block;
            margin-bottom: 5px;
            color: #ffffff; /* Changed text color to white */
        }
        input[type="text"], input[type="number"], input[type="email"], input[type="date"], .form-control {
            width: 100%;
            padding: 8px;
            border: none;
            border-radius: 4px;
            box-sizing: border-box;
            background-color: #34495e; /* Changed background color to match previous design */
            color: #ffffff; /* Changed text color to white */
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
            margin: 5px 1%;
        }
        input[type="submit"]:hover, input[type="button"]:hover, button:hover {
            background-color: #c0392b; /* Darker shade of red on hover */
        }
        .checkbox {
            margin: 5px 0 15px 0;
            position: relative;
            line-height: 1;
            text-align: center;
        }
        .checkbox input[type="checkbox"] {
            margin-right: 5px;
        }
        .error-label {
            color: red;
            font-weight: bold;
            margin-top: 15px;
            text-align: center;
        }
    </style>
</head>
<body style="height: 752px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStockList" runat="server" Height="294px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged" Width="389px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-bottom: 0px" Text="Add" height="41px" width="98px" />
            <asp:Button ID="btnEdit" runat="server" height="38px" OnClick="btnEdit_Click" style="margin-left: 36px" Text="Edit" width="98px" />
            <asp:Button ID="btnDelete" runat="server" height="38px" OnClick="btnDelete_Click" style="margin-left: 36px" Text="Delete" width="98px" />
        </p>
        <p style="width: 326px">
            <asp:Label ID="lblEnterFilter" runat="server" Text="Enter a Item Name"></asp:Label>
            <asp:TextBox ID="txtItemNameFilter" runat="server" style="margin-left: 53px; margin-top: 0px" Width="311px"></asp:TextBox>
            <asp:Button ID="btnReturnToMenu" runat="server" style="z-index: 1; left: 288px; top: 523px; position: absolute; height: 46px; width: 201px; right: 1015px;" Text="Return to Main Menu" OnClick="btnReturnToMenu_Click" />
        </p>
        <asp:Button ID="btnFilterApply" runat="server" OnClick="btnFilterApply_Click" Text="Apply Filter" />
        <asp:Button ID="btnFilterClear" runat="server" OnClick="btnFilterClear_Click" style="margin-left: 69px" Text="Clear Filter" />
        <p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

