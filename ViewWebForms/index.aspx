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
    h2 {
        text-align: center;
        font-size: 13px;
    }
</style>
</head>
<body>
    <h1>Produtos IBID</h1>
    <h2><a href="https://www.linkedin.com/in/williandotnetalves/">LinkedIn Willian dotNet</a></h2>
    <h2><a href="https://github.com/willianmgbrdotnet">github Willian dotNet</a></h2>

    <form id="form1" runat="server">
        <div>
            <div class="container">
            <a href="cadastrarprodutos.aspx"><b>Cadastre um novo Produto</b></a>
            <a href="buscarproduto.aspx"><b>Buscar Produto pelo Código</b></a>
            <a href="excluirproduto.aspx"><b>Buscar e EXCLUIR Produto</b></a>
        </div><br>
        <!-- Os produtos serão mostrados nesta GridView --> 
        <div>
            <asp:GridView ID="GridViewProdutos" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
