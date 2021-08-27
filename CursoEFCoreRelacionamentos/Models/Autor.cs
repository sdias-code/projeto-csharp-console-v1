using System;
using System.Collections.Generic;
using System.Text;

namespace CursoEFCoreRelacionamentos.Models
{
    public class Autor
    {

        public int AutorId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public ICollection<Livro> Livros { get; set; }

    }
}
