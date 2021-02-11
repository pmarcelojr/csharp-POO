using System;
using Microsoft.EntityFrameworkCore;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LivroContext())
            {
                db.Livros.Add(new Livro { Titulo = "Domain-Driven Desing", Autor = "Eric Evans", AnoPublicacao = 2003 });
                db.Livros.Add(new Livro { Titulo = "Agile principles", Autor = "Robert C. Martin", AnoPublicacao = 2006 });
                db.SaveChanges();

                Console.WriteLine("------------------- RESULTADOS BANCO DE DADOS --------------------");
                db.Livros.ForEachAsync(x =>
                    Console.WriteLine($"Titulo: {x.Titulo} | Autor: {x.Autor} | Publicação: {x.AnoPublicacao}"));
            }
        }
    }

    public class LivroContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql(@"server=localhost; port=3306; database=DeveloperExpert; user=root; password=1234; Persist Security Info=False; Connect Timeout=300");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .ToTable("Livro");

            modelBuilder.Entity<Livro>()
                .HasKey(p => p.LivroId);
            
            modelBuilder.Entity<Livro>()
                .Property(p => p.Titulo)
                .HasColumnType("varchar(50)");
        }
    }

    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
