using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal class Vogalizador
    { public void Vogalizar()
        {
            string nome;
            Console.Write("Bem-Vindo ao Vogalizador!!\nPor Obzequio qual o nome de vossa graça?\n\nMe chamo ");
            nome = Console.ReadLine();
            int x = 0;
            foreach (char c in nome.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    x++;
                }
            }
            Console.Write("\nIntrigante seu nome possui "+ x +" Vogais, "+nome+"! " +
                "Mas é claro que voce não sabia haha, que legal!");

        }
    }
}
