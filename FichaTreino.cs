using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academia.Models
{
    public class FichaTreino
    {
        [Key]
        public int IdTreino { get; set; }

        // Chave Estrangeira - Aluno
        public int IdAluno { get; set; }
        [ForeignKey("IdAluno")]
        public Aluno? Aluno { get; set; }

        // Chave Estrangeira - Instrutor
        public int IdInstrutor { get; set; }
        [ForeignKey("IdInstrutor")]
        public Instrutor? Instrutor { get; set; }

        [Display(Name = "Data de Criação")]
        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [StringLength(100)]
        public string? Objetivo { get; set; } // ex: Hipertrofia, Emagrecimento
    }
}