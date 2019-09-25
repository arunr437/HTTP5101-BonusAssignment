<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goKart_review.aspx.cs" Inherits="n01358379_Assign.goKart_review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Go Kart Review</title>
    <link rel="stylesheet" type="text/css" href="/Content/ReviewStyle.css" />
</head>
<body>
	<!-- go kart form using webforms-->
	<form runat="server">
		<main>
			<h1>401 Mini-Indy GO Karts</h1>
			<h3>Please enter your details!</h3>
			<section>
				<div>
					<label>First name:</label>
					<asp:TextBox runat="server" ID="customer_first_name" ></asp:TextBox>
					<asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please enter your first name" ControlToValidate="customer_first_name"></asp:RequiredFieldValidator>
				</div>
				<div>
					<label>Last name:</label>
					<asp:TextBox runat="server" ID="customer_last_name" ></asp:TextBox>
					<asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please enter your last name" ControlToValidate="customer_last_name"></asp:RequiredFieldValidator>		
				</div>
				<div>
					<label>Contact number:</label>
					<asp:TextBox runat="server" ID="customer_contact_number" ></asp:TextBox>
					<asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please enter your contact number" ControlToValidate="customer_contact_number"></asp:RequiredFieldValidator>        
					<%--************************************************************************************************************************************************************************************  
						Regular Expression code cited from below source: 

						Author: Regular expressions Cookbook, 2nd Edition by Steven Levithan, Jan Goyvaerts
						Date: 2019-09-24
						Site: https://www.oreilly.com/library/view/regular-expressions-cookbook/9781449327453/ch04s02.html
						Purpose: To get regular expressions for Canadians phone numbers
						******************************************************************************************************************************************************************************* --%>
					<asp:RegularExpressionValidator foreColor="Red" ControlToValidate="customer_contact_number" runat="server" ErrorMessage="Incorrect phone number format" ValidationExpression="^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$"></asp:RegularExpressionValidator>                
				</div>
                <div>
					<label>Age:(0-99)</label>
					<asp:TextBox runat="server" ID="customer_age" ></asp:TextBox>
					<asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please enter an age" ControlToValidate="customer_age"></asp:RequiredFieldValidator>
					<asp:RangeValidator forecolor="Red" runat="server" ErrorMessage="Please enter an age between 0-99" ControlToValidate="customer_age" Type="Integer" MinimumValue="0" MaximumValue="99"></asp:RangeValidator>
                </div>
                <div>
					<h3>Which of our branches did you visit? </h3>
					<asp:DropDownList runat="server" ID="gokart_branch">
						<asp:ListItem Value="" Text="-- Select a branch! --"></asp:ListItem>
						<asp:ListItem Text="Etobicoke" Value="Etobicoke"></asp:ListItem>
						<asp:ListItem Text="Brampton" Value="Brampton"></asp:ListItem>
						<asp:ListItem Text="Toronto" Value="Toronto"></asp:ListItem>
						<asp:ListItem Text="York" Value="York"></asp:ListItem>
						<asp:ListItem Text="Mississauga" Value="Mississauga"></asp:ListItem>
					</asp:DropDownList>
					<asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please choose the branch that you visited!" ControlToValidate="gokart_branch"></asp:RequiredFieldValidator>
                </div>
			</section>
			<section>
				<div>
					<h3>Customer Feedback form</h3>
					<h4> How was the quality our Go Karts?</h4>
					<asp:DropDownList runat="server" ID="customer_rating_quality">
						<asp:ListItem Text="-- Select an option! --" Value=""></asp:ListItem>
						<asp:ListItem Text="Great" Value="3"></asp:ListItem>
						<asp:ListItem Text="Average" Value="2"></asp:ListItem>
						<asp:ListItem Text="Bad" Value="1"></asp:ListItem>
					</asp:DropDownList>
					<asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please select a rating!" ControlToValidate="customer_rating_quality"></asp:RequiredFieldValidator>		                
				</div>
				<div>
					<h4> Would you recommend us to your friends/family ?(</h4>
					<asp:DropDownList runat="server" ID="customer_rating_recommendation">
						<asp:ListItem Text="-- Select an option! --" Value=""></asp:ListItem>
						<asp:ListItem Text="Yes" Value="3"></asp:ListItem>
						<asp:ListItem Text="Not Sure" Value="2"></asp:ListItem>
						<asp:ListItem Text="No" Value="1"></asp:ListItem>
					</asp:DropDownList>
					<asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please select a rating!" ControlToValidate="customer_rating_recommendation"></asp:RequiredFieldValidator>		                
				</div>
			</section>
			<section>
                <div>
					<h3>Which type of service did you choose ?</h3>
					<asp:RadioButtonList runat="server" id="customer_service_type" RepeatDirection="Horizontal">
						<asp:ListItem Text="Indoor" Value="Indoor"></asp:ListItem>
						<asp:ListItem Text="Outdoor" Value="Outdoor"></asp:ListItem>
					</asp:RadioButtonList>
					<asp:RequiredFieldValidator forecolor="Red" runat="server" ErrorMessage="Please select either yes or no" ControlToValidate="customer_service_type"></asp:RequiredFieldValidator>		                		
				</div>
            </section>
			<section>
                <div>
					<h3>What are the positives of our place ? </h3>
					<asp:CheckBoxList runat="server" ID="customer_positives" RepeatDirection="Horizontal">
						<asp:ListItem Text="Infrastructure" Value="Infrastructure"></asp:ListItem>
						<asp:ListItem Text="Customer Service" Value="Customer Service"></asp:ListItem>
						<asp:ListItem Text="Cafeteria" Value="Cafeteria"></asp:ListItem>
					</asp:CheckBoxList>
                </div>
			</section>
			<section>
                <div>
					<asp:ValidationSummary runat="server" forecolor="Red" ShowSummary="true" />
                </div>
			</section>
			<section id="confirmbox" runat="server">
			</section>
			<section>
                <div>
					<asp:Button runat="server" Text="Submit"/>
                </div>
			</section>
		</main>
	</form>
</body>
</html>
