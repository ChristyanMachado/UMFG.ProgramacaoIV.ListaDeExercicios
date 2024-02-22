using System;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal struct Livro
    {
        public string Titulo;
        public string Autor;
        public double Valor;

        public override string ToString()
        {
            return $"Título: {Titulo}\nAutor: {Autor}\nValor: R$ {Valor:F2}\n";
        }
    }

    internal class Biblioteca
    {
        public void Cadastrar() 
        {
            Console.WriteLine("Olá Visitante, seja Bem-Vindo a *BiBlioteca*, vejo que carrega um livro..." +
                "\n" +
                "ele parece interessante, o que acha de o expor?\n" +
                "Qual o título do livro?");
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("\nE quanto ao autor do livro?\nAutor: ");
            string autor = Console.ReadLine();

            Console.Write("\nE o valor do livro?\nValor: ");
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor)|| valor <0)
            {
                Console.WriteLine("esse valor não parece factivel... tente denovo...");
            }
 
            Livro livro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Valor = valor
            };

            Console.WriteLine("\nInformações do livro cadastradas, Obrigado!");
            Console.WriteLine(livro.ToString());
        }
    }
}
