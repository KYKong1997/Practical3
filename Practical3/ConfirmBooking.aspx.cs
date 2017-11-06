using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical3
{
    public partial class ConfirmBooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox AdultNo = PreviousPage.FindControl("qtyOfAdultTxt") as TextBox;
                TextBox ChildNo = PreviousPage.FindControl("qtyOfChildTxt") as TextBox;
                TextBox TicketPrice = PreviousPage.FindControl("ticketPriceTextbox") as TextBox;
                TextBox DepartDate = PreviousPage.FindControl("dateTextbox") as TextBox;
                DropDownList TravelFrom = PreviousPage.FindControl("fromDropDown") as DropDownList;
                DropDownList TravelTo = PreviousPage.FindControl("destinationDropDown") as DropDownList;
                lblDetails.Text = "Departure Date : " + DepartDate.Text + "</br>" +
                                 "From : " + TravelFrom.SelectedValue.ToString()+"<br/>" +
                                 "To : " + TravelTo.SelectedValue.ToString() + "<br/>" +
                                 AdultNo.Text + " Adult and " + ChildNo.Text + " Child.</br>" +
                                 "Ticket Price : " + TicketPrice.Text;


            }
        }
    }
}