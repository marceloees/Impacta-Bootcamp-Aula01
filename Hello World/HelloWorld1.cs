using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    class HelloWorld1
    {
        static void Main(string[] args) {
            int idade = 18;
            bool isAdulto;
            decimal valor = 10.55m;
            double valor2 = 10.55;
            char sigla = 'C';
            string estado = "São Paulo";
            var teste = "teste";

            if (idade >= 18 && estado == "São Paulo")
            {
                valor2 = +3;
                Console.WriteLine(valor2);
            }
            else if (idade <= 36 && estado == "Sergipe")
            {
                valor2 =- 3;
                Console.WriteLine(valor2);
            }
            
            }


            

        }
    }
