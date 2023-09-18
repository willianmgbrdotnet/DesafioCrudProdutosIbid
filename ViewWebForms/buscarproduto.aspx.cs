using Core;
using Manager;
using System;
using System.Web.UI;

namespace ViewWebForms
{
    public partial class BuscarParaEditar : Page
    {
        protected void btnBuscarEditar_Click(object sender, EventArgs e)
        {
            int produtoId;
            if (int.TryParse(txtIdProdutoEditar.Text, out produtoId))
            {
                ProdutoManager produtoManager = new ProdutoManager();
                Produto produto = produtoManager.GetById(produtoId);

                // Se o produto for encontrado, irá preencher os campos com os dados do produto
                if (produto != null)
                {
                    txtNomeProdutoEditar.Text = produto.Nome;
                    txtCategoriaEditar.Text = produto.Categoria;
                    txtQuantidadeEditar.Text = produto.Quantidade.ToString();
                }
                else
                {
                    LimparCampos();
                }
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Os dados da busca juntamente com os novos dados informados pelo usuário
            //Servirão para atualizar o produto existente.
            int produtoId;
            if (int.TryParse(txtIdProdutoEditar.Text, out produtoId))
            {
                string nomeProduto = txtNomeProdutoEditar.Text;
                string categoriaProduto = txtCategoriaEditar.Text;
                int quantidadeProduto = int.Parse(txtQuantidadeEditar.Text);

                // Será instanciado um novo Produto
                Produto produtoAtualizado = new Produto
                {
                    ProdutoId = produtoId,
                    Nome = nomeProduto,
                    Categoria = categoriaProduto,
                    Quantidade = quantidadeProduto
                };

                ProdutoManager produtoManager = new ProdutoManager();
                produtoManager.UpdateProduto(produtoAtualizado);

                LimparCampos();
            }
        }

        //Metodo para limpar os campos em caso de erro ou sucesso
        private void LimparCampos()
        {
            txtNomeProdutoEditar.Text = string.Empty;
            txtCategoriaEditar.Text = string.Empty;
            txtQuantidadeEditar.Text = string.Empty;
        }
    }
}
