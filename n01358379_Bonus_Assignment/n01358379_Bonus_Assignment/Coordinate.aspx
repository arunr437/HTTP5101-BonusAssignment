<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Coordinate.aspx.cs" Inherits="n01358379_Bonus_Assignment.Coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <main>
            <h1>The Cartesian Plane</h1>
            <h2>Please enter X and Y Coordinate values</h2>
            <div>
                <label>X coordinate:</label>
                <asp:TextBox runat="server" ID="x_coordinate_value" ></asp:TextBox>
                <asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please enter X coordinate value" ControlToValidate="x_coordinate_value"></asp:RequiredFieldValidator>                
                <%-- Zero Inputs has been handled in Codebehind,thus below compare validator has been commented --%>
                <%--<asp:CompareValidator forecolor="Red" runat="server" controltovalidate="x_coordinate_value" ValueToCompare="0" Operator="NotEqual" Type="Integer"  ErrorMessage="Please enter a non zero X coordinate value"></asp:CompareValidator>--%>                
                <%--Compare Validator to allow only Integer Values  --%>
                <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="x_coordinate_value" ErrorMessage="Please enter an Integer value for X-Coordinate" />
            </div>
            <div>
                <label>Y coordinate:</label>
                <asp:TextBox runat="server" ID="y_coordinate_value" ></asp:TextBox>
                <asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please enter y coordinate value" ControlToValidate="y_coordinate_value"></asp:RequiredFieldValidator>		
                <%-- Zero Inputs has been handled in Codebehind,thus below compare validator has been commented --%>
                <%--<asp:CompareValidator forecolor="Red" runat="server" controltovalidate="y_coordinate_value" ValueToCompare="0" Operator="NotEqual" Type="Integer"  ErrorMessage="Please enter a non zero Y coordinate value"></asp:CompareValidator>--%>
                <%--Compare Validator to allow only Integer Values  --%>
                <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" ControlToValidate="y_coordinate_value" ErrorMessage="Please enter an Integer value Y-Coordinate" />
            </div>
            <div id="quadrant_summary" runat="server">
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
