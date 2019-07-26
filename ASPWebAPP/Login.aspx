<%@ Page Title="" Language="C#" MasterPageFile="~/MySite.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPWebAPP.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td colspan="3" style="text-align: center">User Login</td>
        </tr>
        <tr>
            <td style="width: 20%">User Name</td>
            <td style="width: 60%">
                <asp:TextBox ID="txtusername" runat="server" Width="100%" ValidationGroup="Login"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="Login" ControlToValidate="txtusername" ErrorMessage="Enter UserName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtpassword" TextMode="Password" runat="server" ValidationGroup="Login" Width="100%"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="Login" ControlToValidate="txtpassword" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnLogin" runat="server"  Text="Login" OnClick="btnLogin_Click" ValidationGroup="Login" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />

                <asp:HyperLink ID="hyp" runat="server" NavigateUrl="~/Registeration.aspx"></asp:HyperLink>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label><asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="Login"  runat="server" />
            </td>
            <td></td>
        </tr>
    </table>
</asp:Content>
