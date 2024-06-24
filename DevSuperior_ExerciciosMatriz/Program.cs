using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography;

namespace DevSuperior_ExerciciosMatriz {
    internal class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG     ";
            string vazia = "";
            string espaco = "   ";

            string s1 = original.ToUpper(); // Coloca todas as letras maiúsculas
            string s2 = original.ToLower(); // Coloca todas as letras minúsculas
            string s3 = original.Trim(); // Remove os espaços vazios no inicio e final da frase

            int n1 = original.IndexOf("bc"); // Retorna o número de indice do argumento bc
            int n2 = original.LastIndexOf("bc"); // Retorna o número do indice do ultimo encontro do argumento bc

            string s4 = original.Substring(3); // Retorna as strings apartir do indice 3
            string s5 = original.Substring(3, 5); // Retorna as string iniciando no indice 3, terminando no indice 5
            string s6 = original.Replace('a', 'x'); // Substitui as letras "A" pela letra "X"
            string s7 = original.Replace("abc", "XX"); // Substitui as letras conjuntas abc por XX

            bool b1 = string.IsNullOrEmpty(original); // Retorna verdadeiro ou falso se a string original esta vazia
            bool b2 = string.IsNullOrEmpty(vazia); // Verifica se a string está vazia
            bool b3 = string.IsNullOrWhiteSpace(espaco); // Considera vazio se tiver espaço em braco

            Console.WriteLine("String original -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("Substring: -" + s4 + "-");
            Console.WriteLine("Substring: -" + s5 + "-");

            Console.WriteLine("\nIdexOf: " + n1);
            Console.WriteLine("LastIndexOf: " + n2);

            Console.WriteLine($"\nReplace de A por X: -{s6}-");
            Console.WriteLine($"Replace de ABC por XX: -{s7}-");

            Console.WriteLine($"\nIsNullOrEmpty da variavel original: {b1}");
            Console.WriteLine($"IsNullOrEmpty da variavel vazia: {b2}");
            Console.WriteLine($"IsNullOrWhiteSpace da variavel espaco {b3}");

            Console.WriteLine($"Acesso por indice: {original[8]}");

            Console.WriteLine();

        }
    }
}
