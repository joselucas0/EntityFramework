using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data; 
using Npgsql;

namespace Exemplos4.Connection
{
    public class Conexao
    {
    private static readonly string conn = "Host=localhost;Database=Exemplos4;Username=postgres;Password=123456";

    public static IDbConnection GetConnection()
    {
        return new Npgsql.NpgsqlConnection(conn);
    }
    
    }
}