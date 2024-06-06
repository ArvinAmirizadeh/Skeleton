<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
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
        <div class="form-group">
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server" MaxLength="4" TextMode="Number"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblStaffName" runat="server" Text="Staff Name"></asp:Label>
            <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblStaffEmail" runat="server" Text="Staff Email"></asp:Label>
            <asp:TextBox ID="txtStaffEmail" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role"></asp:Label>
            <asp:TextBox ID="txtStaffRole" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </div>
        <div class="form-group button-group">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        <div class="form-group">
            <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblError" runat="server" CssClass="error-label" />
        </div>
    </form>
</body>
</html>
