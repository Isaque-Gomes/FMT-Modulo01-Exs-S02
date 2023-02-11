using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_S02
{
    public class Guitarra
    {
        private static string Afinacao { get; set; }

        static Guitarra()
        {
            Afinacao = "sol";
        }

        private static void TomAfinado()
        {
            Console.WriteLine($"A guitarra está com afinação em {Afinacao}");
        }

        public void Tocar()
        {
            TomAfinado();
        }
        public void Tocar(string afinacaoAtual)
        {
            Afinacao = afinacaoAtual;
            TomAfinado();
        }
    }
}
