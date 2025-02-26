using System;
using Npgsql;

namespace ADO
{
    public class Executar
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

                    // -----------------------------
                    // Exemplo de INSERT com ON CONFLICT DO NOTHING
                    // -----------------------------
                    string insertQuery = @"
                        INSERT INTO public.pessoa (nome, cpf) 
                        VALUES ('José da Silva', '99999949999') 
                        ON CONFLICT (cpf) DO NOTHING";
                    
                    using (NpgsqlCommand cmdInsert = new NpgsqlCommand(insertQuery, cnx))
                    {
                        int linhasAfetadas = cmdInsert.ExecuteNonQuery();
                        if (linhasAfetadas == 0)
                        {
                            Console.WriteLine("Registro não inserido, CPF já existe.");
                        }
                        else
                        {
                            Console.WriteLine("Linhas afetadas (INSERT): " + linhasAfetadas);
                        }
                    }

                    // -----------------------------
                    // Exemplo de DELETE em registros dependentes (unidade_residencial)
                    // -----------------------------
                    string deleteDependentes = "DELETE FROM unidade_residencial WHERE id_proprietario = 1";
                    using (NpgsqlCommand cmdDeleteDependentes = new NpgsqlCommand(deleteDependentes, cnx))
                    {
                        int linhasAfetadas = cmdDeleteDependentes.ExecuteNonQuery();
                        Console.WriteLine("Linhas afetadas (DELETE unidade_residencial): " + linhasAfetadas);
                    }

                    // -----------------------------
                    // Exemplo de DELETE na tabela 'pessoa'
                    // Atenção: CPF é do tipo VARCHAR, logo o valor deve estar entre aspas simples.
                    // -----------------------------
                    string deleteQuery = "DELETE FROM public.pessoa WHERE cpf = '99999949999'";
                    using (NpgsqlCommand cmdDelete = new NpgsqlCommand(deleteQuery, cnx))
                    {
                        int linhasAfetadas = cmdDelete.ExecuteNonQuery();
                        Console.WriteLine("Linhas afetadas (DELETE pessoa): " + linhasAfetadas);
                    }

                    // -----------------------------
                    // Exemplo de SELECT para verificar os registros
                    // -----------------------------
                    string selectQuery = "SELECT * FROM public.pessoa";
                    using (NpgsqlCommand cmdSelect = new NpgsqlCommand(selectQuery, cnx))
                    {
                        using (NpgsqlDataReader dr = cmdSelect.ExecuteReader())
                        {
                            Console.WriteLine("\n--- Registros na tabela 'pessoa' ---");
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
                catch (NpgsqlException ex)
                {
                    Console.WriteLine("Erro ao conectar com o banco de dados: " + ex.Message);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Executar executar = new Executar();
            executar.Conectar();
        }
    }
}
