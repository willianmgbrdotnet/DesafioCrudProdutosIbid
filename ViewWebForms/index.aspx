<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ViewWebForms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Produtos IBID</title>

    <style>
    /* Alinhamento de h1 e hrefs*/
    .container {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    h1 {
        text-align: center;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
            <a href="cadastrarprodutos.aspx"><b>Cadastre um novo Produto</b></a>
            <h1>Produtos IBID</h1>
            <a href="buscarproduto.aspx"><b>Buscar Produto pelo Código</b></a>
        </div>
        <div>
            <asp:GridView ID="GridViewProdutos" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
