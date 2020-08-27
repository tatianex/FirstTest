using System;
using System.Diagnostics;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = 0;
                Console.WriteLine("\nEste projeto contém 8 Exercícios. \nDigite um número para ver a solução. \nDigite 0 para sair.\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Exercise1.CalculateSalaryPerDay();
                        break;
                    case 2:
                        Exercise2.WordMaker();
                        break;                   
                    case 3:
                        Exercise3.CheckStatus();
                        break;
                    case 4:
                        Exercise4.CheckAge();
                        break;
                    case 5:
                        Exercise5.Show5Numbers();
                        break;
                    case 6:
                        Exercise6.CalculateAverageWage();
                        break;
                    case 7:
                        Exercise7.ShowState();
                        break;
                    case 8:
                        Exercise8.ShowFullTimeStudents();
                        break;
                    default:
                        break;
                }

                if (choice == 0) break;
            }
        }
    }
}
