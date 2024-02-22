

using System.Xml;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal class MercadoCambial
    {

        public void Cambio(int choose)
        {
            var response = 0.0;
            var valorUSD = 0.0;
            var valorBRL = 0.0;
            Console.Write("Bem-Vindo ao Mercado Cambial!!\n");


            if (choose == 2)
            {
                Console.Write("Valor USD:");
                double.TryParse(Console.ReadLine(), out response);
                valorUSD = response / 0.193259;
                Console.WriteLine("\nValor Cambial USD -> BRL\nBRL:" + valorUSD.ToString("F2"));
            }
            else if (choose == 1)
            {
                Console.Write("Valor BRL:");
                double.TryParse(Console.ReadLine(), out response);
                valorBRL = response * 0.193259;

                Console.WriteLine("\nValor Cambial BRL -> USD\nUSD:" + valorBRL.ToString("F2"));
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Valor Inválido!!!!!\n");
            }


        }

    }
}
