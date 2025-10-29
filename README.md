# Inventário de Produtos (Console App em C#)

![C#](https://img.shields.io/badge/C%23-blue?style=for-the-badge)
![.NET 6](https://img.shields.io/badge/.NET%206-brightgreen?style=for-the-badge)
![CRUD](https://img.shields.io/badge/CRUD-yellow?style=for-the-badge)


## Descrição
Este projeto é um **sistema de inventário de produtos em console**, desenvolvido em C# com foco em **Programação Orientada a Objetos (POO)** e **CRUD em memória**.  
O objetivo é praticar conceitos de POO, coleções (`List<Produto>`), separação de responsabilidades e tratamento de erros.

---

## Funcionalidades
- **Adicionar produto**: cadastra novos produtos com ID, nome, preço e quantidade.  
- **Listar produtos**: exibe todos os produtos cadastrados.  
- **Atualizar produto**: altera informações de um produto existente pelo ID.  
- **Remover produto**: exclui um produto pelo ID.  
- **Buscar produto**: consulta produto específico pelo ID.  

---

## Tecnologias
- C#  
- .NET 6+ (Console Application)  
- Listas (`List<T>`)  
- POO: classes, objetos, métodos, encapsulamento  
- Tratamento de erros: `try/catch`  

---

## Estrutura do Projeto

InventarioProdutos/
├── Program.cs # Menu de opções e interface com usuário
├── Produto.cs # Classe Produto (atributos e ToString)
├── ProdutoRepository.cs # CRUD em memória (Adicionar, Listar, Atualizar, Remover, Buscar)
└── README.md # Este arquivo


## Como Executar
1. Clone o repositório:

git clone git@github.com:Lipenaminha/Crud-de-Produtos.git

2. Navegue até a pasta do projeto:
cd InventarioProdutos

3. Rode o projeto:
dotnet run 

## Licença
Este projeto é licenciado sob a licença GIT.

![Git](https://img.shields.io/badge/Git-black?style=for-the-badge)


