using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class Repeticao
    {
        static void Main(string[] argumentos) {
            for (var loops = 0; loops < argumentos.Length ; loops++) {
                var argumento = argumentos[loops];
                Console.WriteLine($"Estamos com {loops}");
            }

            foreach (var argumento in argumentos) {
                Console.WriteLine($"Argumento lido : {argumento}");
            }

            var loops2 = 0;
            while (loops2 < argumentos.Length) {
                var argumento = argumentos[loops2];
                Console.WriteLine($"Veeem fi {argumento}");
                loops2++;
            }

            var loops3 = 0;
            do
            {
                var argumento = argumentos[loops3];
                Console.WriteLine($"Veeem fi {argumento}");
                loops3++;
            } while (loops3 < argumentos.Length);
        }
    }
}
