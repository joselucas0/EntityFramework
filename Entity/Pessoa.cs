using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Pessoa
    {
        [Column("id_pessoa")] 
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("cpf")]
        public string Cpf { get; set; } = string.Empty;
    }
}