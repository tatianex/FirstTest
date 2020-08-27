using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Exercise5
    {
        public static void Show5Numbers(){

            // Solicite ao usuário que informe 5 números e armazene em um array.
            // Toda vez que o usuário digitar um valor inválido,
            // a aplicação deverá armazenas “null” no índice correspondente.
            // Ao final, imprimir apenas os números válidos.(1p)

            double?[] listOfNumbers = new double?[5];

            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                Console.WriteLine("Informe um número");
                try
                {
                    listOfNumbers[i] = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    listOfNumbers[i] = null;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < listOfNumbers.Length; i++)
            {
                if (listOfNumbers[i] != null)
                {
                    Console.WriteLine(listOfNumbers[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
