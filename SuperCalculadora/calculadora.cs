using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("Digite um número para ser o dividendo da divisão");
                input = Console.ReadLine();
                if (decimal.TryParse(input, out num1))
                { }
                else 
                { 
                    Console.WriteLine("Você não digitou um número, então o cálculo será encerrado");
                    return;
                };
            
                Console.WriteLine("Digite um número para ser o divisor da divisão");
                input = Console.ReadLine();
                if (decimal.TryParse(input, out num2))
                { }
                else
                {
                    Console.WriteLine("Você não digitou um número, então o cálculo será encerrado");
                    return;
                };

                Console.WriteLine($"O resultado da divisão é: {num1/num2}");
            }
            public void Subtrair()
            {
                Console.WriteLine("Digite um número");
                input = Console.ReadLine();
                if (decimal.TryParse(input, out num1))
                { }
                else
                {
                    Console.WriteLine("Você não digitou um número, então o cálculo será encerrado");
                    return;
                };

                Console.WriteLine("Digite um número para Subtrair");
                input = Console.ReadLine();
                if (decimal.TryParse(input, out num2))
                { }
                else
                {
                    Console.WriteLine("Você não digitou um número, então o cálculo será encerrado");
                    return;
                };

                Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
            }
        }
        public static void Executor() 
        {
            var cal = new calculadora();
            cal.Divisao();
            cal.Subtrair();
        }
    }
}
