using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Instrutor
    {
        [Key]
        public int IdInstrutor { get; set; }

        [Required(ErrorMessage = "O nome do instrutor é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CREF é obrigatório.")]
        [StringLength(20)]
        public string Cref { get; set; } = string.Empty;

        // Navegação
        public ICollection<FichaTreino>? FichasTreino { get; set; }
    }
}