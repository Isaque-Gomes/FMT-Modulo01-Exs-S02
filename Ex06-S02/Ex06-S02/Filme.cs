using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_S02
{
    public class Filme
    {
        //Propriedades abaixo
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }
        //Construtor abaixo
        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
        }
        //Função abaixo
        public void Executar()
        {
            Console.WriteLine($"O filme {NomeFilme} está na categoria {Categoria}");
        }

    }
}
