using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoIntegrador.Models
{
    public class PontosColeta
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Responsavel { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(100)")]
        public string Cidade { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(100)")]
        public string Endereco { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(100)")]
        public string Numero { get; set; } = string.Empty;
    }
}
