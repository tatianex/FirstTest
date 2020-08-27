using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Exercise4
    {
        public static void CheckAge()
        {
            //Solicite ao usuário seu ano de nascimento e imprima se ele é ou não maior de idade.
            //Caso o usuário digite um valor inválido, a aplicação deve pedir que ele digite novamente. (1p)

            var yearOfBirth = 0;

            while (true)
            {
                Console.WriteLine("Informe seu ano de nascimento");
                try
                {
                    yearOfBirth = Int32.Parse(Console.ReadLine());
                    if ((DateTime.Now.Year - yearOfBirth) > 18) Console.WriteLine("Maior de idade");
                    else Console.WriteLine("Não é maior de idade");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Informe um ano");
                }
            }

            Console.ReadLine();
        }
    }
}
