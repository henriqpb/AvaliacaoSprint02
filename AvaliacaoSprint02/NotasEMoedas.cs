using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint02
{
    class NotasEMoedas
    {
        public static void Executar()

        {
            //-EXE-1021-NOTAS E MOEDAS------------------------------------------------------
            

            double entradaValor = double.Parse(Console.ReadLine());

            int entradaValorInteiro = (int)entradaValor;


            double centavos = entradaValor - entradaValorInteiro;


            int centavosInt = (int)(100 * centavos);





            int nota100 = (entradaValorInteiro / 100);
            int restoDe100 = (entradaValorInteiro % 100);
            int nota50 = (restoDe100 / 50); 
            int restoDe50 = (restoDe100 % 50);
            int nota20 = (restoDe50 / 20);
            int restoDe20 = (restoDe50 % 20);
            int nota10 = (restoDe20 / 10);
            int restoDe10 = (restoDe20 % 10);
            int nota5 = (restoDe10 / 5);
            int restoDe5 = (restoDe10 % 5);
            int nota2 = (restoDe5 / 2);
            int restoDe2 = (restoDe5 % 2);
            int moeda1 = (restoDe2 / 1);
            int restoDe1 = (restoDe2 % 1);

            int moeda2 = (centavosInt / 50);
            int restoMoeda2 = (centavosInt % 50);
            int moeda3 = (restoMoeda2 / 25);
            int restoMoeda3 = (restoMoeda2 % 25);
            int moeda4 = (restoMoeda3 / 10);
            int restoMoeda4 = (restoMoeda3 % 10);
            int moeda5 = (restoMoeda4 / 5);
            int restoMoeda5 = (restoMoeda4 % 5);
            int moeda6 = (restoMoeda5 / 1);


            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda2 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda3 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda4 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda6 + " moeda(s) de R$ 0.01");

        }
    }
}
