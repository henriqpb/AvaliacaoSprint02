using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint02
{
    class ParesEImpares
    {
        public static void Executar()
        {
            //-EXE-1259-PARES E IMPARES------------------------------------------------------

            //entradas



            int primeiroNum = int.Parse(Console.ReadLine());

            //Console.WriteLine($"primeiro numero {primeiroNum}");


            int tamanhoArray = primeiroNum;

            //Console.WriteLine($"tamanho da array {tamanhoArray}");


            //lista de entrada

            int[] arrayEntrada = new int[tamanhoArray];

            for (int i = 0; i < tamanhoArray; i++)
            {
                arrayEntrada[i] = int.Parse(Console.ReadLine());

            }


            //É Par ou Impar

            //Lista impar e lista par
            List<int> listImpar = new List<int>();
            List<int> listPar = new List<int>();


            for (int i = 0; i < arrayEntrada.Length; i++)
            {
                if (arrayEntrada[i] % 2 == 1)
                {
                    // Lista Impar

                    listImpar.Add(arrayEntrada[i]);

                    //Console.WriteLine(arrayEntrada[i] + " num impar");

                    //Console.WriteLine(listImpar.Count + " aqui é a lista");


                }
                if (arrayEntrada[i] % 2 == 0)
                {
                    // Lista Par

                    listPar.Add(arrayEntrada[i]);

                    //Console.WriteLine(arrayEntrada[i] + " num par");

                    //Console.WriteLine(listPar.Count + " aqui é a lista");

                }

            }

            //Ordenando listas

            foreach (int par in listPar.OrderBy(x => x))
            {
                Console.WriteLine(par);
            }



            foreach (int impar in listImpar.OrderByDescending(x => x))
            {
                Console.WriteLine(impar);
            }

        }

    }
}
