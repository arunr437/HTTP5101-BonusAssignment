using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01358379_Bonus_Assignment
{
    public partial class Coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                 
                    quadrant_summary.InnerHtml = "";

                    //To pull values from the form into the code behind.

                    int X_coordinate_value = Convert.ToInt32(x_coordinate_value.Text);
                    int Y_coordinate_value = Convert.ToInt32(y_coordinate_value.Text);

                    //Conditions to check in which quadrant the point lies. If X-Coordinate is 0 the point lies in Y-asix and vice versa. If both are 0, the point lies in origin. 
                    quadrant_summary.InnerHtml += "<h2>("+X_coordinate_value+", "+Y_coordinate_value+") lies in ";
                    if(X_coordinate_value > 0 && Y_coordinate_value > 0)
                    {
                        quadrant_summary.InnerHtml += "Quadrant number: 1</h2>";
                    }
                    else if(X_coordinate_value < 0 && Y_coordinate_value > 0)
                    {
                        quadrant_summary.InnerHtml += "Quadrant number: 2</h2>";
                    }
                    else if(X_coordinate_value < 0 && Y_coordinate_value < 0 )
                    {
                        quadrant_summary.InnerHtml += "Quadrant number: 3</h2>";
                    }
                    else if (X_coordinate_value > 0 && Y_coordinate_value < 0)
                    {
                        quadrant_summary.InnerHtml += "Quadrant number: 4</h2>";
                    }
                    else if(X_coordinate_value == 0 && Y_coordinate_value!=0)
                    {
                        quadrant_summary.InnerHtml += "Y-axis</h2>";
                    }
                    else if (Y_coordinate_value == 0 && X_coordinate_value!=0)
                    {
                        quadrant_summary.InnerHtml += "X-axis</h2>";
                    }
                    else //Both X and Y axis are 0
                    {
                        quadrant_summary.InnerHtml += "Origin</h2>";
                    }
                }

            }

        }
    }
}