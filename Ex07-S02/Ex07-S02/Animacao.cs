using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_S02
{
    public static class Animacao
    {
        public static void Desenho()
        {
            Console.WriteLine("Desenho da Marvel");
        }

        public static void Desenho(string tipo) 
        {
            Console.WriteLine($"Desenho da {tipo}");
        }

        public static void Desenho(string tipo, string nomeDesenho)
        {
            Console.WriteLine($"Desenho da {tipo} com nome {nomeDesenho}");
        }
    }
}
