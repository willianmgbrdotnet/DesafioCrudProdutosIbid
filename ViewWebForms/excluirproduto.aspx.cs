using Core;
using Manager;
using System;
using System.Web.UI;

namespace ViewWebForms
{
    public partial class BuscarParaExcluirProduto : Page
    {
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int produtoId;
            if (int.TryParse(txtIdProduto.Text, out produtoId))
            {
                ProdutoManager produtoManager = new ProdutoManager();
                Produto produto = produtoManager.GetById(produtoId);

                //Se o produto for encontrado, seus dados serão mostrados como texto.
                if (produto != null)
                {
                    lblResultado.Text = $"ID: {produto.ProdutoId}<br />Nome: {produto.Nome}<br />Categoria: {produto.Categoria}<br />Quantidade: {produto.Quantidade}";

                    // Interação com o 'Visible=false' da pagina .aspx
                    btnExcluir.Visible = true;
                }
                else
                {
                    // Mensagem de erro
                    lblResultado.Text = "Produto não encontrado.";
                    btnExcluir.Visible = false;
                }
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int produtoId;
            if (int.TryParse(txtIdProduto.Text, out produtoId))
            {
                // Método da Manager que exclui o produto
                ProdutoManager produtoManager = new ProdutoManager();
                produtoManager.DeleteProduto(produtoId);

                // Mensagem de sucesso e oculta novamente o botão para uma confirmação visual
                lblResultado.Text = "Produto excluído com sucesso.";
                btnExcluir.Visible = false;
            }
        }
    }
}
