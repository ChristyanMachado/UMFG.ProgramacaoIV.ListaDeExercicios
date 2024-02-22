

namespace UMFG.ProgramacaoIV.ListaDeExercicios.Exercicios
{
    internal class Calculadora
    {
        public void Calcular()
        {
            var escolha = -1;
            var valor1 = 0.0;
            var valor2 = 0.0;
            Console.WriteLine("Bem vindo a Calculadora!!\nque serve para... " +
                "calcular... quem diria hein...\n");
            do
            {

                Console.WriteLine("=================MENU================");
                Console.WriteLine("||1 - Soma                         ||");
                Console.WriteLine("||2 - Subtração                    ||");
                Console.WriteLine("||3 - Multiplicação                ||");
                Console.WriteLine("||4 - Divisão                      ||");
                Console.WriteLine("||5 - Resto da divisão             ||");
                Console.WriteLine("||0 - Sair                         ||");
                Console.WriteLine("=================MENU================");
                Console.Write("Valor:");

                int.TryParse(Console.ReadLine(), out escolha);

                Console.Clear();
                switch (escolha)
                {
                    case 1:
                        Console.Write("Somando...\nPrimeiro Valor:");
                        double.TryParse(Console.ReadLine(), out valor1);
                        Console.Clear();
                        Console.Write(valor1 + " + ");
                        double.TryParse(Console.ReadLine(), out valor2);
                        Console.Clear();
                        Console.Write(valor1 + " + " + valor2 + " = " + (valor1 + valor2));
                        break;
                    case 2:
                        Console.Write("Subtraindo...\nPrimeiro Valor:");
                        double.TryParse(Console.ReadLine(), out valor1);
                        Console.Clear();
                        Console.Write(valor1 + " - ");
                        double.TryParse(Console.ReadLine(), out valor2);
                        Console.Clear();
                        Console.Write(valor1 + " - " + valor2 + " = " + (valor1 - valor2));
                        break;
                    case 3:
                        Console.Write("Multiplicando...\nPrimeiro Valor:");
                        double.TryParse(Console.ReadLine(), out valor1);
                        Console.Clear();
                        Console.Write(valor1 + " * ");
                        double.TryParse(Console.ReadLine(), out valor2);
                        Console.Clear();
                        Console.Write(valor1 + " * " + valor2 + " = " + (valor1 * valor2));
                        break;
                    case 4:
                        Console.Write("Dividindo...\nPrimeiro Valor:");
                        double.TryParse(Console.ReadLine(), out valor1);
                        Console.Clear();
                        Console.Write(valor1 + " / ");
                        double.TryParse(Console.ReadLine(), out valor2);
                        Console.Clear();
                        Console.Write(valor1 + " / " + valor2 + " = " + (valor1 / valor2));
                        break;
                    case 5:
                        Console.Write("Resto Dividindo...\nValor:");
                        double.TryParse(Console.ReadLine(), out valor1);
                        Console.Clear();
                        Console.Write(valor1 + " mod = " + (valor1 % 2));
                        break;

                }
                if (escolha != 0)
                {
                    Console.Write("\n'-' press any button");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (escolha != 0);
        }
    }
}
