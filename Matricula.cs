using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace AcademiaApp.Models
{
    public class Matricula
    {
        [Key]
        public int IdMatricula { get; set; }

        public int IdAluno { get; set; }
        [ForeignKey("IdAluno")]
        public Aluno? Aluno { get; set; }

        public int IdPlano { get; set; }
        [ForeignKey("IdPlano")]
        public Plano? Plano { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }

        public string Status { get; set; } = "Ativo";
    }
}