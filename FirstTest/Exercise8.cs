using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Exercise8
    {
        public static void ShowFullTimeStudents()
        {
            // Solicite ao usuário que digite o nome dos alunos das turmas Matutino e Vespertino.
            // Cada turma possui 5 alunos. Armazene os nomes em dois arrays distintos de forma alternada,
            // ou seja, o primeiro nome deve ser armazenado no array da Matutino,
            // o segundo nome deve ser armazenado no array da Turma Vespertino, assim por diante.
            // Ao final imprima apenas os nomes dos alunos que estão estudando em período integral.
            // Caso nenhum aluno esteja cadastrado em ambas as turmas, imprimir a mensagem
            // “todos os alunos estudam em meio período”. (2p)

            var morningClass = new string[5];
            var afternoonClass = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o nome do aluno da classe matutina:");
                var morningStudent = Console.ReadLine();
                morningClass[i] = morningStudent;

                Console.WriteLine("Informe o nome do aluno da classe vespertina:");
                var afternoonStudent = Console.ReadLine();
                afternoonClass[i] = afternoonStudent;
            }

            for (int i = 0; i < 5; i++)
            {
                if (morningClass[i] == afternoonClass[i])
                {
                    Console.WriteLine(morningClass[i]);
                }
                else Console.WriteLine("todos os alunos estudam em meio período");
            }
            Console.ReadLine();
        }
    }
}
