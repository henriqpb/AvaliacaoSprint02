using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint02
{
    class SentencaDancante
    {
        public static void Executar()

        {
            //-EXE-1234-SENTENÇA DAÇANTE----------------------------------------------------


            string entradaCasos;


            while ((entradaCasos = Console.ReadLine()) != null)
            {


                int contador = 1;



                foreach (char charEntrada in entradaCasos)


                {
                    if (contador % 2 != 0)
                    {
                        if (char.IsWhiteSpace(charEntrada))
                        {

                            Console.Write(charEntrada);

                        }
                        else
                        {

                            Console.Write(char.ToUpper(charEntrada));
                            contador++;

                        }
                    }



                    else if (contador % 2 == 0)
                    {


                        if (char.IsWhiteSpace(charEntrada))
                        {

                            Console.Write(charEntrada);

                        }
                        else
                        {
                            Console.Write(char.ToLower(charEntrada));
                            contador++;
                        }
                    }

                }
                Console.Write("\n");
            }

        }
    }
}
