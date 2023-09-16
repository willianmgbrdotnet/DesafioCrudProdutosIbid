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
                // Chame um método para obter a lista de produtos da camada Manager
                List<Produto> produtos = produtoManager.GetAllProdutos(); // Supondo que você tenha uma classe ProdutoManager

                // Associe a lista de produtos ao GridView
                GridViewProdutos.DataSource = produtos;
                GridViewProdutos.DataBind();
            }

        }
    }
}