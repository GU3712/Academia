using Academia.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Academia.Data
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<ItemTreino> ItensTreino { get; set; }
        public DbSet<AvaliacaoFisica> AvaliacoesFisicas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Aluno").HasKey(a => a.IdAluno);
            modelBuilder.Entity<Plano>().ToTable("Plano").HasKey(p => p.IdPlano);
            modelBuilder.Entity<Matricula>().ToTable("Matricula").HasKey(m => m.IdMatricula);
            modelBuilder.Entity<Pagamento>().ToTable("Pagamento").HasKey(pg => pg.IdPagamento);
            modelBuilder.Entity<Instrutor>().ToTable("Instrutor").HasKey(i => i.IdInstrutor);
            modelBuilder.Entity<Treino>().ToTable("Treino").HasKey(t => t.IdTreino);
            modelBuilder.Entity<Exercicio>().ToTable("Exercicio").HasKey(e => e.IdExercicio);
            modelBuilder.Entity<ItemTreino>().ToTable("Item_Treino").HasKey(it => it.IdItemTreino);
            modelBuilder.Entity<AvaliacaoFisica>().ToTable("Avaliacao_Fisica").HasKey(af => af.IdAvaliacao);
        }
    }
}
