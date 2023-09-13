using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //EXERCÍCIO 01: Crie vetores/ arrays para armazenar:
        //    a) As vogais do alfabeto.
        //    b) As alturas de um grupo de dez pessoas.
        //    c) Os nomes dos meses do ano.

        string[] alfabeto = new string[5] { "a", "e", "i", "o", "u" };
        string[] alfabetoString = new string[] { "a", "e", "i", "o", "u" };
        char[] alfabetoVogais = new char[] { 'a', 'e', 'i', 'o', 'u' };

        //double[] altura = new double[3] { 1.81, 1.65, 1.74 };
        //altura = 1.81; 1.65; 1.74;

        // 0, 0, 0
        double[] altura = new double[3];
        foreach (var item in altura)
        {
            Console.WriteLine(item);
        }
        // 0, 0, 0, 1.81, 1.65, 1.74
        altura = altura.Concat(new double[3] { 1.81, 1.65, 1.74 }).ToArray();
        foreach (var item in altura)
        {
            Console.WriteLine(item);
        }
        // 0, 0 , 0, 1.81, 1.65, 1.74, 1.92
        altura = altura.Append(1.92).ToArray();
        foreach (var item in altura)
        {
            Console.WriteLine(item);
        }
        //0, 0 , 0, 1.81, 1.65, 1.74, 1.92

        //Console.WriteLine(altura.Length);

        //altura[0] = 1.81;
        //altura[1] = 1.65;
        //altura[2] = 1.74;

        //List<int> numeros = new List<int> { 1, 2, 3, 4, 5};
        //int[] numeros2 = numeros.ToArray();
        //var numerosPares = numeros.Where(numero => numero % 2 == 0).ToArray();

        ////int[,,] matriz3d = new int[3, 3, 3];
        ////int[,,,] matriz4d = new int[2, 2, 2, 2];

        //int[,] matriz = new int[2, 3];
        //matriz[0, 0] = 1;
        //matriz[0, 1] = 2;
        //matriz[0, 2] = 3;
        //matriz[1, 0] = 4;
        //matriz[1, 1] = 5;
        //matriz[1, 2] = 6;

        //int elemento = matriz[1, 1];
        //int linhas = matriz.GetLength(0);
        //int colunas = matriz.GetLength(1);
        //Console.WriteLine("O elemento é: " + elemento);
        //Console.WriteLine("O elemento é: " + linhas);
        //Console.WriteLine("O elemento é: " + colunas);

        //int[,,,] matriz4d = new int[2, 3, 4, 5];
        //2 * 3 * 4 * 5 = 120 

        //int[,,,] matriz4D = new int[3, 4, 2, 5]; // Uma matriz 3x4x2x5

        //int tamanhoDimensao1 = matriz4D.GetLength(0); // Obtém o tamanho da primeira dimensão (3)
        //int tamanhoDimensao2 = matriz4D.GetLength(1); // Obtém o tamanho da segunda dimensão (4)
        //int tamanhoDimensao3 = matriz4D.GetLength(2); // Obtém o tamanho da terceira dimensão (2)
        //int tamanhoDimensao4 = matriz4D.GetLength(3); // Obtém o tamanho da quarta dimensão (5)

        //Console.WriteLine(tamanhoDimensao1);
        //Console.WriteLine(tamanhoDimensao2);
        //Console.WriteLine(tamanhoDimensao3);
        //Console.WriteLine(tamanhoDimensao4);

        //Dictionary<int, Pessoa> pessoas = new Dictionary<int, Pessoa>();
        //pessoas[1] = new Pessoa { Nome = "Alice", Idade = 30 };
        //pessoas[2] = new Pessoa { Nome = "Bob", Idade = 25 };
        //pessoas[3] = new Pessoa { Nome = "Michael", Idade = 33 };
        //pessoas[4] = new Pessoa { Nome = "Dalton", Idade = 32 };

        //pessoas[1] = new Pessoa { Nome = "Alice", Idade = 30 };
        //pessoas[2] = new Pessoa { Nome = "Alice", Idade = 30 };

        //pessoas.Add(1, new Pessoa { Nome = "Paulo", Idade = 25 });
        //pessoas.Add(2, new Pessoa { Nome = "Paulo", Idade = 25 });
        //pessoas.Remove(1);

        //int pessoaProcurada = 1;
        //if (pessoas.ContainsKey(pessoaProcurada))
        //{
        //    Pessoa pessoa = pessoas[pessoaProcurada];
        //    pessoa.nomePesEncontrada(pessoas, pessoaProcurada);
        //    //SET
        //    pessoa.Nome = "João";
        //    //GET
        //    string nomePessoa = pessoa.Nome;

        //    Console.WriteLine(pessoa.Nome);
        //}
    }
}

//class Pessoa
//{
//    public string Nome { get; set; }
//    public int Idade { get; set; }

//    public string nomePesEncontrada(Dictionary<int, Pessoa> pessoas, int pessoa)
//    {
//        string nomePessoa = "";
//        return nomePessoa;
//    }
//}

