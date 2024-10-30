public class Program
{
    public static void Main(string[] args)
    {
        string operacao;
        //Recebe o 1° valor
        decimal a = Convert.ToDecimal(Console.ReadLine());
        string expressao = $"{a}";
        decimal respostaFinal = 0;

        do
        {
            //recebe a operação 
            operacao = Console.ReadLine();
            if (operacao == "=") break;

            //recebe o 2° valor
            decimal b = Convert.ToDecimal(Console.ReadLine());
            expressao += $" {operacao} {b}";

            //switch para ver a operação

            decimal resposta = 0;
            respostaFinal += resposta;
            Console.WriteLine(expressao);
        } while (operacao != "=");
        
    }
}
