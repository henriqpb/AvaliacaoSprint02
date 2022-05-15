using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AvaliacaoSprint02
{
    class CalculoSimples
    {
        public static void Executar()

        {

            //-EXE-1010-CALCULO SIMPLES--------------------------------------------------------

            CultureInfo cultura = new CultureInfo("en-US");

            //id qnt valor

            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');


            int quantidade1 = Convert.ToInt32(peca1[1]);

            double preco1 = Convert.ToDouble(peca1[2]);

            int quantidade2 = Convert.ToInt32(peca2[1]);

            double preco2 = Convert.ToDouble(peca2[2]);


            double valor1 = quantidade1 * preco1;
            double valor2 = quantidade2 * preco2;
            double valorTotal = valor1 + valor2;

            string respostaString = valorTotal.ToString("F2", cultura);
            Console.WriteLine("VALOR A PAGAR: R$ " + respostaString);

        }
    }
}
