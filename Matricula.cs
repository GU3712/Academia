using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia.Models
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }

        // Chave Estrangeira - Aluno
        public int IdAluno { get; set; }
        [ForeignKey("IdAluno")]
        public Aluno? Aluno { get; set; }

        // Chave Estrangeira - Plano
        public int IdPlano { get; set; }
        [ForeignKey("IdPlano")]
        public Plano? Plano { get; set; }

        [Display(Name = "Data de Início")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data de Fim")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Ativa"; // ex: Ativa, Cancelada, Vencida
    }
}