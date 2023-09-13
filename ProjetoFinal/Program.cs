using System;

class ForcaGame
{
    private string palavraChave;
    private char[] palavraAdivinhada;
    private int tentativasRestantes = 6; // Limite de tentativas

    public ForcaGame(string palavraChave)
    {
        this.palavraChave = palavraChave.ToLower(); // Converte a palavra-chave para minúsculas
        this.palavraAdivinhada = new char[palavraChave.Length];

        for (int i = 0; i < palavraChave.Length; i++)
        {
            if (char.IsLetter(palavraChave[i]))
            {
                this.palavraAdivinhada[i] = '_';
            }
            else
            {
                this.palavraAdivinhada[i] = palavraChave[i];
            }
        }
    }

    public bool JogoAcabou()
    {
        return tentativasRestantes <= 0 || this.palavraChave.Equals(new string(this.palavraAdivinhada));
    }

    public void TentarLetra(char letra)
    {
        letra = char.ToLower(letra); // Converte a letra para minúscula

        if (!char.IsLetter(letra))
        {
            Console.WriteLine("Por favor, digite uma letra válida.");
            return;
        }

        if (palavraChave.Contains(letra))
        {
            for (int i = 0; i < palavraChave.Length; i++)
            {
                if (palavraChave[i] == letra)
                {
                    palavraAdivinhada[i] = letra;
                }
            }
        }
        else
        {
            Console.WriteLine($"A letra '{letra}' não existe na palavra-chave.");
            tentativasRestantes--;
        }

        MostrarStatus();
    }

    public void MostrarStatus()
    {
        Console.WriteLine();
        Console.WriteLine("Palavra: " + new string(this.palavraAdivinhada));
        Console.WriteLine("Tentativas restantes: " + tentativasRestantes);
        Console.WriteLine();

        // Desenha o enforcado conforme as tentativas restantes
        switch (tentativasRestantes)
        {
            case 6:
                Console.WriteLine(" ____ ");
                Console.WriteLine("|    |");
                Console.WriteLine("|      ");
                Console.WriteLine("|      ");
                Console.WriteLine("|      ");
                Console.WriteLine("|      ");
                break;
            case 5:
                Console.WriteLine(" ____ ");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|      ");
                Console.WriteLine("|      ");
                Console.WriteLine("|      ");
                break;
            case 4:
                Console.WriteLine(" ____ ");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|    | ");
                Console.WriteLine("|      ");
                Console.WriteLine("|      ");
                break;
            case 3:
                Console.WriteLine(" ____ ");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /| ");
                Console.WriteLine("|      ");
                Console.WriteLine("|      ");
                break;
            case 2:
                Console.WriteLine(" ____ ");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|      ");
                Console.WriteLine("|      ");
                break;
            case 1:
                Console.WriteLine(" ____ ");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   /  ");
                Console.WriteLine("|      ");
                break;
            case 0:
                Console.WriteLine(" ____ ");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / \\");
                Console.WriteLine("|      ");
                Console.WriteLine("Você perdeu! A palavra-chave era: " + palavraChave);
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao jogo da forca!");
        Console.Write("Digite a palavra-chave: ");
        string palavraChave = Console.ReadLine();

        ForcaGame jogo = new ForcaGame(palavraChave);

        while (!jogo.JogoAcabou())
        {
            Console.Write("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine();

            jogo.TentarLetra(letra);
        }

        Console.WriteLine("O jogo acabou!");
    }
}
