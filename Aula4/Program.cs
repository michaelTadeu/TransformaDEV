using System;

class Program
{
    static void Main(string[] args)
    {

        //string[] args = {args1, args2, args3}

        //Exemplo de Veto/ Array
        //tipo[] nomeVetorArray;
        //int[] numeros; //{1,2,3,4,5}
        //int numeros; //1
        string[] nomes;
        double[] valoresProdutos;

        //int[] numeros = { 1, 2, 3, 4, 5};
                         // 0, 1, 2, 3, 4
        int[] numeros = new int[5];
        numeros[0] = 5;
        numeros[1] = 4;
        numeros[2] = 3;
        numeros[3] = 2;
        numeros[4] = 1;

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Array.Sort(numeros);
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }



        Pessoa[] pessoas =
        {
            new Pessoa { Nome = "Miguel", Idade = 25 },
            new Pessoa { Nome = "Vanessa", Idade = 23 },
            new Pessoa { Nome = "Andersor", Idade = 21 }
        };

        Array.Sort(pessoas, (p1, p2) => p1.Nome.CompareTo(p2.Nome));

        string[] nomesAlunos = { "Miguel", "Vanessa", "Andersor" };
        Array.Sort(nomesAlunos);

        var nomesOrdenados = nomesAlunos.OrderBy(nomeAluno => nomeAluno);


        //Exemplo Aritmética Conmputacional
        //Console.WriteLine(Calculadora.CalcularMedia());


        //double P = 0;
        //double E = 0;
        //double M = 0;

        //// Entrada de Dados:

        //Console.WriteLine("Digite o peso em quilogramas do seu peixe (somente números):");
        //P = double.Parse(Console.ReadLine());

        //// Processamento e Saída de Dados:
        //if (P == 0)
        //{
        //    Console.WriteLine("Peso inválido! Não há como fazer a pesagem do seu peixe.");
        //}
        //else if (P >= 50)
        //{
        //    E = (P - 50);
        //    Console.WriteLine("Limite excedente: 50kg");
        //    M = (E * 4);
        //    Console.WriteLine("O peso do seu peixe excede o limite, a sua multa é de: R$" + M);
        //}
        //else
        //{
        //    Console.WriteLine("O peso do peixe não excede o limite, a sua multa é de: R$" + M);
        //}
        //Console.ReadKey();

        //int idade = 0;

        //// Entrada de Dados:
        //Console.WriteLine("Bem vindo a classificação de nadadores!");
        //Console.WriteLine("As categorias são: Infantil A (5-7 anos), Infantil B (8-11 anos),");
        //Console.WriteLine("Juvenil A (12-13 anos), Juvenil B (14-17 anos) e Adultos (+18 anos).");
        //Console.WriteLine("Informe a idade do(a) nadador(a):");
        //idade = int.Parse(Console.ReadLine());

        //// Processamento e Saída de Dados:
        //if (idade >= 5 && idade <= 7)
        //{
        //    Console.WriteLine("O(A) nadador(a) se qualifica na categoria Infantil A!");
        //}
        //else if (idade >= 8 && idade <= 11)
        //{
        //    Console.WriteLine("O(A) nadador(a) se qualifica na categoria Infantil B!");
        //}
        //else if (idade >= 12 && idade <= 13)
        //{
        //    Console.WriteLine("O(A) nadador(a) se qualifica na categoria Juvenil A!");
        //}
        //else if (idade >= 14 && idade <= 17)
        //{
        //    Console.WriteLine("O(A) nadador(a) se qualifica na categoria Juvenil B!");
        //}
        //else if (idade >= 18)
        //{
        //    Console.WriteLine("O(A) nadador(a) se qualifica na categoria de Adultos!");
        //}
        //else
        //{
        //    Console.WriteLine("Desculpe, esta é uma idade muito jovem para participar da classificação :(");
        //}
        //Console.ReadKey();

        //DESAFIO 08:
        // Variáveis:
        //double prova1 = 0, prova2 = 0, prova3 = 0;
        //double exame_final = 0, nota_ex_final = 0;
        //double media = 0;

        //Entrada de Dados:
        //Console.WriteLine("Digite a nota da prova 1:");
        //prova1 = double.Parse(Console.ReadLine());
        //Console.WriteLine("\r\nDigite a nota da prova 2:");
        //prova2 = double.Parse(Console.ReadLine());
        //Console.WriteLine("\r\nDigite a nota da prova 3:");
        //prova3 = double.Parse(Console.ReadLine());

        //Processamento e Saída de Dados:
        //media = (prova1 + prova2 + prova3) / 3;

        //if (media >= 7)
        //{
        //    Console.WriteLine("\r\nA média do aluno foi de: " + media + "pts" + "\r\nO aluno foi APROVADO!");
        //}
        //else
        //{
        //    if (media <= 7)
        //    {
        //        Console.WriteLine("\r\nO aluno está de EXAME FINAL, a média do aluno foi de: " + media + "pts\r\n" + "\r\nCaso já feito o EXAME FINAL, informe a nota tirada pelo aluno:");
        //        nota_ex_final = double.Parse(Console.ReadLine());

        //        exame_final = (media + nota_ex_final) / 2;
        //    }
        //    if (exame_final >= 5)
        //    {
        //        Console.WriteLine("\r\nA média final do aluno foi de: " + exame_final + "pts" + "\r\nO aluno foi APROVADO!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\r\nA média final do aluno foi de: " + exame_final + "pts" + "\r\nO aluno foi REPROVADO!");
        //    }
        //}
        //Console.ReadKey();

        ////DESAFIO 10:
        //Console.WriteLine("Insira uma palavra:");
        //string palavra = Console.ReadLine().ToLower();

        //string palavraReversa = new string(palavra.Reverse().ToArray());

        //if (palavra == palavraReversa)
        //{
        //    Console.WriteLine("Você inseriu uma palavra palíndromo!");
        //}
        //else
        //{
        //    Console.WriteLine("Está palavra não é palíndromo!");
        //}
        //Console.WriteLine(palavra);
        //Console.WriteLine(palavraReversa); 


    }
}

    //public class Calculadora
    //{
    //    public static string CalcularMedia()
    //    {
    //        Console.Write("Entre com a quantidade atual em estoque do produto: ");
    //        int qntAtualEstoque = int.Parse(Console.ReadLine());
    //        Console.Write("Entre com a quantidade máxima em estoque do produto: ");
    //        int qntMaximaEstoque = int.Parse(Console.ReadLine());
    //        Console.Write("Entre com a quantidade mínima em estoque do produto: ");
    //        int qntMinimaEstoque = int.Parse(Console.ReadLine());
    //        double qntMedia = (qntMaximaEstoque + qntMinimaEstoque) / 2;
    //        return qntAtualEstoque >= qntMedia ? "Não efetuar compra" : "Efetuar compra";
    //    }
    //}


    //if (qntAtualEstoque >= qntMedia) {
    //    Console.Writline("Não efetuar compra")
    //} else
    //{
    //    Console.Writline("Efetuar compra")
    //}

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set;}
}

