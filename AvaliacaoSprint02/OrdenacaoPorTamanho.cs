using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint02
{
    class OrdenacaoPorTamanho
    {
        public static void Executar()

        {
            //-EXE-1244-ORDENAÇÃO POR TAMANHO-----------------------------------------------

            //entradas

            

            int qntCasos = int.Parse(Console.ReadLine());


            string frase;

            string[] elementosFrase;


            for (int i = 0; i < qntCasos; i++)
            {
                frase = Console.ReadLine();

                elementosFrase = frase.Split(' ');



                foreach (string palavra in elementosFrase.OrderByDescending(s => s.Length))
                {

                    Console.Write($"{palavra} ");
                }


            }
        }

    }
}
