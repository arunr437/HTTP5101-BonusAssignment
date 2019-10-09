using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01358379_Bonus_Assignment
{
    public partial class WeeklyCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    //Code to get values from the select box and to store it in a List of type int. 
                    calendar_summary.InnerHtml = "";
                    List<int> Working_days = new List<int>();//List is used instead of Array because the number of values returned from select box may vary
                    int[] Days_of_the_month = new int[31];//Initialzing an array of Integers of size 31 for each day of the October month
                    foreach (ListItem day in working_days.Items)
                    {
                        if (day.Selected)
                        {
                            Working_days.Add(int.Parse(day.Value));
                        }
                    }

                    //Below statement converts the list into Array. For loop is easier to use in an Array    
                    Working_days.ToArray();

                    //Setting all values of the integer array:Days_of_the_month to 0 (holiday)  
                    for(int i=0;i<31;i++)
                    {
                        Days_of_the_month[i] = 0;
                    }
                    
                    //Below snippet sets the values of only 'Working Days' to 1 in the integer array 
                    for(int i=0;i<31;i++)
                    {
                        for(int j=0;j<Working_days.Count;j++)
                        {
                            if((i+1)%7==Working_days[j])
                            {
                                Days_of_the_month[i] = 1;
                            }
                        }
                    }

                    //Code to print the desired summary using the Integer Array:Days_of_the_month
                    for(int i=0;i<31;i++)
                    {
                        calendar_summary.InnerHtml += "Oct " + (i + 1) + " is a ";
                        if((i+1)%7==1)
                        {
                            calendar_summary.InnerHtml += "Tuesday!";
                        }
                        else if((i+1)%7==2)
                        {
                            calendar_summary.InnerHtml += "Wednesday!";
                        }
                        else if((i+1)%7==3)
                        {
                            calendar_summary.InnerHtml += "Thursday!";
                        }
                        else if((i+1)%7==4)
                        {
                            calendar_summary.InnerHtml += "Friday!";
                        }
                        else if((i+1)%7==5)
                        {
                            calendar_summary.InnerHtml += "Saturday!";
                        }
                        else if((i+1)%7==6)
                        {
                            calendar_summary.InnerHtml += "Sunday!";
                        }
                        else if((i+1)%7==0)
                        {
                            calendar_summary.InnerHtml += "Monday!";
                        }
                        //If the array contains 0 its a holiday, else its a working day. 
                        if (Days_of_the_month[i] == 0)
                        {
                            calendar_summary.InnerHtml += " Time to have fun! <br>";

                        }
                        else
                        {
                            calendar_summary.InnerHtml += " Time to work..<br>";
                        }
                    }
                    //-------Additional Content: Code to insert data into a table with a Calendar Layout  ------
                    day1.InnerHtml = "";
                    day2.InnerHtml = "";
                    day3.InnerHtml = "";
                    day4.InnerHtml = "";
                    day5.InnerHtml = "";
                    day6.InnerHtml = "";
                    day7.InnerHtml = "";
                    day8.InnerHtml = "";
                    day9.InnerHtml = "";
                    day10.InnerHtml = "";
                    day11.InnerHtml = "";
                    day12.InnerHtml = "";
                    day13.InnerHtml = "";
                    day14.InnerHtml = "";
                    day15.InnerHtml = "";
                    day16.InnerHtml = "";
                    day17.InnerHtml = "";
                    day18.InnerHtml = "";
                    day19.InnerHtml = "";
                    day20.InnerHtml = "";
                    day21.InnerHtml = "";
                    day22.InnerHtml = "";
                    day23.InnerHtml = "";
                    day24.InnerHtml = "";
                    day25.InnerHtml = "";
                    day26.InnerHtml = "";
                    day27.InnerHtml = "";
                    day28.InnerHtml = "";
                    day29.InnerHtml = "";
                    day30.InnerHtml = "";
                    day31.InnerHtml = "";

                    for (int i = 0; i < 31; i++)
                    {
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 0)
                            {
                                day1.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 1)
                            {
                                day2.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 2)
                            {
                                day3.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 3)
                            {
                                day4.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 4)
                            {
                                day5.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 5)
                            {
                                day6.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 6)
                            {
                                day7.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 7)
                            {
                                day8.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 8)
                            {
                                day9.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 9)
                            {
                                day10.InnerHtml += "<br><center>Working</center>";
                            }
                        }

                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 10)
                            {
                                day11.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 11)
                            {
                                day12.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 12)
                            {
                                day13.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 13)
                            {
                                day14.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 14)
                            {
                                day15.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 15)
                            {
                                day16.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 16)
                            {
                                day17.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 17)
                            {
                                day18.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 18)
                            {
                                day19.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 19)
                            {
                                day20.InnerHtml += "<br><center>Working</center>";
                            }
                        }

                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 20)
                            {
                                day21.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 21)
                            {
                                day22.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 22)
                            {
                                day23.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 23)
                            {
                                day24.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 24)
                            {
                                day25.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 25)
                            {
                                day26.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 26)
                            {
                                day27.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 27)
                            {
                                day28.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 28)
                            {
                                day29.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 29)
                            {
                                day30.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                        if (Days_of_the_month[i] == 1)
                        {
                            if (i == 30)
                            {
                                day31.InnerHtml += "<br><center>Working</center>";
                            }
                        }
                    }

                }
                
            }
        }
    }


}