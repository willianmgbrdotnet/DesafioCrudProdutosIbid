using Core;
using Manager;
using System;

namespace ViewWebForms
{
    public partial class cadastrarprodutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Primeiro preencha os campos. Pois
        //O metodo CREATE será chamado ao clicar no Botão.
        protected void CriarProduto_Click(object sender, EventArgs e)
        {

            string nomeProduto = nome_produto.Text;
            string _categoria = categoria.Text;
            int _quantidade = int.Parse(quantidade.Text);

            Produto novoProduto = new Produto
            {
                Nome = nomeProduto,
                Categoria = _categoria,
                Quantidade = _quantidade
            };

            // A instância do novo produto será criado na Manager
            ProdutoManager produtoManager = new ProdutoManager();
            produtoManager.CreateProduto(novoProduto);

            // Caso o produto seja cadastrado com sucesso. Voltará automaticamente para a index.
            //Apenas para verificação de sucesso. Esta função poderá ser excluída.
            Response.Redirect("index.aspx");
        }

    }
}