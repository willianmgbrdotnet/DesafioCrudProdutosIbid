<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastrarprodutos.aspx.cs" Inherits="ViewWebForms.cadastrarprodutos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastrar Produtos</title>
</head>
<body>
    <h1>Cadastre um novo produto</h1>
    <form id="form1" runat="server">
        <label for="nome_produto">Nome do Produto:</label><br />
        <asp:TextBox ID="nome_produto" runat="server" required></asp:TextBox><br /><br />

        <label for="categoria">Categoria:</label><br />
        <asp:TextBox ID="categoria" runat="server" required></asp:TextBox><br /><br />

        <label for="quantidade">Quantidade:</label><br />
        <asp:TextBox ID="quantidade" runat="server" required></asp:TextBox><br /><br />

        <asp:Button ID="CriarProduto" runat="server" Text="Criar" OnClick="CriarProduto_Click" />
    </form>
    <div style="text-align: center;">
        <a href="index.aspx"><b>Mostrar todos os Produtos</b></a>
    </div>
</body>
</html>
