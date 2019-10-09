using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01358379_Bonus_Assignment
{
    public partial class RaffleBundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //Code to get the number of tickets from the form
                    ticket_summary.InnerHtml = "";
                    int Number_of_tickets = Convert.ToInt32(number_of_tickets.Text);

                    //If and else if statements to check in which bundle the tickets fall under. 
                    if(Number_of_tickets <=50)
                    {
                        double sum = 0;
                        //To print the output in the desired format in Bundles of 1
                        for(int i=1;i<=Number_of_tickets;i++)
                        {
                            ticket_summary.InnerHtml += "<br>You received a bundle of 1! That's " + i + " ticket(s)!";
                            sum += 0.25;
                        }
                        ticket_summary.InnerHtml += "<br><br>Your total ticket(s) is " + Number_of_tickets + " and your cost is $" + sum + "cad!";
                    }
                    else if(Number_of_tickets >50 && Number_of_tickets<=150 ) 
                    {
                        double sum = 0;
                        //To print the output in the desired format in Bundles of 2
                        for (int i=2;i<=Number_of_tickets;i=i+2)
                        {
                            ticket_summary.InnerHtml += "<br>You received a bundle of 2! That's " + i + " ticket(s)!";
                            sum += 0.25*2;//Adds the total cost without considering the leftovers
                        }
                        //To add the leftovers into the total cost and to print the leftover
                        if(Number_of_tickets%2==0)
                        {
                            ticket_summary.InnerHtml += "<br>";//To get a line space for numbers without leftovers
                        }
                        if(Number_of_tickets%2==1)
                        {
                            sum += 0.25;
                            ticket_summary.InnerHtml += "<br>Your leftover is 1 ticket(s). That's " + Number_of_tickets + " ticket(s)!";

                        }
                        ticket_summary.InnerHtml += "<br><br>Your total ticket(s) is " + Number_of_tickets + " and your cost is $" + sum + "cad!";

                    }
                    else if(Number_of_tickets > 150 && Number_of_tickets <= 300)
                    {
                        double sum = 0;
                        //To print the output in the desired format in Bundles of 3
                        for (int i=3;i<=Number_of_tickets;i=i+3)
                        {
                            ticket_summary.InnerHtml += "<br>You received a bundle of 3! That's " + i + " ticket(s)!";
                            sum += 0.25 * 3 ;
                        }
                        //To add the leftovers into the total cost and to print the leftover
                        if (Number_of_tickets % 3 == 0)
                        {
                            ticket_summary.InnerHtml += "<br>";//To get a line space for numbers without leftovers
                        }
                        else if (Number_of_tickets % 3 == 1)
                        {
                            sum += 0.25;
                            ticket_summary.InnerHtml += "<br>Your leftover is 1 ticket(s). That's " + Number_of_tickets + " ticket(s)!";

                        }
                        else if (Number_of_tickets % 3 == 2)
                        {
                            sum += 0.25 * 2;
                            ticket_summary.InnerHtml += "<br>Your leftover is 2 ticket(s). That's " + Number_of_tickets + " ticket(s)!";

                        }
                        ticket_summary.InnerHtml += "<br><br>Your total ticket(s) is " + Number_of_tickets + " and your cost is $" + sum + "cad!";

                    }
                    if (Number_of_tickets >300)
                    {
                        double sum = 0;
                        //To print the output in the desired format in Bundles of 3
                        for (int i=5;i<=Number_of_tickets;i=i+5)
                        {
                            ticket_summary.InnerHtml += "<br>You received a bundle of 5! That's " + i + " ticket(s)!";
                            sum += 0.25 * 5;
                        }
                        //T0 add the leftovers into the total cost and to print the leftover
                        if (Number_of_tickets % 5 ==0 )
                        {
                            ticket_summary.InnerHtml += "<br>";//To get a line space for numbers without leftovers
                        }
                        else  if (Number_of_tickets % 5 == 1)
                        {
                            sum += 0.25;
                            ticket_summary.InnerHtml += "<br>Your leftover is 1 ticket(s). That's " + Number_of_tickets + " ticket(s)!";
                        }
                        else if (Number_of_tickets % 5 == 2)
                        {
                            sum += 0.25 * 2;
                            ticket_summary.InnerHtml += "<br>Your leftover is 2 ticket(s). That's " + Number_of_tickets + " ticket(s)!";

                        }
                        else if (Number_of_tickets % 5 == 3)
                        {
                            sum += 0.25 * 3;
                            ticket_summary.InnerHtml += "<br>Your leftover is 3 ticket(s). That's " + Number_of_tickets + " ticket(s)!";

                        }
                        else if (Number_of_tickets % 5 == 4)
                        {
                            sum += 0.25 * 4;
                            ticket_summary.InnerHtml += "<br>Your leftover is 4 ticket(s). That's " + Number_of_tickets + " ticket(s)!";

                        }
                        ticket_summary.InnerHtml += "<br><br>Your total ticket(s) is " + Number_of_tickets + " and your cost is $" + sum + "cad!";

                    }


                }

            }
        }
    }
}