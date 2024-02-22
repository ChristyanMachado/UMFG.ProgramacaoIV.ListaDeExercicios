namespace UMFG.ProgramacaoIV.ListaDeExercicios.Menu
{
    using UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios;
    internal class Program
    {
        static void Main(string[] args)
        {
            var operacao = 0;

            do
            {
                MercadoCambial mercado = new MercadoCambial();
                MediaGasto media = new MediaGasto();
                Idade idade = new Idade();
                Calculadora calculadora = new Calculadora();
                Vogalizador vogalizador = new Vogalizador();
                Consoantalizador consoantalizador = new Consoantalizador();
                FaixaCerta faixaCerta = new FaixaCerta();
                Biblioteca biblioteca = new Biblioteca();
                Menu menu = new Menu();

                Console.WriteLine("=================MENU================");
                Console.WriteLine("||1 - Mercado Cambial BRL -> USD   ||");
                Console.WriteLine("||2 - Mercado Cambial USD -> BRL   ||");
                Console.WriteLine("||3 - Calcule Combustivel Por Litro||");
                Console.WriteLine("||4 - Descubridor de Idades        ||");
                Console.WriteLine("||5 - Calculadora                  ||");
                Console.WriteLine("||6 - Vogalizador                  ||");
                Console.WriteLine("||7 - Consoantalizador             ||");
                Console.WriteLine("||8 - FaixaCerta                   ||");
                Console.WriteLine("||9 - Biblioteca                   ||");
                Console.WriteLine("||10 -             ||");
                Console.WriteLine("||0 - Sair                         ||");
                Console.WriteLine("=================MENU================");
                Console.Write("Valor:");
                int.TryParse(Console.ReadLine(), out operacao);
                Console.Clear();

                switch (operacao)
                {
                    case 1: mercado.Cambio(operacao); break;
                    case 2: mercado.Cambio(operacao); break;
                    case 3: media.CalculaGasto(); break;
                    case 4: idade.idadeExplorer(); break;
                    case 5: calculadora.Calcular(); break;
                    case 6: vogalizador.Vogalizar(); break;
                    case 7: consoantalizador.Consoantalizar(); break;
                    case 8: faixaCerta.DescobrirFaixa(); break;
                    case 9: biblioteca.Cadastrar(); break;
                    case 10: menu.TheMenu(); break;

                };
                if (operacao!=0)
                {
                    Console.Write("\n'-' press any button");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            } while (operacao != 0);
        }
    }
}