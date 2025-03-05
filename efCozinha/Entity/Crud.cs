using System;
using System.Linq;

namespace Entity
{
    public class Crud
    {
        public void InserirPessoa()
        {
            using (var db = new Ligacao())
            {
                Console.WriteLine("Digite o nome da pessoa:");
                string nome = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Digite o CPF da pessoa:");
                string cpf = Console.ReadLine() ?? string.Empty;

                Pessoa pessoa = new Pessoa { Nome = nome, Cpf = cpf };
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                Console.WriteLine("Pessoa inserida com sucesso.");
            }
        }

        public void ListarPessoas()
        {
            using (var db = new Ligacao())
            {
                var pessoas = db.Pessoas.ToList();
                Console.WriteLine("\n--- Lista de Pessoas ---");
                foreach (var pessoa in pessoas)
                {
                    Console.WriteLine($"ID: {pessoa.Id}, Nome: {pessoa.Nome}, CPF: {pessoa.Cpf}");
                }
            }
        }

        public void AtualizarPessoa()
        {
            using (var db = new Ligacao())
            {
                Console.WriteLine("Digite o ID da pessoa que deseja atualizar:");
                int id = Convert.ToInt32(Console.ReadLine());

                var pessoa = db.Pessoas.Find(id);
                if (pessoa != null)
                {
                    Console.WriteLine("Digite o novo nome:");
                    pessoa.Nome = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Digite o novo CPF:");
                    pessoa.Cpf = Console.ReadLine() ?? string.Empty;

                    db.SaveChanges();
                    Console.WriteLine("Pessoa atualizada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Pessoa não encontrada.");
                }
            }
        }

        public void DeletarPessoa()
        {
            using (var db = new Ligacao())
            {
                Console.WriteLine("Digite o ID da pessoa que deseja deletar:");
                int id = Convert.ToInt32(Console.ReadLine());

                var pessoa = db.Pessoas.Find(id);
                if (pessoa != null)
                {
                    db.Pessoas.Remove(pessoa);
                    db.SaveChanges();
                    Console.WriteLine("Pessoa deletada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Pessoa não encontrada.");
                }
            }
        }
    }
}