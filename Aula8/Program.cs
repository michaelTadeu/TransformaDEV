using System;

namespace ProgramaPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Input[] array = [{ "nome":Maria, "nota":7, "faltas":30}];
            Solution.Avaliacao(array);
        }
    }
    public class Solution
    {
        public static string Avaliacao(Input[] input)
        {
            string resultado = "";

            foreach (Input aluno in input)
            {
                decimal media = aluno.nota;
                int faltas = aluno.faltas;

                // Calcula a porcentagem de presença
                decimal presenca = ((60 - faltas) / 60.0m) * 100;

                if (media > 7.0m && presenca > 60)
                {
                    resultado += aluno.name + " está aprovado\n";
                }
                else
                {
                    resultado += aluno.name + " está reprovado\n";
                }
            }
            return resultado;
        }
    }

    public class Input
    {
        public string name;
        public decimal nota;
        public int faltas;
    }

}
