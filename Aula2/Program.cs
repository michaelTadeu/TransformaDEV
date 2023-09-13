using System;

namespace TipoDadosVariaveis
{
    class Program
    {
        static void Main()
        {
            //double saldo = 100.0;
            //double valorDoSaque = 10.0;
            //double valorDoDeposito = 150.0;
            //double valorDeBonus = 2.0;
            //double valorDeDesconto = 30.0;
            ////saldo = saldo - valorDoSaque;
            //saldo -= valorDoSaque;
            //saldo += valorDoDeposito;
            //saldo *= valorDeBonus;
            //saldo /= valorDeDesconto;
            //Console.WriteLine(saldo);

            //int valor = 1;
            //short valorPequeno = (short) valor;
            //Console.WriteLine(valorPequeno);

            //int idadeAluno = 25;
            //string mensagem = "Sua idade é: " + " /" + idadeAluno + "anos de idade";
            //Console.WriteLine(mensagem);

            //string idade = "25";
            //int valorIdade = int.Parse(idade);
            //string valorIdades = idade + 12;
            //int valorIdadesInt = valorIdade + 12;
            //Console.WriteLine(valorIdades);
            //Console.WriteLine(valorIdadesInt);

            //Exercício de Temperatura
            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            int constanteNove = 9;
            int constanteCinco = 5;

            //F = C * 9/5 + 32
            double fahrenheit = celsius * constanteNove / constanteCinco + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}°F");
 
        }
    }

}