using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Exemplos4.Models
{
[Table("Usuarios")]
public class Usuario
{
    [Key]
    [Column("ID_Usuario")]
    public int ID_Usuario { get; set; }

    [Column("Password")]
    public string Password { get; set; } = string.Empty;

    [Column("Nome_Usuario")]
    public string Nome_Usuario { get; set; } = string.Empty;

    [Column("Ramal")]
    public int Ramal { get; set; }

    [Column("Especialidade")]
    public string Especialidade { get; set; } = string.Empty;
}
}