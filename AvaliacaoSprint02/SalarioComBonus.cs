using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace AvaliacaoSprint02
{
    class SalarioComBonus
    {
        public static void Executar()

        {
            //-EXE-1009-SALARIO COM BONUS------------------------------------------------------------------------

            CultureInfo cultura = new CultureInfo("en-US");

            string nomeFunc = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());

            double totalReceber = salario + (totalVendas * 0.15);

            string respostaString = totalReceber.ToString("F2", cultura);
            Console.WriteLine("TOTAL = R$ " + respostaString);

        }

        

    }
}
