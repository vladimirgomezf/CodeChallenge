using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre una frase: ");
            var frase = Console.ReadLine();

            Char[] temp = frase.Trim().ToCharArray();
            Array.Sort(temp);
            var tempo = new String(temp).Trim();

            String final = "";
            int j = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (String.Equals(frase[i].ToString()," "))
                {
                    final = final + " ";
                }else
                {
                    final = final + tempo[j++].ToString();
                }
            }

            Console.WriteLine(final);
        }
    }
}