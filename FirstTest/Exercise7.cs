using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Exercise7
    {
        public static void ShowState()
        {
            // Pergunte para 5 usuários a UF que representa o estado onde ele nasceu. 
            // A aplicação deverá mostrar uma lista com todas as opções para o usuário, e 
            // cada uma deve conter um ID numérico, o usuário digitará o número que representa sua UF. 
            // Ao final a aplicação deverá mostrar a porcentagem de usuários que nasceram em Santa Catarina. (1.5p)

            var residentsInSC = 0;

            var states = new string[27, 2] {

                { "Acre", "1" },
                { "Alagoas", "2" },
                { "Amapá", "3" },
                { "Amazonas", "4"},
                { "Bahia", "5" },
                { "Ceará", "6" },
                { "Distrito Federal", "7" },
                { "Espírito Santo", "8" },
                { "Goiás", "9" },
                { "Maranhão", "10" },
                { "Mato Grosso", "11" },
                { "Mato Grosso do Sul", "12" },
                { "Minas Gerais", "13" },
                { "Pará", "14" },
                { "Paraíba", "15" },
                { "Paraná", "16" },
                { "Pernambuco", "17" },
                { "Piauí", "18" },
                { "Rio de Janeiro", "19" },
                { "Rio Grande do Norte", "20" },
                { "Rio Grande do Sul", "21" },
                { "Rondônia", "22" },
                { "Roraima", "23" },
                { "Santa Catarina", "24"},
                { "São Paulo", "25" },
                { "Sergipe", "26" },
                { "Tocantins", "27" }
            };

            const int totalRespondents = 5;

            for (int i = 0; i < totalRespondents; i++)
            {
                Console.WriteLine("Informe o número correspondente ao estado que você nasceu de acordo com a tabela abaixo:");
                for (int j = 0; j < 27; j++)
                {
                    Console.WriteLine($"{states[j,1]} - {states[j,0]}");
                }
                var answer = Console.ReadLine();
                if (answer == "24") residentsInSC++;
            }

            double percentageResidentsInSC = 0.0d;
            percentageResidentsInSC = ((residentsInSC * 100) / totalRespondents);

            Console.WriteLine($"A porcentagem de residentes em SC é de: {percentageResidentsInSC}");
        }
    }
}
