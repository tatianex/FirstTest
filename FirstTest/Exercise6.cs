using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Exercise6
    {
        public static void CalculateAverageWage()
        {
            // Calcule e apresente a média salarial dos funcionários de uma empresa qualquer.
            // A aplicação será encerrada quando o usuário digitar a palavra "calcular".
            //Caso o usuário digite um valor negativo então a aplicação deve pedir seu salário novamente. (1.5p)

            List<double> salaries = new List<double>();
            var input = "";

            while (true)
            {
                Console.WriteLine("Informe seu salário");
                input = Console.ReadLine();
                if (input != "calcular")
                {
                    try
                    {
                        var value = Double.Parse(input);
                        if (value > 0) salaries.Add(value);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Formato errado. Informe um valor positivo.");
                    }
                }
                else break; // Stop asking and calculate salaries.
            }

            var SumOfSalaries = 0.0d;

            foreach (var salary in salaries)
            {
                SumOfSalaries += salary;
            }

            var AverageSalary = SumOfSalaries / salaries.Count;

            Console.WriteLine(String.Format("A média salarial desta empresa é de: {0:C}", AverageSalary));

            Console.ReadLine();
        }
    }
}
