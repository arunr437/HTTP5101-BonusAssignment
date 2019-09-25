using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01358379_Assign
{
    public partial class goKart_review : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

                Page.Validate();
                if (Page.IsValid)
                {
                    string Customer_first_name = customer_first_name.Text.ToString();
                    string Customer_last_name = customer_last_name.Text.ToString();
                    string Customer_contact_number = customer_contact_number.Text.ToString();
                    int Customer_age = Convert.ToInt32(customer_age.Text);
                    string Gokart_branch = gokart_branch.Text.ToString();
                    string Customer_rating_quality = customer_rating_quality.Text.ToString();
                    string Customer_rating_recommendation = customer_rating_recommendation.Text.ToString();
                    string Customer_service_type = customer_service_type.Text.ToString();
                    string Customer_overall_rating = "0";




                    if (Customer_rating_quality.Equals("3") && Customer_rating_recommendation.Equals("3"))
                    {
                        Customer_overall_rating = "5";
                    }
                    else if ((Customer_rating_quality.Equals("3") && Customer_rating_recommendation.Equals("2")) || Customer_rating_quality.Equals("2") && Customer_rating_recommendation.Equals("3"))
                    {
                        Customer_overall_rating = "4";
                    }
                    else if (Customer_rating_quality.Equals("2") && Customer_rating_recommendation.Equals("2"))
                    {
                        Customer_overall_rating = "3";
                    }
                    else if ((Customer_rating_quality.Equals("2") && Customer_rating_recommendation.Equals("1")) || Customer_rating_quality.Equals("1") && Customer_rating_recommendation.Equals("2"))
                    {
                        Customer_overall_rating = "2";
                    }
                    else
                    {
                        Customer_overall_rating = "1";
                    }

                    confirmbox.InnerHtml += "<h3>Customer Information(Sent from server side!) : </h3><hr>";
                    confirmbox.InnerHtml += " First Name: " + Customer_first_name + "<br>";
                    confirmbox.InnerHtml += " Last Name: " + Customer_last_name + "<br>";
                    confirmbox.InnerHtml += " Contact Number: " + Customer_contact_number + "<br>";
                    confirmbox.InnerHtml += " Age: " + Customer_age + "<br>";
                    confirmbox.InnerHtml += " Branch that you visited: " + Gokart_branch + "<br>";
                    confirmbox.InnerHtml += " The type of service that you chose: " + Customer_service_type + "<br>";
                    confirmbox.InnerHtml += " <h3>The overall average rating: " + Customer_overall_rating + "<h3><br>";
                }
            }

        }
    }
}