using System.ComponentModel.DataAnnotations;

namespace AcademiaApp.Models
{
    public class Plano
    {
        [Key]
        public int IdPlano { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public decimal Valor { get; set; }
    }
}