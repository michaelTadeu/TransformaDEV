//using System;

//namespace ProgramaPrincipal
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Exercício 01:
//            int tamanho = 10;

//            double[] A = new double[tamanho];
//            double[] B = new double[tamanho];
//            double[] C = new double[tamanho];

//            // I) Preenchendo os vetores/arrays A e B
//            Console.Write("\r\n ┌─────────────────────────────────────┐");
//            Console.Write("\r\n │ Soma de 10 valores em ordem reversa │");
//            Console.Write("\r\n └─────────────────────────────────────┘\r\n");
//            Console.WriteLine("");

//            for (int i = 0; i < tamanho; i++)
//            {
//                Console.Write(" Digite o valor para A" + (i + 1) + ": ");
//                A[i] = Convert.ToDouble(Console.ReadLine());

//                Console.Write(" Digite o valor para B" + (i + 1) + ": ");
//                B[i] = Convert.ToDouble(Console.ReadLine());
//            }

//            // II) Criando o vetor/array C com as somas
//            for (int i = 0; i < tamanho; i++)
//            {
//                C[i] = A[i] + B[tamanho - i - 1];
//            }

//            // III) Imprimindo os vetores/arrays A, B e C
//            Console.WriteLine("\r\n -----------------------------------------");

//            Console.Write("\r\n ┌────────────┐");
//            Console.Write("\r\n │ Resultados │");
//            Console.Write("\r\n └────────────┘\r\n");

//            Console.WriteLine(" \r\n Valores A (inseridos): " + string.Join(", ", A));
//            Console.WriteLine(" Valor B (inseridos): " + string.Join(", ", B));
//            Console.WriteLine(" Valor C (somas): " + string.Join(", ", C));

//            Console.WriteLine("");
//            Console.WriteLine("\r\n Pressione ENTER para finalizar.");
//            Console.WriteLine("\r\n -----------------------------------------");

//            Console.ReadKey();

//            //EXERCÍCIO 02
//            // Variáveis:
//            int num = 0, soma = 0, menor = 0;
//            double media = 0;

//            // Entrada, Processamento e Saída de Dados:

//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Digite 10 numeros inteiros: ");
//                num = int.Parse(Console.ReadLine());
//                Console.WriteLine("");

//                if (menor == 0)
//                {
//                    menor = num;
//                }
//                else
//                {
//                    if (menor > num)
//                    {
//                        menor = num;
//                    }
//                }
//                soma = soma + num;
//                media = soma / 10;
//            }
//            Console.Write("\r\n ┌─────────────┐");
//            Console.Write("\r\n │ Resultados: │");
//            Console.Write("\r\n └─────────────┘\r\n");
//            Console.WriteLine("\r\nMédia dos Números: " + media);
//            Console.WriteLine("Soma dos Números: " + soma);
//            Console.WriteLine("Menor Número: " + menor);

//            Console.ReadKey();

//            // EXERCÍCIO 03
//            // Variáveis:
//            int soma = 0;

//            // Entrada, Processamento e Saída de Dados:

//            for (int i = 0; i <= 100; i++)
//            {
//                soma = soma + i;
//            }

//            Console.Write("\r\n ┌──────────────────────────────────────────────┐");
//            Console.Write("\r\n │ Some os números de 1 a 100 a imprima o valor │");
//            Console.Write("\r\n └──────────────────────────────────────────────┘\r\n");
//            Console.WriteLine("\r\nA soma dos números de 1 a 100, é: " + soma);

//            Console.ReadKey();

//            // EXERCÍCIO 04
//            // Variáveis:
//            int quantidade = 0, soma = 0, num = 0, num_par = 0;

//            // Entrada, Processamento e Saída de Dados:

//            do
//            {
//                Console.WriteLine("Digite um número (Digite 0 (zero) quando quiser parar): ");
//                num = int.Parse(Console.ReadLine());
//                Console.WriteLine("");

//                quantidade++;
//                soma = soma + num;

//                if (num % 2 == 0 && num != 0)
//                {
//                    num_par++;
//                }

//            } while (num != 0);

//            Console.Write("\r\n ┌─────────────┐");
//            Console.Write("\r\n │ Resultados: │");
//            Console.Write("\r\n └─────────────┘\r\n");
//            Console.WriteLine("\r\nA quantidade de números lidos é: " + quantidade);
//            Console.WriteLine("A soma dos números lidos é: " + soma);
//            Console.WriteLine("A quantidade de números pares é: " + num_par);

//            Console.ReadKey();

//            //Escreva um programa em C# que solicite ao usuário que insira um número
//            //inteiro positivo. O programa deve então exibir todos os números pares
//            //de 2 até o número inserido pelo usuário.

//            //7 = 2, 4, 6

//            //Console.WriteLine("Digite um númeo inteiro positivo: ");
//            //int numeroInserido = int.Parse(Console.ReadLine());

//            //if (numeroInserido >= 2)
//            //{
//            //    Console.WriteLine("Números pares de 2 até " + numeroInserido + ":");
//            //    for (int i = 2; i <= numeroInserido; i+=2)
//            //    {
//            //        Console.WriteLine(i);
//            //    }
//            //} else if (numeroInserido < 2)
//            //{
//            //    Console.WriteLine("O número inserido não é maior ou igual a 2");
//            //} else
//            //{
//            //    Console.WriteLine("Entrada inválida");
//            //}

//            //{
//            //    int numero = 0;

//            //    while (true)
//            //    {
//            //        try
//            //        {

//            //            Console.WriteLine("Digite um número inteiro positivo: ");
//            //            numero = int.Parse(Console.ReadLine());

//            //            if (numero < 0)
//            //            {
//            //                throw new ArithmeticException();
//            //            }

//            //            for (int i = 0; i < numero; i++)
//            //            {
//            //                if (i % 2 == 0)
//            //                {
//            //                    Console.WriteLine(i);
//            //                }
//            //            }
//            //            return 0;
//            //        }
//            //        catch (CaractereInvalidoException ex)
//            //        {
//            //            Console.WriteLine("Não aceitamos caracteres como @, #, $...!\n");
//            //        }
//            //        catch (FormatException ex)
//            //        {
//            //            Console.WriteLine("Insira um valor inteiro positivo!\n");
//            //        }
//            //        catch (ArithmeticException ex)
//            //        {
//            //            Console.WriteLine("O número deve ser positivo!\n");
//            //        }
//            //        catch (Exception ex)
//            //        {
//            //            Console.WriteLine("Exception nova\n");
//            //        }
//            //    }


//            //}

//            //try
//            //{
//            //    string input = Console.ReadLine();

//            //    // Verifica se a string contém o caractere "@".
//            //    if (input.Contains("@"))
//            //    {
//            //        throw new CaractereInvalidoException("O caractere '@' não é permitido nesta entrada.");
//            //    }

//            //    Console.WriteLine("Entrada válida: " + input);
//            //}
//            //catch (CaractereInvalidoException ex)
//            //{
//            //    Console.WriteLine("Exceção: " + ex.Message);
//            //}
//            //catch (Exception ex)
//            //{
//            //    Console.WriteLine("Exceção não tratada: " + ex.Message);
//            //}



//            //int[,] matrizNumeros = {
//            //    { 1, 2},
//            //    { 3, 4 }
//            //};
//            //foreach (int numero in matrizNumeros)
//            //{
//            //    int numeroSomado = numero + 1;
//            //    Console.WriteLine($"O elemento é: {numero} e o somado é: {numeroSomado}");
//            //}

//            //foreach (int item in matrizNumeros)
//            //{

//            //}

//            //int linhas = matriz.GetLength(0);
//            //int colunas = matriz.GetLength(1);

//            //for (int i = 0; i < linhas; i++)
//            //{
//            //    for (int j = 0; j < colunas; j++)
//            //    {
//            //        int elemento = matriz[i, j];
//            //        Console.WriteLine($"Elemento na posição [{i}, {j}] {elemento}");
//            //    }
//            //}

//            //try
//            //{
//            //    int x = 10;
//            //    int y = 0;
//            //    int resultado = x / y;
//            //    Console.WriteLine(resultado);
//            //}
//            //catch (DivideByZeroException ex)
//            //{

//            //    Console.WriteLine($"Exception {ex}");
//            //}
//        }
//    }
//}

//public class CaractereInvalidoException : Exception
//{
//    public CaractereInvalidoException() { }

//    public CaractereInvalidoException(string message) : base(message) { }

//    public CaractereInvalidoException(string message, Exception innerException) : base(message, innerException) { }
//}
