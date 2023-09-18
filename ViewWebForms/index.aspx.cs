using Core;
using Manager;
using System;
using System.Collections.Generic;

namespace ViewWebForms
{
    public partial class index : System.Web.UI.Page
    {
        // Assim que a pagina for carregado, os produtos serão mostrados
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProdutoManager produtoManager = new ProdutoManager();
                List<Produto> produtos = produtoManager.GetAllProdutos();

                //Os produtos serão mostrados em uma GridView
                GridViewProdutos.DataSource = produtos;
                GridViewProdutos.DataBind();
            }

        }
    }
}