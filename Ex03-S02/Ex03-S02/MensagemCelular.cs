using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_S02
{
    public class MensagemCelular
    {
        public long Telefone { get; set; }
        public string Mensagem { get; set; }

        public MensagemCelular(long telefone, string mensagem)
        {
            Telefone = telefone;
            Mensagem = mensagem;
        }
        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine($"Telefone {Telefone}, mensagem {Mensagem}");
        }
        public void Executar()
        {
            Console.WriteLine("Método público executado na classe");
            EnviarMensagemAoTelefone();
        }
    }
}
