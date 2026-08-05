using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Aluno
    {
        [Key]
        public int IdAluno { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o CPF.")]
        [StringLength(14)]
        public string Cpf { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public string? Telefone { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string? Email { get; set; }

        [Required]
        public string Status { get; set; } = "Ativo";

        public ICollection<Matricula>? Matriculas { get; set; }
        public ICollection<Treino>? Treinos { get; set; }
        public ICollection<AvaliacaoFisica>? AvaliacoesFisicas { get; set; }
    }
}
