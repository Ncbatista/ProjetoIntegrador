using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoIntegrador.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Nome { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(100)")]
        public string Login { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(100)")]
        public string Senha { get; set; } = string.Empty;
    }
}
