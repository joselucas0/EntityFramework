using System;
using Npgsql;

namespace GerenciamentoImoveis
{
    public class GerenciadorImoveis
    {
        private string conexao = "Host=localhost;Database=GerenciamentoImoveis;Username=postgres;Password=123456";

        public void Conectar()
        {
            using (NpgsqlConnection cnx = new NpgsqlConnection(conexao))
            {
                try
                {
                    cnx.Open();
                    Console.WriteLine("Conectado com sucesso");

                    while (true)
                    {
                        Console.WriteLine("\nEscolha uma operação:");
                        Console.WriteLine("1 - Inserir Pessoa");
                        Console.WriteLine("2 - Listar Pessoas");
                        Console.WriteLine("3 - Atualizar Pessoa");
                        Console.WriteLine("4 - Deletar Pessoa");
                        Console.WriteLine("5 - Sair");
                        string opcao = Console.ReadLine() ?? string.Empty;

                        switch (opcao)
                        {
                            case "1":
                                InserirPessoa(cnx);
                                break;
                            case "2":
                                ListarPessoas(cnx);
                                break;
                            case "3":
                                AtualizarPessoa(cnx);
                                break;
                            case "4":
                                DeletarPessoa(cnx);
                                break;
                            case "5":
                                return;
                            default:
                                Console.WriteLine("Opção inválida.");
                                break;
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }
        }

        private void InserirPessoa(NpgsqlConnection cnx)
        {
            Console.WriteLine("Digite o nome da pessoa:");
            string nome = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Digite o CPF da pessoa:");
            string? cpf = Console.ReadLine();

            string insertQuery = "INSERT INTO public.pessoa (nome, cpf) VALUES (@nome, @cpf)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, cnx))
            {
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("cpf", cpf);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                Console.WriteLine($"{linhasAfetadas} linha(s) inserida(s) com sucesso.");
            }
        }

        private void ListarPessoas(NpgsqlConnection cnx)
        {
            string selectQuery = "SELECT * FROM public.pessoa";
            using (NpgsqlCommand cmd = new NpgsqlCommand(selectQuery, cnx))
            {
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n--- Lista de Pessoas ---");
                    while (dr.Read())
                    {
                        int idPessoa = Convert.ToInt32(dr["id_pessoa"]);
                        string nome = dr["nome"]?.ToString() ?? string.Empty;
                        string cpf = dr["cpf"]?.ToString() ?? string.Empty;
                        Console.WriteLine($"ID: {idPessoa}, Nome: {nome}, CPF: {cpf}");
                    }
                }
            }
        }

        private void AtualizarPessoa(NpgsqlConnection cnx)
        {
            Console.WriteLine("Digite o ID da pessoa que deseja atualizar:");
            int idPessoa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o novo nome:");
            string? nome = Console.ReadLine();
            Console.WriteLine("Digite o novo CPF:");
            string? cpf = Console.ReadLine();

            string updateQuery = "UPDATE public.pessoa SET nome = @nome, cpf = @cpf WHERE id_pessoa = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, cnx))
            {
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("cpf", cpf);
                cmd.Parameters.AddWithValue("id", idPessoa);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                Console.WriteLine($"{linhasAfetadas} linha(s) atualizada(s) com sucesso.");
            }
        }

        private void DeletarPessoa(NpgsqlConnection cnx)
        {
            Console.WriteLine("Digite o ID da pessoa que deseja deletar:");
            int idPessoa = Convert.ToInt32(Console.ReadLine());

            string deleteQuery = "DELETE FROM public.pessoa WHERE id_pessoa = @id";
            using (NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, cnx))
            {
                cmd.Parameters.AddWithValue("id", idPessoa);
                int linhasAfetadas = cmd.ExecuteNonQuery();
                Console.WriteLine($"{linhasAfetadas} linha(s) deletada(s) com sucesso.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorImoveis gerenciador = new GerenciadorImoveis();
            gerenciador.Conectar();
        }
    }
}