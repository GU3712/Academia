using System.ComponentModel.DataAnnotations;

namespace AcademiaApp.Models
{
    public class Aluno
    {
        [Key]
        public int IdAluno { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o CPF.")]
        public string Cpf { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public string? Telefone { get; set; }

        
        public ICollection<Matricula>? Matriculas { get; set; }
        public ICollection<FichaTreino>? FichasTreino { get; set; }
    }
}