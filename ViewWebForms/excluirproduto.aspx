<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarParaExcluirProduto.aspx.cs" Inherits="ViewWebForms.BuscarParaExcluirProduto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buscar para Excluir Produto</title>
</head>
<body>
    <h1>Buscar para Excluir Produto</h1>
    <form id="formBuscarParaExcluirProduto" runat="server">
        <div>
            <asp:Label ID="lblIdProduto" runat="server" Text="ID do Produto:"></asp:Label>
            <asp:TextBox ID="txtIdProduto" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        </div><br>
        <div>
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </div><br>
        <div>
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" Visible="false" />
        </div>
    </form>
    <div style="text-align: center;">
        <a href="index.aspx"><b>Mostrar todos os Produtos</b></a>
    </div>
</body>
</html>
