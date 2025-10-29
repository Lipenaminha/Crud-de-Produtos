using System;





class Program {

     static void Main()
    {

ProdutoRepositorio repo = new ProdutoRepositorio();

bool sair = false;

while (!sair)
        {
            Console.WriteLine("\n===== INVENTÁRIO DE PRODUTOS =====");
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Atualizar produto");
            Console.WriteLine("4 - Remover produto");
            Console.WriteLine("5 - Buscar produto por ID");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            try
            {
                switch (opcao)
                {
                    case "1":
                        AdicionarProduto(repo);
                        break;
                    case "2":
                        ListarProdutos(repo);
                        break;
                    case "3":
                        AtualizarProduto(repo);
                        break;
                    case "4":
                        RemoverProduto(repo);
                        break;
                    case "5":
                        BuscarProduto(repo);
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }

 static void AdicionarProduto(ProdutoRepositorio repo)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        decimal preco = decimal.Parse(Console.ReadLine());

        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        repo.AdicionarProduto(new Produto { Nome = nome, Preco = preco, Quantidade = quantidade });
        Console.WriteLine("✅ Produto adicionado com sucesso!");
    }

    static void ListarProdutos(ProdutoRepositorio repo)
    {
        var lista = repo.Listar();
        if (lista.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
            return;
        }

        foreach (var p in lista)
        {
            Console.WriteLine(p);
        }
    }

    static void AtualizarProduto(ProdutoRepositorio repo)
    {
        Console.Write("Digite o ID do produto a atualizar: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Novo nome: ");
        string nome = Console.ReadLine();

        Console.Write("Novo preço: ");
        decimal preco = decimal.Parse(Console.ReadLine());

        Console.Write("Nova quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        if (repo.Atualizar(id, nome, preco, quantidade))
            Console.WriteLine("✅ Produto atualizado!");
        else
            Console.WriteLine("❌ Produto não encontrado!");
    }

     static void RemoverProduto(ProdutoRepositorio repo)
    {
        Console.Write("Digite o ID do produto a remover: ");
        int id = int.Parse(Console.ReadLine());

        if (repo.Remover(id))
            Console.WriteLine("✅ Produto removido!");
        else
            Console.WriteLine("❌ Produto não encontrado!");
    }

     static void BuscarProduto(ProdutoRepositorio repo)
    {
        Console.Write("Digite o ID: ");
        int id = int.Parse(Console.ReadLine());

        var produto = repo.BuscarPorId(id);
        if (produto != null)
            Console.WriteLine(produto);
        else
            Console.WriteLine("❌ Produto não encontrado!");
    }
}
