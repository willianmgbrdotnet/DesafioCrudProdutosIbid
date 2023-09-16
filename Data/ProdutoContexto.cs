using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProdutoContexto : DbContext
    {
        public ProdutoContexto() : base("name=SqlServerConnection")
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
