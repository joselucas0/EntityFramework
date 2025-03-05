using System;

namespace Entity
{
    class Executar
    {
        static void Main(string[] args)
        {
            Crud crud = new Crud();

            while (true)
            {
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Inserir Pessoa");
                Console.WriteLine("2 - Listar Pessoas");
                Console.WriteLine("3 - Atualizar Pessoa");
                Console.WriteLine("4 - Deletar Pessoa");
                Console.WriteLine("5 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        crud.InserirPessoa();
                        break;
                    case "2":
                        crud.ListarPessoas();
                        break;
                    case "3":
                        crud.AtualizarPessoa();
                        break;
                    case "4":
                        crud.DeletarPessoa();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}