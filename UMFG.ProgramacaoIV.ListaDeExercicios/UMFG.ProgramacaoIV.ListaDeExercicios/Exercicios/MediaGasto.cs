using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal class MediaGasto
    {
        public void CalculaGasto() {
            var distanciaTotal = 0.0;
            var combustivelGasto = 0.0;
            Console.Write("Bem-Vindo a Calculadora de Gasto de Combustivel/L!!\n" +
                "Qual foi a Distancia TOTAL percorrida?\n" +
                "Distância: ");
            double.TryParse(Console.ReadLine(), out distanciaTotal);
            Console.Write("\nE o Combustivel Gasto?\nCombustível: ");
            double.TryParse(Console.ReadLine(), out combustivelGasto);

            double mediaDeGasto = distanciaTotal / combustivelGasto;

           
            Console.WriteLine("A média de gasto do automóvel é de: " + mediaDeGasto.ToString("F2") + " km/l");
        }
        
    }
}
