<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Control.aspx.vb" Inherits="IOT_Web_Demos.Control" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        #Text1 {
            height: 20px;
            width: 159px;
            margin-left: 37px;
            margin-top: 57px;
        }
        #Button1 {
            margin-left: 32px;
            margin-top: 31px;
        }
        #Text2 {
            height: 20px;
            width: 155px;
            margin-left: 37px;
            margin-top: 39px;
        }
        #Button2 {
            margin-left: 29px;
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="height: 288px; margin-top: 0px; margin-left: 0px;">
        <div style="height: 225px; margin-top: 0px; width: 929px;">
            &nbsp;<asp:Label ID="Label3" runat="server" Text="测试："></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="17px" style="margin-left: 6px; margin-top: 22px" Width="231px"></asp:TextBox>
            <asp:Button ID="BtnSend" runat="server" Height="27px" style="margin-left: 29px; margin-top: 2px" Text="发送" Width="68px" />
        &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="16px" style="margin-left: 22px; margin-top: 21px" Width="232px"></asp:TextBox>
&nbsp;<div style="height: 104px; width: 938px; margin-top: 26px">
                <asp:Label ID="Label1" runat="server" Text="LED :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnLed" runat="server" Height="21px" style="margin-left: 4px; margin-top: 3px" Text="开启" />
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="继电器："></asp:Label>
                <asp:Button ID="BtnRelay" runat="server" style="margin-top: 7px" Text="开启" />
                <br />
&nbsp;&nbsp;&nbsp;
            </div>
        </div>
    </div>
</asp:Content>
