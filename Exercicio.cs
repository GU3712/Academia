using System.ComponentModel.DataAnnotations;

namespace Academia.Models
{
    public class Exercicio
    {
        [Key]
        public int IdExercicio { get; set; }

        [Required(ErrorMessage = "O nome do exercício é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty; // ex: Supino Reto, Agachamento

        [Required(ErrorMessage = "O grupo muscular é obrigatório.")]
        [StringLength(50)]
        public string GrupoMuscular { get; set; } = string.Empty;
    }
}