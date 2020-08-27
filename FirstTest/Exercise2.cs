using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Exercise2
    {
        public static void WordMaker()
        {
            //Solicite ao usuário que informe uma palavra qualquer,
            //porém ele deve digitar uma letra por vez.
            //Quando o usuário informar a palavra “Finalizar”,
            //a aplicação deve apresentar a palavra inteira. (1p)

            var word = "";

            while (true)
            {
                Console.WriteLine("Informe uma palavra qualquer, um caractere por vez.");
                var input = Console.ReadLine();
                if ((input == "Finalizar") || (input == "finalizar")) break;
                else if (input.Length > 1) Console.WriteLine("Por favor informe somente um caractere por vez");
                else word += input;
            }

            Console.WriteLine($"A palavra formada é: {word}");
            Console.ReadLine();
        }
    }
}
