using System;
using System.Collections.Generic;
using System.Linq;






public class ProdutoRepositorio
{
    private List<Produto> produtos = new List<Produto>();
    private int proximoId = 1;

    public void AdicionarProduto(Produto produto){

        produto.Id = proximoId++;
        produtos.Add(produto);
    }

     public List<Produto> Listar()
    {
        return produtos;
    }

      public Produto BuscarPorId(int id)
    {
        return produtos.FirstOrDefault(p => p.Id == id);
    }

    public bool Atualizar(int id, string nome, decimal preco, int quantidade)
    {
        var produto = BuscarPorId(id);
        if (produto == null) return false;

        produto.Nome = nome;
        produto.Preco = preco;
        produto.Quantidade = quantidade;
        return true;
    }

     public bool Remover(int id)
    {
        var produto = BuscarPorId(id);
        if (produto == null) return false;

        produtos.Remove(produto);
        return true;
    }
}