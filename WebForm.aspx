<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="OData.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewPerson" runat="server"/> 

        </div>
        <br />
        Sort by:<asp:DropDownList ID="SortBy" runat="server">
             <asp:ListItem Selected="True" Value="UserName"> UserName </asp:ListItem>
                  <asp:ListItem Value="FirstName"> FirstName </asp:ListItem>
                  <asp:ListItem Value="LastName"> LastName </asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="acsButton" runat="server" OnClick="acsButton_Click" Text="Sort ASC" />
        <asp:Button ID="descButton" runat="server" OnClick="descButton_Click" Text="Sort DESC" /><br /><br />

        Filter by: <asp:DropDownList ID="FilterBy" runat="server">
             <asp:ListItem Selected="True" Value="UserName"> UserName </asp:ListItem>
                  <asp:ListItem Value="FirstName"> FirstName </asp:ListItem>
                  <asp:ListItem Value="LastName"> LastName </asp:ListItem>
        </asp:DropDownList>
        
        Equals: <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="filterButton" runat="server" Text="Filter" OnClick="showFilters"/>
        
    </form>
</body>
</html>
