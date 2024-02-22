using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal class Idade
    {
        public void idadeExplorer()
        {
            int anoAtual = DateTime.Now.Year;
            int data;
            Console.Write("Bem-Vindo ao Descobridor de Idades!!\nEm que ano você nasceu?\nAno: ");
            int.TryParse(Console.ReadLine(), out data);
            if (data>anoAtual)
            {
                Console.WriteLine("UM VIAJANTE DO TEMPO??!!!");
            }
            else
            {
                if (anoAtual - data>0 && anoAtual - data <2)
                {
                    Console.WriteLine("Entendi, então voce tem " + (anoAtual - data) + " Ano");
                }
                else
                {
                    Console.WriteLine("Entendi, então voce tem " + (anoAtual - data) + " Anos");
                }
                
            }
        }
    }
}
