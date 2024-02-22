using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal class FaixaCerta
    {public void DescobrirFaixa()
        {
            Console.WriteLine("FaixaCerta: Descobrindo a Sua!");
            int anoAtual = DateTime.Now.Year;
            int data;
            Console.Write("Em que ano você nasceu?\nAno: ");
            int.TryParse(Console.ReadLine(), out data);
            if (data > anoAtual)
            {
                Console.WriteLine("ALÔ POLICIA FEDERAL?!?! TEMOS UM VIAJANTE DO TEMPO AQUI!!!  DENOVO!!");
            }
            else
            {
                if (anoAtual - data > 0 && anoAtual - data < 2)
                {
                    Console.WriteLine("Entendi, então voce tem " + (anoAtual - data) + " Ano, logo apenas um Jovem");
                }
                else if (anoAtual - data > 1 && anoAtual - data <= 19)
                                {
                    Console.WriteLine("Entendi, então voce tem " + (anoAtual - data) + " Anos, logo apenas um Jovem");
                }
                else if (anoAtual - data >= 20 && anoAtual - data <= 59)
                {
                    Console.WriteLine("Entendi, então voce tem " + (anoAtual - data) + " Anos, já uma pessoa Adulta, Que a vida continue cheia de aventuras!");
                }
                else if (anoAtual - data >= 60 && anoAtual - data <= 99)
                {
                    Console.WriteLine("Entendi, então voce tem " + (anoAtual - data) + " Anos, agora um Sábio Idoso, ou talvez só um idoso"); 
                }
                else if (anoAtual - data >= 100 && anoAtual - data <= 199)
                {
                    Console.WriteLine("Entendi, então voce tem " + (anoAtual - data) + " Anos, agora um Fossil... vivo?");
                }
                else if (anoAtual - data >= 200)
                {
                    Console.Clear();
                    Console.WriteLine("Entendi, então voce tem " + (anoAtual - data) + "anos??, WTF??\n" +
                        "                                        ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  \n" +
                        "                                  ▒▒▒▒░░████████████████████████░░▒▒░░\n" +
                        "                              ▒▒▒▒▓▓▓▓▓▓████████████████████████▓▓▓▓██▒ ▒░░\n" +
                        "                            ▒▒███████████████████████████████████████ █████▒▒\n" +
                        "                          ▒▒███████████████████████████████████████ █████████ ▒▒\n" +
                        "                        ▒▒███████████████████████████████████████ █████████ ████▒▒\n" +
                        "                      ▒▒███████████████████████████████████████ █████████ ████████▒▒ \n" +
                        "                      ▒▒███████████████████████████████████████ █████████ ████████▒▒ \n" +
                        "                    ▒▒▓▓█████████████████████████████████████ █████████ ████████████▒▒\n" +
                        "                    ▒▒███████████████████████████████████████ █████████ ████████████▒▒\n" +
                        "                    ▒▒██████████████████████████████████████▒ ▒▒▒▒▒▒▒▒▒ ▒▒██████████▒▒\n" +
                        "                    ▒▒████████████████▒▒▒▒▒▒▒▒████████████▒▒▒ ▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒██████▒▒\n" +
                        "                    ▒▒████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████████████▒▒▒ ▒░░░░░░░░ ▒▒▒▒▒▒▒▒████▒▒\n" +
                        "                    ▒▒████▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒████████████▒▒▒ ▒░░▓▓▓▓░░ ▒▒▒▒▒▒▒▒████▒▒\n" +
                        "                    ▒▒████▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒████████████▒▒▒ ▒░░▓▓▓▓░░ ▒▒▒▒▒▒▒▒████▒▒\n" +
                        "                    ░░▓▓████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████▓▓▓▓████▓▓▒ ▒░░▒▒▒▒░░ ▒▒▒▒▒▒████▓▓░░\n" +
                        "                      ▒▒██████▒▒▒▒▒▒▒▒▒▒▒▒▒▒██████▒▒▒▒██████▒▒▒ ▒▒▒▒▒▒▒▒▒ ▒▒▒▒████▒▒\n" +
                        "                        ▒▒████▒▒▒▒██▒▒▒▒▒▒██████▒▒▒▒▒▒▒▒██████▒▒█ █▒▒▒▒██▒▒ ▒▒██▒▒\n" +
                        "                        ▒▒████▒▒▒▒██▒▒▒▒████████▒▒▒▒▒▒▒▒████████▒ ▒▒▒▒▒██▒▒ ▒▒██▒▒\n" +
                        "                      ▒▒██████▒▒▒▒██▒▒▒▒████████▒▒▒▒▒▒▒▒███████ ███▒▒▒▒▒▒ ▒▒▒▒████▒▒\n" +
                        "                      ▒▒██████▒▒▒▒▓▓▒▒▒▒███████████████████████ ███▒▒▒▒▒▒ ▒▒▒▒████▒▒\n" +
                        "                      ▒▒████▒▒▒▒▒▒▒▒▒▒▒▒███████████████████████ ███▒▒▒▒▒▒ ▒▒▒▒████▒▒\n" +
                        "                      ▒▒██████▒▒▒▒░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ▒▒▒░░▒▒▒▒ ▒▒▒▒████▒▒\n" +
                        "                  ▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒░░░░░░▒▒░░░░▒▒░░░░░░▒ ▒░░░░▒▒░░ ▒▒██▒▒▒▒██▒▒▒▒▒▒▒▒▒▒\n" +
                        "                ▒▒▓▓▓▓▓▓▒▒████▒▒▒▒██▒▒▒▒░░░░▒▒░░░░▒▒░░░░░ ░▒▒░░░░▒▒ ▒▒▒▒██▒▒▒▒██▒▒▓▓▓▓▓▓▓▓▒▒\n" +
                        "              ▒▒▓▓▓▓▓▓▓▓▓▓▒▒██▒▒▒▒██▒▒▒▒▒▒▒▒▒▒░░░░▒▒░░░ ░░░▒▒░░▒▒ ▒▒▒▒▒▒██▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒\n" +
                        "            ▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒██▒▒▒▒████▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒ ████▒▒▒▒██▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒\n" +
                        "            ▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒██▒▒▒▒█████████████ █████████ ████▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓████▒▒▒▒\n" +
                        "            ▒▒██████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒█████████████ █████████ ▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓██████▒▒▒▒\n " +
                        "          ▒▒██████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒███ ███▒▒▒▒▒▒ ▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████▒▒\n" +
                        "        ▒▒██████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▒▒▒ ▒▒▒▒▒▒▒▓▓ ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████████▒▒\n" +
                        "          ▒▒████████████████████▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓▓▓▓ ▓▓▓▓▓▒▒░░ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████████████▒▒\n ");
                }

            }
        }
    }
}
