<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RaffleBundle.aspx.cs" Inherits="n01358379_Bonus_Assignment.RaffleBundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <main>
            <h1>The HTTB Program</h1>
            <div>
                <label>Number of tickets ordered:</label>
                <asp:TextBox ID="number_of_tickets" runat="server"/>
                <asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please enter a number" ControlToValidate="number_of_tickets"></asp:RequiredFieldValidator>
                <%--Compare Validator to allow only numbers that are greater than 0 --%>
                <asp:CompareValidator forecolor="Red" runat="server" Operator="GreaterThan" Type="Integer" ControlToValidate="number_of_tickets" ValueToCompare="0" ErrorMessage="Please enter a number greater than 0" />
            </div>
            <div id="ticket_summary" runat="server">

            </div>
            <div>
                <asp:Button runat="server" Text="Submit"/>
            </div>
            <div>
                <asp:ValidationSummary runat="server" forecolor="Red" ShowSummary="true" />
            </div>
        </main>
    </form>
</body>
</html>
