<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="nodedatamanager.aspx.vb" Inherits="IOT_Web_Demos.nodedatamanager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        节点：<asp:DropDownList ID="nodelist" runat="server" DataTextField="location" 
            DataValueField="srcno" Height="16px" Width="123px">
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="删除" Width="114px" OnClientClick='if (!confirm("你确定要删除该地点的所有数据吗？")) {return false;}' style="margin-left: 25px; margin-top: 9px" />
    <br />
    <asp:GridView ID="nodedataView" runat="server" BackColor="LightGoldenrodYellow" 
        BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" 
        GridLines="None" Height="257px" style="margin-top: 31px" Width="902px">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
            HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
</p>
</asp:Content>
