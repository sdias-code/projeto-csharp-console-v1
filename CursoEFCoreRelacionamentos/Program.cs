
using CursoEFCoreRelacionamentos.Models;
using System;
using System.Collections.Generic;

namespace CursoEFCoreRelacionamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            IncluirAutor();
            IncluirAutorLivros();
            Console.WriteLine("Digite Enter para sair!");
            Console.ReadLine();
        }

        private static void IncluirAutorLivros()
        {
            using (var contexto = new AppDbContext())
            {
                var autor = new Autor
                {
                    Nome = "Roberto",
                    Sobrenome = "Magalhaes",
                    Livros = new List<Livro>
                    {
                    new Livro{Titulo = "Correndo atras do prejuizo",
                    AnoLancamento = 2000},
                    new Livro{Titulo = "Aprendendo a empreender",
                    AnoLancamento = 2005 }

                    }

                };


                contexto.Autores.Add(autor);
                contexto.SaveChanges();
            }
        }

        private static void IncluirAutor()
        {
            using (var contexto = new AppDbContext())
            {
                var autor = new Autor { Nome = "Mauricio", Sobrenome = "Souza" };
                contexto.Autores.Add(autor);
                contexto.SaveChanges();
            }
        }
    }
}
