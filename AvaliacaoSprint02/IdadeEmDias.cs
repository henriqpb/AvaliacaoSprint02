using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint02
{
    class IdadeEmDias
    {
        public static void Executar()

        {
            //-EXE-1020-IDADE EM DIAS------------------------------------------------------

            int entradaDias = int.Parse(Console.ReadLine());


            int anos = (entradaDias / 365);

            int anosResto = (entradaDias % 365);

            int meses = (anosResto / 30);

            int dias = (anosResto % 30);


            Console.WriteLine(anos + " ano (s)");

            Console.WriteLine(meses + " mes (es)");
            Console.WriteLine(dias + " dia (s)");

        }
    }
}
