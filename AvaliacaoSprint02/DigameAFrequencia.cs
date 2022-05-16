using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint02
{
    class DigameAFrequencia
    {
        public static void Executar()

        {
            //-EXE-1251-DIGA-ME A FREQUENCIA-------------------------------------------------  


            string entrada;
            StringBuilder magia = new StringBuilder();

            while (!string.IsNullOrWhiteSpace(entrada = Console.ReadLine()))
            {




                byte[] arrayASCII = Encoding.ASCII.GetBytes(entrada);


                var listaASCII = arrayASCII.GroupBy(x => x);


                var listaOrdemASCII = listaASCII.OrderBy(x => x.Count()).ThenByDescending(x => x.Key);



                foreach (var simbolo in listaOrdemASCII)
                {
                    magia.AppendLine($"{simbolo.Key} {simbolo.Count()}");
                }
                magia.AppendLine();


            }

            magia.Remove(magia.Length - 1, 1);

            Console.Write(magia);

        }
    }
}
