using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Exercise3
    {
        public static void CheckStatus()
        {
            // Solicite para 5 usuários que informem seus nomes e se são solteiros.
            // Ao final apresente o nome de todos os usuários solteiros. (1p)

            var littleContacts = new string[5];

            for (int i = 0; i < littleContacts.Length; i++)
            {
                Console.WriteLine("Informe seu nome");
                var name = Console.ReadLine();
                Console.WriteLine("Você é solteiro, sim ou não?");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "sim") {
                    littleContacts[i] = name;
                }
            }

            Console.WriteLine("");

            foreach (var name in littleContacts) Console.WriteLine(name);

            Console.ReadLine();

        }
    }
}
