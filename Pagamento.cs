using AcademiaApp.Models;
using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Plano
    {
        [Key]
        public int IdPlano { get; set; }

        [Required(ErrorMessage = "O nome do plano é obrigatório.")]
        [StringLength(50)]
        public string Nome { get; set; } = string.Empty; // ex: Mensal, Anual, VIP

        [Required(ErrorMessage = "O valor é obrigatório.")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        // Navegação
        public ICollection<Matricula>? Matriculas { get; set; }
    }
}