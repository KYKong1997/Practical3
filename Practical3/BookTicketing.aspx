<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTicketing.aspx.cs" Inherits="Practical3.BookTicketing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblTime" runat="server" Text="[lblTime]"></asp:Label>
    
    </div>
<div>
    <table>
        <tr>
            <td>Depature Date:</td>
        </tr>
    </table>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
</div>       
    </form>
</body>
</html>
