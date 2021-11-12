<%@ Page Title="" Language="C#" MasterPageFile="~/Levis.Master" AutoEventWireup="true" CodeBehind="Loops.aspx.cs" Inherits="levis01.Loops" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Button ID="btnDowhile" runat="server" OnClick="btnDowhile_Click" Text="Do While Loop" />
    <br />
    <asp:Button ID="btnWhile" runat="server" OnClick="Button2_Click" Text="While Loop" />
    <br />
    <asp:Button ID="btnForloop" runat="server" OnClick="btnForloop_Click" Text="for Loop" />
    <br />
    <asp:Button ID="btnforeach" runat="server" OnClick="btnforeach_Click" Text="foreach Loop" />
</asp:Content>
