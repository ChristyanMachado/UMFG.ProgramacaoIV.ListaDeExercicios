using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal class Consoantalizador
    {
        public void Consoantalizar()
        {
            string nome;
            Console.Write("Bem-Vindo ao Consoantalizador!!\nPor Obzequio qual o nome de vossa graça?\n\n");
            Console.Write("Me chamo ");
            nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Bem-Vindo ao Consoantalizador!!\nPor Obzequio qual o nome de vossa graça?\n\n");
            Console.Write("Me chamo "+nome+" e acho que ja vi isso antes... falta de criatividade");
            Console.WriteLine("...\n bem... prossigamos");
            int x = 0;
            foreach (char c in nome.ToLower())
            {
                if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
                {
                    x++;
                }
            }
            Console.Write("\nUAU MAS QUE INTRIGANTE SEU NOME POSSUI " + x + " CONSOANTES!!! " + nome + "! " +
                "MEU DEUS, QUE LEGAL UHUU!!! (¬_¬ )");

        }
    }
}
