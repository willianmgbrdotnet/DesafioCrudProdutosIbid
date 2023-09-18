<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarParaEditar.aspx.cs" Inherits="ViewWebForms.BuscarParaEditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buscar e Editar Produto</title>
</head>
<body>
    <h1>Buscar e Editar Produto</h1>
    <form id="formBuscarEditar" runat="server">
        <div>
            <asp:Label ID="lblIdProdutoEditar" runat="server" Text="ID do Produto:"></asp:Label>
            <asp:TextBox ID="txtIdProdutoEditar" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarEditar" runat="server" Text="Buscar" OnClick="btnBuscarEditar_Click" />
        </div><br>
        <div>
            <!-- Abaixo, ficam os campos com os dados do produto e para edição -->
            <asp:Label ID="lblNomeProdutoEditar" runat="server" Text="Nome do Produto:"></asp:Label><br>
            <asp:TextBox ID="txtNomeProdutoEditar" runat="server" size="100"></asp:TextBox>
            <br /><br>
            <asp:Label ID="lblCategoriaEditar" runat="server" Text="Categoria:"></asp:Label><br>
            <asp:TextBox ID="txtCategoriaEditar" runat="server" size="100"></asp:TextBox>
            <br /><br>
            <asp:Label ID="lblQuantidadeEditar" runat="server" Text="Quantidade:"></asp:Label><br>
            <asp:TextBox ID="txtQuantidadeEditar" runat="server"></asp:TextBox>
        </div><br><br>
        <div>
            <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
        </div>
    </form>
    <div style="text-align: center;">
        <a href="index.aspx"><b>Mostrar todos os Produtos</b></a>
    </div>
</body>
</html>
