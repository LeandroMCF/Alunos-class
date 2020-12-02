using System;
using Alunos_class.classes;

namespace Alunos_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos aluno = new Alunos();
            Console.Write("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();
            while (aluno.nome == "")
            {
                Console.WriteLine($"Você não digitou o nome do aluno.\nDigite o nome do aluno: ");
                aluno.nome = Console.ReadLine();
            }

            Console.Write($"Digite o Curso do aluno: ");
            aluno.curso = Console.ReadLine();
            while (aluno.curso == "")
            {
                Console.WriteLine($"Você não digitou o curso do aluno.\nDigite o curso do aluno: ");
                aluno.curso = Console.ReadLine();
            }

            Console.Write($"Digite o RG do Aluno: ");
            aluno.rg = Console.ReadLine();
            while (aluno.rg == "")
            {
                Console.WriteLine($"Você não digitou o RG do aluno.\nDigite o RG do aluno: ");
                aluno.rg = Console.ReadLine();
            }

            Console.Write($"Digite a idade do aluno: ");
            aluno.idade = int.Parse(Console.ReadLine());
            while (aluno.idade <= 5)
            {
                Console.WriteLine($"Idade inválida\nDigite novamente a idade do aluno: ");
                aluno.idade = int.Parse(Console.ReadLine());
            }
            
            Console.Write($"Digite a média final do aluno: ");
            aluno.mediaFinal = float.Parse(Console.ReadLine());
            while (aluno.mediaFinal < 0)
            {
                Console.WriteLine($"Média inválida\nDigite a média do aluno novamente: ");
                aluno.mediaFinal = float.Parse(Console.ReadLine());
            }
            
            Console.Write($"Digite o valor da mensalidade do aluno: ");
            aluno.valorMensalidade = float.Parse(Console.ReadLine());
            while (aluno.valorMensalidade <= 0)
            {
                Console.WriteLine($"Você não digitou um valor inválido.\nDigite a mensalidade do aluno novamente: ");
                aluno.valorMensalidade = float.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"Digite se o aluno é bolsista s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                aluno.bolsista = true;
            }
            else
            {
                aluno.bolsista = false;
            }
            int ops = 0;
            do
            {
                Console.WriteLine($"Selecione uma opção\n[1] ver média de aluno\n[2] Vr mensalidade do aluno\n[0] Sair");
                ops = int.Parse(Console.ReadLine());
                while (ops != 1 && ops != 2 && ops != 3)
                {
                    Console.WriteLine($"Opção inválida.\nSelecione uma opção\n[1] ver média de aluno\n[2] Vr mensalidade do aluno\n[0] Sair");
                    
                }
                switch (ops)
                {
                    case 1:
                        Console.WriteLine($"A média final do aluno {aluno.nome} = {aluno.verMediaAluno()}");
                    break;

                    case 2:
                        Console.WriteLine($"O valor da mensalidade do aluno {aluno.nome} fiva em {aluno.verMensalidade()}");
                    break;

                    default:
                        Console.WriteLine($"Ok, Tchau");
                    break;
                }
                
                
            } while (ops != 0);
        }
    }
}