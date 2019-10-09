<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeeklyCalendar.aspx.cs" Inherits="n01358379_Bonus_Assignment.WeeklyCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="/Content/Style.css" />
</head>
<body>
    <form runat="server">
        <main>
            <h1>Weekly Calendar</h1>
            <h2>Select the days you work</h2>
            <div>
                <asp:CheckBoxList runat="server" ID="working_days">
                    <asp:ListItem Value="0">Monday</asp:ListItem>
                    <asp:ListItem Value="1">Tuesday</asp:ListItem>
                    <asp:ListItem Value="2">Wednesday</asp:ListItem>
                    <asp:ListItem Value="3">Thursday</asp:ListItem>
                    <asp:ListItem Value="4">Friday</asp:ListItem>
                    <asp:ListItem Value="5">Saturday</asp:ListItem>
                    <asp:ListItem Value="6">Sunday</asp:ListItem>
                </asp:CheckBoxList>
            </div>
            <div>
                <asp:Button runat="server" Text="Submit"/>
            </div>       
            <div id="calendar_summary" runat="server">
            </div>
            <!--  ---------------Additional Content: Showing the output in a Calendar Layout using tables-----------------*/ -->
            <div>
                <table>
                    <caption>October</caption>
                    <thead>
                        <tr>
                            <th>Sun</th>
                            <th>Mon</th>
                            <th>Tue</th>
                            <th>Wed</th>
                            <th>Thu</th>
                            <th>Fri</th>
                            <th>Sat</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td></td>
                            <td></td>                          
                            <td><div class="day" runat="server" id="day1">1</div></td>
                            <td><div class="day" runat="server" id="day2">2</div></td>
                            <td><div class="day" runat="server" id="day3">3</div></td>
                            <td><div class="day" runat="server" id="day4">4</div></td>
                            <td><div class="day" runat="server" id="day5">5</div></td>
                        </tr>
                        <tr>
                            <td><div class="day" runat="server" id="day6">6</div></td>
                            <td><div class="day" runat="server" id="day7">7</div></td>
                            <td><div class="day" runat="server" id="day8">8</div></td>
                            <td><div class="day" runat="server" id="day9">9</div></td>
                            <td><div class="day" runat="server" id="day10">10</div></td>
                            <td><div class="day" runat="server" id="day11">11</div></td>
                            <td><div class="day" runat="server" id="day12">12</div></td>
                        </tr>
                        <tr>
                            <td><div class="day" runat="server" id="day13">13</div></td>
                            <td><div class="day" runat="server" id="day14">14</div></td>
                            <td><div class="day" runat="server" id="day15">15</div></td>
                            <td><div class="day" runat="server" id="day16">16</div></td>
                            <td><div class="day" runat="server" id="day17">17</div></td>
                            <td><div class="day" runat="server" id="day18">18</div></td>
                            <td><div class="day" runat="server" id="day19">19</div></td>
                        </tr>
                        <tr>
                            <td><div class="day" runat="server" id="day20">20</div></td>
                            <td><div class="day" runat="server" id="day21">21</div></td>
                            <td><div class="day" runat="server" id="day22">22</div></td>
                            <td><div class="day" runat="server" id="day23">23</div></td>
                            <td><div class="day" runat="server" id="day24">24</div></td>
                            <td><div class="day" runat="server" id="day25">25</div></td>
                            <td><div class="day" runat="server" id="day26">26</div></td>

                        </tr>
                        <tr>
                            <td><div class="day" runat="server" id="day27">27</div></td>
                            <td><div class="day" runat="server" id="day28">28</div></td>
                            <td><div class="day" runat="server" id="day29">29</div></td>
                            <td><div class="day" runat="server" id="day30">30</div></td>
                            <td><div class="day" runat="server" id="day31">31</div></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </main>
    </form>
</body>
</html>
