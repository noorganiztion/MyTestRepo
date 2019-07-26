<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MyUserControl.ascx.cs" Inherits="ASPWebAPP.MyUserControl" %>
 Welcome:<asp:Label ID="lblLoginUser" runat="server"></asp:Label>
                        <asp:LinkButton ID="lnkSignout" runat="server" OnClick="lnkSignout_Click">Login</asp:LinkButton>
