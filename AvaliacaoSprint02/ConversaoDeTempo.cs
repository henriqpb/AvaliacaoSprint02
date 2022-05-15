using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint02
{
    class ConversaoDeTempo
    {

        public static void Executar()

        {
            //-EXE-1019-CONVERSÃO DE TEMPO------------------------------------------------------

            int entradaSegundos = int.Parse(Console.ReadLine());

            int hora = (entradaSegundos / 3600);
            int restoHora = (entradaSegundos % 3600);
            int minuto = (restoHora / 60);
            int segundo = (restoHora % 60);


            Console.WriteLine(hora + ":" + minuto + ":" + segundo);

        }
    }
}
