using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Exercise1
    {

        // Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia
        // e qual o valor/hora de seu serviço.
        // Imprima quanto dinheiro ele ganha ao longo de um dia trabalhado.
        // A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula. (1p)
        public static void CalculateSalaryPerDay()
        {
            double hoursWorked = 0;
            double amountReceivedPerHour = 0.0d;
            double amountReceivedPerDay = 0.0d;
            
            while (true)
            {
                Console.WriteLine("Informe quantas horas e minutos você trabalha por dia (para oito horas e meia informar = 8,5)");
                try
                {
                    hoursWorked = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Informe um número");
                }
            }

            while (true)
            {
                Console.WriteLine("Informe qual o valor você recebe por hora de serviço?");
                try
                {
                    amountReceivedPerHour = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Informe um número");
                }
            }

            amountReceivedPerDay = hoursWorked * amountReceivedPerHour;

            Console.WriteLine(String.Format("Ao longo de um dia de trabalho você recebeu: {0:C}", amountReceivedPerDay));
            Console.ReadLine(); 
        }      
    }
}
