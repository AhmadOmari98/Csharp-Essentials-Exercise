using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask_AhmadOmari_20220216109
{
    internal class Program
    {
        public static void MultiplicationTable(int MultipTableTo)
        {
            Console.WriteLine();
            Console.WriteLine("Multiplication table from 1 to " + MultipTableTo);
            for (int i = 1; i <= MultipTableTo; i++)
            {   
                for (int j = 1; j <= 10 ; j++)
                {
                      Console.Write(i + "*" + j + " = " + i * j+"  "); 
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public static int SpaceCount(string str)
        {
            int spcctr = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    spcctr++;
            }
            Console.WriteLine();
            Console.WriteLine();
            return spcctr;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Select Option :");
            Console.WriteLine("1)Multiplication table --Enter -->(Multip)");
            Console.WriteLine("2)Count number of spaces in a string --Enter -->(Space)");
            Console.WriteLine("3)Exit from  program --Enter -->(Exit)");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Option : ");
            string Option = Console.ReadLine();
            Console.WriteLine();
            while (true)
            {
                switch (Option.ToLower())
                {
                    case "multip":
                        Console.WriteLine("Display the multiplication table vertically from 1 to n:\n");
                        Console.WriteLine("---------------------------------------------------------");
                        Console.Write("Input upto the table number starting from 1 : ");
                        int MultipTableTo = Convert.ToInt32(Console.ReadLine());
                        MultiplicationTable(MultipTableTo);
                        break;

                    case "space":
                        Console.WriteLine("Display the count number of spaces in a string:\n");
                        Console.WriteLine("---------------------------------------------------------");
                        Console.Write("Please input a string : ");
                        string str2 = Console.ReadLine();
                        Console.WriteLine("The count number of spaces in a string = "+SpaceCount(str2));
                        break;

                    
                }
                if (Option.ToLower() == "exit")
                {
                    Console.WriteLine("Thanks for using our program");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Select Option :");
                    Console.WriteLine("1)Multiplication table --Enter -->(Multip)");
                    Console.WriteLine("2)Count number of spaces in a string --Enter -->(Space)");
                    Console.WriteLine("3)Exit from  program --Enter -->(Exit)");
                    Console.WriteLine("------------------------------------------------");
                    Console.Write("Option : ");
                    Option = Console.ReadLine();
                    Console.WriteLine();
                }

            }



        }
    }
}
