using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_S02
{
    public class MensagemCelular
    {
        public int Telefone { get; set; }
        public string Mensagem { get; set; }

        public MensagemCelular(int telefone, string mensagem)
        {
            Telefone = telefone;
            Mensagem = mensagem;
        }
    }
}
