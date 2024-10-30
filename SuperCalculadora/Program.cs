class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double resultado = Multiplicar(numero1, numero2);
        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }
}