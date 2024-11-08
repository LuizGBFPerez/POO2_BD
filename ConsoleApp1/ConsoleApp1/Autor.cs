using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Autor()
        {

        }
        public Autor(String nome)
        {
            Nome = nome;
        }
        public override string ToString()
        {
            return $"Autor -> id: {Id} | nome: {Nome}";
        }
    }
}
