<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Courses.aspx.cs" Inherits="Courses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Select Course "></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
        <br/>
         <asp:Label ID="Label2" runat="server" Text="Student ID"></asp:Label>
         <asp:TextBox ID="TextBox1" runat="server" CssClass=form-control></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Course Request" CssClass ="btn btn-warning" OnClick="Button1_Click"/>
    </form>
</asp:Content>

