<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                    <asp:Label for="TxtName" runat="server" Text="Student Name"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtSurName" runat="server" Text="Student Surname"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSurName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtNumber" runat="server" Text="Student Number"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtPassword" runat="server" Text="Student Password"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtPhoto" runat="server" Text="Student Photo"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtPhoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>
</asp:Content>

