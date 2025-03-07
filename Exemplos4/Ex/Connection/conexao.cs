using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos4.Ex.Connection
{
    public class conexao
    {
    private static readonly string conn = "Host=localhost;Database=ExercicioDapper;Username=postgres;Password=root";

    public static IDbConnection GetConnection()
    {
        return new Npgsql.NpgsqlConnection(conn);
    }
    
    }
}