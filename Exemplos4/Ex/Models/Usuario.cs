using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos4.Ex.Models
{
[Table("Usuarios")]
public class Usuario
{
    [Key]
    [Column("ID_Usuario")]
    public int ID_Usuario { get; set; }

    [Column("Password")]
    public string Password { get; set; }

    [Column("Nome_Usuario")]
    public string Nome_Usuario { get; set; }

    [Column("Ramal")]
    public int Ramal { get; set; }

    [Column("Especialidade")]
    public string Especialidade { get; set; }
}
}