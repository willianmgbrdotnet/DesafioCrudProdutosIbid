using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProdutoData
    {
        private readonly ProdutoContexto _contexto;

        public ProdutoData()
        {
            _contexto = new ProdutoContexto();
        }

        //Metodos LINQ para Queries no Banco de Dados

        public List<Produto> GetAllProdutos()
        {
            return _contexto.Produtos.ToList();
        }

        public Produto GetById(int produtoId)
        {
            return _contexto.Produtos.Find(produtoId);
        }

        public void CreateProduto(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
        }

        public void UpdateProduto(Produto produto)
        {
            _contexto.Entry(produto).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void DeleteProduto(int produtoId)
        {
            var produto = _contexto.Produtos.Find(produtoId);
            if (produto != null)
            {
                _contexto.Produtos.Remove(produto);
                _contexto.SaveChanges();
            }
        }

        //Esse método serve para liberar a memória quando terminar de usar a nova instância.
        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
