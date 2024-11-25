using System;
using static SuperCalculadora.executar;

namespace SuperCalculadora
{
    public class executar
    {
        public class calculadora
        {
            public string input;
            public decimal num1;
            public decimal num2;

            public void Divisao()
            {
                Console.WriteLine("\n=== DIVISÃO ===");
                Console.Write("Digite o primeiro número: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out num1))
                {
                    Console.WriteLine("Parece que você não digitou um número válido. A operação foi cancelada.");
                    return;
                }

                Console.Write("Agora, digite o segundo número: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out num2) || num2 == 0)
                {
                    Console.WriteLine("Não podemos dividir por zero ou o número não é válido. A operação foi cancelada.");
                    return;
                }

                Console.WriteLine($"O resultado de {num1} dividido por {num2} é: {num1 / num2}");
            }

            public void Subtrair()
            {
                Console.WriteLine("\n=== SUBTRAÇÃO ===");
                Console.Write("Digite o primeiro número: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out num1))
                {
                    Console.WriteLine("Parece que você não digitou um número válido. A operação foi cancelada.");
                    return;
                }

                Console.Write("Agora, digite o segundo número: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out num2))
                {
                    Console.WriteLine("Parece que você não digitou um número válido. A operação foi cancelada.");
                    return;
                }

                Console.WriteLine($"O resultado de {num1} menos {num2} é: {num1 - num2}");
            }

            public void Multiplicar()
            {
                Console.WriteLine("\n=== MULTIPLICAÇÃO ===");
                Console.Write("Digite o primeiro número: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out num1))
                {
                    Console.WriteLine("Parece que você não digitou um número válido. A operação foi cancelada.");
                    return;
                }

                Console.Write("Agora, digite o segundo número: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out num2))
                {
                    Console.WriteLine("Parece que você não digitou um número válido. A operação foi cancelada.");
                    return;
                }

                Console.WriteLine($"O resultado de {num1} multiplicado por {num2} é: {num1 * num2}");
            }

            public void Soma()
            {
                Console.WriteLine("\n=== SOMA ===");
                Console.Write("Digite o primeiro número: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out num1))
                {
                    Console.WriteLine("Parece que você não digitou um número válido. A operação foi cancelada.");
                    return;
                }

                Console.Write("Agora, digite o segundo número: ");
                input = Console.ReadLine();
                if (!decimal.TryParse(input, out num2))
                {
                    Console.WriteLine("Parece que você não digitou um número válido. A operação foi cancelada.");
                    return;
                }

                Console.WriteLine($"O resultado de {num1} mais {num2} é: {num1 + num2}");
            }
        }

        public static void Executor()
        {
            calculadora calculadora = new calculadora();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║         SUPER CALCULADORA          ║");
                Console.WriteLine("╠════════════════════════════════════╣");
                Console.WriteLine("║ 1. Somar                           ║");
                Console.WriteLine("║ 2. Subtrair                        ║");
                Console.WriteLine("║ 3. Multiplicar                     ║");
                Console.WriteLine("║ 4. Dividir                         ║");
                Console.WriteLine("║ 5. Sair                            ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        calculadora.Soma();
                        break;
                    case "2":
                        calculadora.Subtrair();
                        break;
                    case "3":
                        calculadora.Multiplicar();
                        break;
                    case "4":
                        calculadora.Divisao();
                        break;
                    case "5":
                        Console.WriteLine("Obrigado por usar a Super Calculadora! Até logo!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
