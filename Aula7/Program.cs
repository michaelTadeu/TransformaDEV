using System;

namespace ProgramaPrincipal
{
    class Program
    {
        static void Main()
        {
            //int[] numeros = new int[2] { 0, 0 };
            int[] numeros = new int[] { }; // Não sei o tamanho que ficará o meu array
            //int[] numerosZero = new int[0];
            string[] nomes = new string[2] { "Teste", "Teste" };
            string[] nomesT = new string[2] { "", "" };
            int soma = 0;
            int somaNumero = 0;
            int somaNumeroCont = 0;
            int contador = 0;
            int numero = 0;

            //Array.Resize(ref numerosZero, numerosZero.Length + 1);


            //do
            //{
            //    Console.WriteLine("Digite um número inteiro positivo (ou negativo para a soma): ");
            //    numero = int.Parse(Console.ReadLine());

            //    if (numero < 0)
            //    {
            //        break;
            //    }

            //    numeros[contador] = numero;
            //    contador++;

            //    //1° EXEC contador = 0; numero = 5; numeros[0] = 5
            //    //2° EXEC contador = 1; numero = 15; numeros[1] = 15
            //} while (true);


            while (true)
            {                
                try
                {
                    Console.WriteLine("Digite um número inteiro positivo (ou negativo para a soma): ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero < 0)
                    {
                        break;
                    }

                    //if (numero.GetType() != typeof(int) && numero > 0)
                    //{
                    //    throw new Exception("O valor informado não é um número inteiro");
                    //}

                    numeros[contador] = numero;
                    somaNumeroCont += numero;
                    contador++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite um número válido!!!");
                }

                //1° EXEC contador = 0; numero = 5; numeros[0] = 5
                //2° EXEC contador = 1; numero = 15; numeros[1] = 15
            }

            soma = numeros.Sum();
            
            foreach (var numeroSoma in numeros)
            {
                somaNumero += numeroSoma;
                //somaNumero = somaNumero + numeroSoma;
            }
            Console.WriteLine("A soma é: " + soma);
            Console.WriteLine("A soma é: " + somaNumero);
            Console.WriteLine("A soma é: " + somaNumeroCont);


            //List<int> numerosDigitados = new List<int>();

            //do
            //{
            //    if (int.TryParse(Console.ReadLine(), out numeroDigitado) && numeroDigitado > 0)
            //    {
            //        numerosDigitados.Add(numeroDigitado);
            //    }
            //} while (numeroDigitado > 0);



            //Faça um programa que leia 5 números e informe a soma e a média dos números.

            //int i = 5;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            // 1° EXEC -> i = 0 
            // 2° EXEC -> i = 1
            // 3° EXEC -> i = 2
            // 4° EXEC -> i = 3
            // 5° EXEC -> i = 4
            // 6° EXEC -> i = 5 Não entra no While

            //int j = 5;
            //do
            //{
            //    Console.WriteLine(j);
            //    j++;
            //} while (j < 5);

            // 1° EXEC -> j = 0 Imprime -> 0 Verifica -> 1 < 5
            // 2° EXEC -> j = 1 Imprime -> 1 Verifica -> 2 < 5
            // 3° EXEC -> j = 2 Imprime -> 2 Verifica -> 3 < 5
            // 4° EXEC -> j = 3 Imprime -> 3 Verifica -> 4 < 5
            // 5° EXEC -> j = 4 Imprime -> 4 Verifica -> 5 < 5
            // 6° EXEC -> j = 5 Imprime -> 5 Verifica -> 6 < 5


        }
    }
}
