using System;
using System.Collections.Generic;

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    class Aluno
    {
        public string Nome { get; set; }
        public string RA { get; set; }
        public double NotaProva { get; set; }
        public double NotaTrabalho { get; set; }
        public int Faltas { get; set; }

        public double CalcularMedia()
        {
            return (NotaProva * 7 + NotaTrabalho * 3) / 10;
        }

        public double CalcularFrequencia()
        {
            return ((25 - Faltas) / 25.0) * 100;
        }

        public string Situacao()
        {
            double media = CalcularMedia();
            double frequencia = CalcularFrequencia();

            if (media >= 7 && frequencia >= 75)
                return "APROVADO";
            else
                return "REPROVADO";
        }
    }
}
