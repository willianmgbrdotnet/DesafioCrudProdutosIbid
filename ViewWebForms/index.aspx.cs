using Core;
using Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewWebForms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProdutoManager produtoManager = new ProdutoManager();
                // Método que mostra todos os produtos
                List<Produto> produtos = produtoManager.GetAllProdutos();

                //Os produtos serão mostrados em uma GridView
                GridViewProdutos.DataSource = produtos;
                GridViewProdutos.DataBind();
            }

        }
    }
}