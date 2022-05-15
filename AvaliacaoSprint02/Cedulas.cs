using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint02
{
    class Cedulas
    {
        public static void Executar()

        {

            ////-EXE-1018-CEDULAS------------------------------------------------------

            int entradaValor = int.Parse(Console.ReadLine());

            

            int nota100 = (entradaValor / 100);
            int restoDe100 = (entradaValor % 100);
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
            int nota1 = (restoDe2 / 1);
            int restoDe1 = (restoDe2 % 1);


            Console.WriteLine(entradaValor);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");

            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");

            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");

            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");

            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");

            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");

            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
        }

    }
}
