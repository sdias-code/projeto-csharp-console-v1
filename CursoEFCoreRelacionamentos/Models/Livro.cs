using System;
using System.Collections.Generic;
using System.Text;

namespace CursoEFCoreRelacionamentos.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
