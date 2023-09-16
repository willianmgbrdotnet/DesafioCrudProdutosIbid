<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ViewWebForms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h1>Lista de Produtos</h1>
                <asp:GridView ID="GridViewProdutos" runat="server" AutoGenerateColumns="true">
                </asp:GridView>
        </div>
        </div>
    </form>
</body>
</html>
