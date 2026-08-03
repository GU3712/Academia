using AcademiaApp.Models;
using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Aluno
    {
        [Key]
        public int IdAluno { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [StringLength(14)]
        public string Cpf { get; set; } = string.Empty;

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [StringLength(20)]
        public string? Telefone { get; set; }

        // Navegação (Relacionamentos)
        public ICollection<Matricula>? Matriculas { get; set; }
        public ICollection<FichaTreino>? FichasTreino { get; set; }
    }
}