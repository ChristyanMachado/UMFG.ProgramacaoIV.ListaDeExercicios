using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal class Menu
    {
        static List<Aluno> alunos = new List<Aluno>();
        public void TheMenu()
        {
            int opcao;
            do
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1 - Cadastro de Alunos");
                Console.WriteLine("2 - Cadastro de Notas");
                Console.WriteLine("3 - Cadastro Total de Faltas");
                Console.WriteLine("4 - Relação de Alunos, Notas, Média, Faltas e Situação");
                Console.WriteLine("0 - Sair");

                Console.Write("\nEscolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        CadastrarAluno();
                        break;
                    case 2:
                        CadastrarNotas();
                        break;
                    case 3:
                        CadastrarFaltas();
                        break;
                    case 4:
                        ListarAlunos();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }

        static void CadastrarAluno()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o RA do aluno: ");
            string ra = Console.ReadLine();

            alunos.Add(new Aluno { Nome = nome, RA = ra });
            Console.WriteLine("Aluno cadastrado com sucesso!");
        }

        static void CadastrarNotas()
        {
            Console.Write("Digite o RA do aluno: ");
            string ra = Console.ReadLine();

            Aluno aluno = alunos.Find(a => a.RA == ra);
            if (aluno != null)
            {
                Console.Write("Digite a nota da prova (0 a 10): ");
                aluno.NotaProva = double.Parse(Console.ReadLine());

                Console.Write("Digite a nota do trabalho (0 a 10): ");
                aluno.NotaTrabalho = double.Parse(Console.ReadLine());

                Console.WriteLine("Notas cadastradas com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }

        static void CadastrarFaltas()
        {
            Console.Write("Digite o RA do aluno: ");
            string ra = Console.ReadLine();

            Aluno aluno = alunos.Find(a => a.RA == ra);
            if (aluno != null)
            {
                Console.Write("Digite o total de faltas do aluno: ");
                aluno.Faltas = int.Parse(Console.ReadLine());

                Console.WriteLine("Faltas cadastradas com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }

        static void ListarAlunos()
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"\nNome: {aluno.Nome}");
                Console.WriteLine($"RA: {aluno.RA}");
                Console.WriteLine($"Nota da prova: {aluno.NotaProva}");
                Console.WriteLine($"Nota do trabalho: {aluno.NotaTrabalho}");
                Console.WriteLine($"Média: {aluno.CalcularMedia():F2}");
                Console.WriteLine($"Faltas: {aluno.Faltas}");
                Console.WriteLine($"Frequência: {aluno.CalcularFrequencia():F2}%");
                Console.WriteLine($"Situação: {aluno.Situacao()}");
            }
        }
    }
}

