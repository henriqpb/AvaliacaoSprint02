using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AvaliacaoSprint02
{
    class OMaior
    {

        public static void Executar()

        {
            ////-EXE-1013-O MAIOR------------------------------------------------------



            string[] numeros = Console.ReadLine().Split(' ');

            int num1 = Convert.ToInt32(numeros[0]);
            int num2 = Convert.ToInt32(numeros[1]);
            int num3 = Convert.ToInt32(numeros[2]);

            //Console.WriteLine(numeros[0]);


            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine(num1 + " eh o maior");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine(num2 + " eh o maior");
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine(num3 + " eh o maior");
            }

        }
    }
}
