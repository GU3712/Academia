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
        public DbSet<Instrutor> Instrutores { get; set; }
        public DbSet<FichaTreino> FichasTreino { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Aluno").HasKey(a => a.IdAluno);
            modelBuilder.Entity<Plano>().ToTable("Plano").HasKey(p => p.IdPlano);
            modelBuilder.Entity<Matricula>().ToTable("Matricula").HasKey(m => m.IdMatricula);
            modelBuilder.Entity<Instrutor>().ToTable("Instrutor").HasKey(i => i.IdInstrutor);
            modelBuilder.Entity<FichaTreino>().ToTable("Ficha_Treino").HasKey(f => f.IdTreino);
            modelBuilder.Entity<Exercicio>().ToTable("Exercicio").HasKey(e => e.IdExercicio);
        }
    }
}