using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int num, x, last, qst;
            string sentence;

            Console.WriteLine("Choise Question number :");
            Console.WriteLine("1. Biggest Factor ");
            Console.WriteLine("2. Sort Character");
            Console.WriteLine("Enter the Question Number ");
            qst = int.Parse(Console.ReadLine());
            if (qst == 1)
            {
                Console.WriteLine("Enter the Number ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("The Factors are : ");

                Console.WriteLine("last value : " + lastvalues(num));
            }
            else
            {
                Console.WriteLine("Enter Your sentence ");
                sentence = Console.ReadLine().ToString();
                sort_character(sentence);
            }


            Console.ReadLine();
        }

        public static int lastvalues(int bilangan)
        {
            Console.WriteLine();
            int val = 0;
            for (int i = 2; i < bilangan; i++)
            {
                if (bilangan % i == 0)
                {
                    Console.Write(i + " ");
                    val = i;
                }
            }
            return val;
        }

        public static void sort_character(string sentence)
        {
            List<string> ls = new List<string>();
            for (int i = 0; i < sentence.Length; i++)
            {
                ls.Add(sentence[i].ToString());
            }

            ls.Sort();

            for (int a = 0; a<ls.Count; a++)
            {
                Console.Write(ls[a].ToString().ToLower());
            }

        }




    }
}
