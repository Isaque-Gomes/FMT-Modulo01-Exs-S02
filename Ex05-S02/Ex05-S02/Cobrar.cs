using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_S02
{
    public class Cobrar
    {
        private decimal Valor { get; set; }
        private decimal Multa { get; set; }

        private decimal calcularMulta;
        public Cobrar (decimal valor, decimal multa)
        {
            Valor = valor;
            Multa = multa;
        }
        private void CalcularMulta()
        {
            calcularMulta = Valor + Multa;
        }
        public void Calcular()
        {
            CalcularMulta();
            Console.WriteLine($"O valor cobrado é {Valor.ToString("C")} somado com a multa de {Multa.ToString("C")}, dá o total de {calcularMulta.ToString("C")}");
        }
    }
}
