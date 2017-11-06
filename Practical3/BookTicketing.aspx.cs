using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical3
{
    public partial class BookTicketing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                lblTime.Text = "You are accessing this page on " + DateTime.Now.ToString();
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dateTextbox.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void fromDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            ticketPriceTextbox.Text= "";
            try
            {
                errorLabel.Text = "";
                ticketPriceTextbox.Text = "";
                int qtyOfChild = 0;
                int qtyOfAdult = 0;

                string destination = destinationDropDown.SelectedValue.ToString();
                string from = fromDropDown.SelectedValue.ToString();
                if (destination.Equals("Seremban") && from.Equals("Hentian Duta"))
                {
                    errorLabel.Text = "Sorry,We do not provide trip from Hentian Duta to Seremban";
                }
                else if (destination.Equals("Butterworth") && from.Equals("Hentian Putra"))
                {
                    errorLabel.Text = "Sorry,We do not provide trip from Hentian Putra to Butterworth";
                }
                else
                {
                    if (destination.Equals("Butterworth") && from.Equals("Hentian Duta"))
                    {
                        qtyOfAdult = Int32.Parse(qtyOfAdultTxt.Text);
                        qtyOfChild = Int32.Parse(qtyOfChildTxt.Text);

                        double total = (qtyOfAdult * 34.00) + (qtyOfChild * 25.50);
                        ticketPriceTextbox.Text = "RM " + total;
                    }
                    else
                    {
                        qtyOfAdult = Int32.Parse(qtyOfAdultTxt.Text);
                        qtyOfChild = Int32.Parse(qtyOfChildTxt.Text);

                        double total = (qtyOfAdult * 6.00) + (qtyOfChild * 4.30);
                        ticketPriceTextbox.Text = "RM " + total;
                    }
                }
            }
            catch
            {
                errorLabel.Text = "";
                ticketPriceTextbox.Text = "";
            }
        }

        protected void destinationDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            ticketPriceTextbox.Text = "";
            int qtyOfChild = 0;
            int qtyOfAdult = 0;

            string destination = destinationDropDown.SelectedValue.ToString();
            string from = fromDropDown.SelectedValue.ToString();
            if (destination.Equals("Seremban") && from.Equals("Hentian Duta"))
            {
                errorLabel.Text = "Sorry,We do not provide trip from Hentian Duta to Seremban";
            }
            else if (destination.Equals("Butterworth") && from.Equals("Hentian Putra"))
            {
                errorLabel.Text = "Sorry,We do not provide trip from Hentian Putra to Butterworth";
            }
            else
            {
                if (destination.Equals("Butterworth") && from.Equals("Hentian Duta"))
                {
                    qtyOfAdult = Int32.Parse(qtyOfAdultTxt.Text);
                    qtyOfChild = Int32.Parse(qtyOfChildTxt.Text);

                    double total = (qtyOfAdult * 34.00) + (qtyOfChild * 25.50);
                    ticketPriceTextbox.Text = "RM " + total;
                }
                else
                {
                    qtyOfAdult = Int32.Parse(qtyOfAdultTxt.Text);
                    qtyOfChild = Int32.Parse(qtyOfChildTxt.Text);

                    double total = (qtyOfAdult * 6.00) + (qtyOfChild * 4.30);
                    ticketPriceTextbox.Text = "RM " + total;
                }
            }

        }

        protected void bookTicketBtn_Click(object sender, EventArgs e)
        {

        }
    }
}