using Core;
using Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ProdutoManager
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
        }

        private readonly ProdutoData _produtoData;

        public ProdutoManager()
        {
            _produtoData = new ProdutoData();
        }

        public List<Produto> GetAllProdutos()
        {
            return _produtoData.GetAllProdutos();
        }

        public Produto GetById(int produtoId)
        {
            return _produtoData.GetById(produtoId);
        }

        public void CreateProduto(Produto produto)
        {
            try
            {
                //validação para implementar depois dos testes
                _produtoData.CreateProduto(produto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateProduto(Produto produto)
        {
            try
            {
                //validação para implementar depois dos testes
                _produtoData.UpdateProduto(produto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteProduto(int produtoId)
        {
            try
            {
                //validação para implementar depois dos testes
                _produtoData.DeleteProduto(produtoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //O 'Dispose' desfaz a instância
        public void Dispose()
        {
            _produtoData.Dispose();
        }
    }
}
