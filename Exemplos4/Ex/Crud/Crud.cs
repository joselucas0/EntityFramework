using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos4.Ex.Crud
{
    public class Crud
    {
        private readonly IDbConnection _dbConnection;

        public Crud()
        {
            _dbConnection = Conexao.GetConnection();
        }

       
        public void InserirUsuario(int id, string nome, string senha, int ramal, string especialidade)
        {
            string query = "INSERT INTO Usuarios (ID_Usuario, Password, Nome_Usuario, Ramal, Especialidade) " +
                           "VALUES (@ID_Usuario, @Password, @Nome_Usuario, @Ramal, @Especialidade)";
            _dbConnection.Execute(query, new 
            { 
                ID_Usuario = id, 
                Password = senha, 
                Nome_Usuario = nome, 
                Ramal = ramal, 
                Especialidade = especialidade 
            });
            Console.WriteLine($"Usuário {nome} inserido com sucesso!");
        }




      
        public void InserirMaquina(int idMaquina, string tipo, int velocidade, int harddisk, int memoriaRam, int placaRede, int fkUsuario)
        {
            string query = "INSERT INTO Maquina (ID_Maquina, Tipo, Velocidade, Harddisk, Memoria_Ram, Placa_Rede, Fk_Usuario) " +
                           "VALUES (@ID_Maquina, @Tipo, @Velocidade, @Harddisk, @Memoria_Ram, @Placa_Rede, @Fk_Usuario)";
            _dbConnection.Execute(query, new 
            { 
                ID_Maquina = idMaquina, 
                Tipo = tipo, 
                Velocidade = velocidade, 
                Harddisk = harddisk, 
                Memoria_Ram = memoriaRam, 
                Placa_Rede = placaRede, 
                Fk_Usuario = fkUsuario 
            });
            Console.WriteLine($"Máquina {tipo} inserida com sucesso!");
        }


       
        public void InserirSoftware(int idSoftware, string produto, int harddisk, int memoriaRam, int fkMaquina)
        {
            string query = "INSERT INTO Software (ID_Software, Produto, Harddisk, Memoria_Ram, Fk_Maquina) " +
                           "VALUES (@ID_Software, @Produto, @Harddisk, @Memoria_Ram, @Fk_Maquina)";
            _dbConnection.Execute(query, new 
            { 
                ID_Software = idSoftware, 
                Produto = produto, 
                Harddisk = harddisk, 
                Memoria_Ram = memoriaRam, 
                Fk_Maquina = fkMaquina 
            });
            Console.WriteLine($"Software {produto} inserido com sucesso!");
        }


      
        public void ListarUsuarios()
        {
            string query = "SELECT * FROM Usuarios";
            var usuarios = _dbConnection.Query<Usuario>(query).ToList();

            Console.WriteLine("Lista de Usuários:");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"ID: {usuario.ID_Usuario}, Nome: {usuario.Nome_Usuario}, Especialidade: {usuario.Especialidade}");
            }
        }

        // Listar e exibir máquinas
        public void ListarMaquinas()
        {
            string query = "SELECT * FROM Maquina";
            var maquinas = _dbConnection.Query<Maquina>(query).ToList();

            Console.WriteLine("Lista de Máquinas:");
            foreach (var maquina in maquinas)
            {
                Console.WriteLine($"ID: {maquina.ID_Maquina}, Tipo: {maquina.Tipo}, Velocidade: {maquina.Velocidade} MHz");
            }
        }

        // Listar e exibir softwares
        public void ListarSoftwares()
        {
            string query = "SELECT * FROM Software";
            var softwares = _dbConnection.Query<Software>(query).ToList();

            Console.WriteLine("Lista de Softwares:");
            foreach (var software in softwares)
            {
                Console.WriteLine($"ID: {software.ID_Software}, Produto: {software.Produto}, Harddisk: {software.Harddisk} GB, Memória RAM: {software.Memoria_Ram} GB");
            }
        }

        // Atualizar usuário
        public void AtualizarUsuario(int id, string nomeNovo)
        {
            string query = "UPDATE Usuarios SET Nome_Usuario = @Nome WHERE ID_Usuario = @Id";
            _dbConnection.Execute(query, new { Id = id, Nome = nomeNovo });
            Console.WriteLine($"Usuário com ID {id} atualizado com sucesso!");
        }

        // Deletar usuário
        public void DeletarUsuario(int id)
        {
            string query = "DELETE FROM Usuarios WHERE ID_Usuario = @Id";
            _dbConnection.Execute(query, new { Id = id });
            Console.WriteLine($"Usuário com ID {id} deletado com sucesso!");
        }

        // Atualizar máquina
        public void AtualizarMaquina(Maquina maquina)
        {
            string query = "UPDATE Maquina SET Tipo = @Tipo, Velocidade = @Velocidade, Harddisk = @Harddisk, Memoria_Ram = @Memoria_Ram, Placa_Rede = @Placa_Rede WHERE ID_Maquina = @ID_Maquina";
            _dbConnection.Execute(query, maquina);
            Console.WriteLine($"Máquina com ID {maquina.ID_Maquina} atualizada com sucesso!");
        }

        // Deletar máquina
        public void DeletarMaquina(int id)
        {
            string query = "DELETE FROM Maquina WHERE ID_Maquina = @Id";
            _dbConnection.Execute(query, new { Id = id });
            Console.WriteLine($"Máquina com ID {id} deletada com sucesso!");
        }
    }
}