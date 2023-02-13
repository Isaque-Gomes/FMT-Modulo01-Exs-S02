using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_S02
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int idade;
        public Pessoa (string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
        private void CalcularIdade()
        {
            DataNascimento = new DateTime(1984, 1, 2);
            var dataAtual = DateTime.Now;
            idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
        }
        public void MostrarIdade()
        {
            CalcularIdade();

            Console.WriteLine($"{Nome} tem a idade de {idade} anos.");
        }
    }
}
