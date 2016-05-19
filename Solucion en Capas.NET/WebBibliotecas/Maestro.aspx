<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Maestro.aspx.cs" Inherits="WebBibliotecas.Maestro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="gvBibliotecas" runat="server" CellPadding="4" 
            ForeColor="#333333" GridLines="None" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" 
            DataSourceID="SqlDataSource1">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" 
                    SortExpression="Id" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" 
                    SortExpression="Nombre" />
                <asp:CheckBoxField DataField="Publica" HeaderText="Publica" 
                    SortExpression="Publica" />
                <asp:BoundField DataField="Inauguracion" HeaderText="Inauguracion" 
                    SortExpression="Inauguracion" />
                <asp:BoundField DataField="Libros" HeaderText="Libros" 
                    SortExpression="Libros" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:BibliotecasConnectionString %>" 
            SelectCommand="SELECT * FROM [Biblioteca]" 
            DeleteCommand="DELETE FROM [Biblioteca] WHERE [Id] = @Id" 
            InsertCommand="INSERT INTO [Biblioteca] ([Id], [Nombre], [Publica], [Inauguracion], [Libros]) VALUES (@Id, @Nombre, @Publica, @Inauguracion, @Libros)" 
            UpdateCommand="UPDATE [Biblioteca] SET [Nombre] = @Nombre, [Publica] = @Publica, [Inauguracion] = @Inauguracion, [Libros] = @Libros WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Id" Type="Int32" />
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Publica" Type="Boolean" />
                <asp:Parameter Name="Inauguracion" Type="DateTime" />
                <asp:Parameter Name="Libros" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Publica" Type="Boolean" />
                <asp:Parameter Name="Inauguracion" Type="DateTime" />
                <asp:Parameter Name="Libros" Type="Int32" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

    </asp:Panel>
</asp:Content>
