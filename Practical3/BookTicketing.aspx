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
            <td><asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar><asp:TextBox ID="dateTextbox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Adult:</td>
            <td><asp:TextBox ID="qtyOfAdultTxt" runat="server"></asp:TextBox></td>

        </tr>
        <tr>
            <td>Child:</td>
            <td><asp:TextBox ID="qtyOfChildTxt" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>From :</td>
            <td><asp:DropDownList ID="fromDropDown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="fromDropDown_SelectedIndexChanged">
                <asp:ListItem>Hentian Duta</asp:ListItem>
                <asp:ListItem>Hentian Putra</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Destination:</td>
            <td><asp:DropDownList ID="destinationDropDown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="destinationDropDown_SelectedIndexChanged">
                <asp:ListItem>Seremban</asp:ListItem>
                <asp:ListItem>Butterworth</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Ticket Price:</td>
            <td><asp:TextBox ID="ticketPriceTextbox" runat="server" Enabled="False"></asp:TextBox></td>
        </tr>
    </table>
    
</div>       
        <asp:Label ID="errorLabel" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="bookTicketBtn" runat="server" Text="Book Ticket" OnClick="bookTicketBtn_Click" 
                OnClientCLick="javascript:alert('You are now will be directed to the booking confirmation page')" PostBackUrl="~/ConfirmBooking.aspx"/>
            &nbsp;
            <asp:Button ID="cancelBtn" runat="server" Text="Cancel" OnMouseOver="this.value='Click if you confirm to reset selection'"
                OnMouseOut="this.value='Cancel'"/>
        </p>
    </form>
</body>
</html>
