using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Livro
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public Autor AutorDoLivro {  get; set; }
        
        public Livro() { }

        public Livro (string titulo, Autor autorDoLivro)
        {
            Titulo = titulo;
            AutorDoLivro = autorDoLivro;
        }
        public override string ToString()
        {
            return $"Livro -> Id: {Id} | Titulo: {Titulo} |" + $"Autor: {AutorDoLivro}";
        }
    }
}
