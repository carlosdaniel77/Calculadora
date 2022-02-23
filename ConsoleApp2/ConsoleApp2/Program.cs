using System;


namespace Carlos
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiroNúmero;
            double segundoNúmero;
            double recebeSoma;
            double recebeSubtração;
            double recebeMultiplicação;
            double recebeDivisão;
            Console.WriteLine("Programa Calculadora\nDigite o primeiro número");
            primeiroNúmero = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            segundoNúmero = double.Parse(Console.ReadLine());

            recebeSoma = primeiroNúmero + segundoNúmero;
            recebeSubtração = primeiroNúmero - segundoNúmero;
            recebeMultiplicação = primeiroNúmero * segundoNúmero;
            recebeDivisão = primeiroNúmero / segundoNúmero;
            Console.WriteLine("A soma do resultado é : {0} ", recebeSoma);
            Console.WriteLine("A subtração do resultado é : {0} ", recebeSubtração);
            Console.WriteLine("A multiplicação do resultado é : {0} ", recebeMultiplicação);
            Console.WriteLine("A divisão do resultado é : {0} ", recebeDivisão);
        }
    }

}


