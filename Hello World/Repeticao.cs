using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class Repeticao
    {
        static void Main(string[] argumentos)
        {
            foreach (var h in argumentos) {
                Console.WriteLine($"Cante comigo: {h}");
            }



        }
    }
}
