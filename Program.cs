using System;
using System.Collections.Generic;

namespace Gyertyak
{
    internal class Program
    {
        public static List<Elado> eladok = new List<Elado>();
        public static List<Szallito> szallitok = new List<Szallito>();
        public static BinarisKeresofa<IGyertya, int> termekek = new BinarisKeresofa<IGyertya, int>();
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("1 - Eladó hozzáadása");
            Console.WriteLine("2 - Szállító hozzáadása");
            Console.WriteLine("3 - Termék hozzáadása");
            Console.WriteLine("4 - Ország hozzáadása szállítóhoz");
            Console.WriteLine("5 - Terméket árúsítók keresése");
            Console.WriteLine("6 - Teljes terméklista");
            Console.WriteLine("7 - Termék keresése");
            ConsoleKeyInfo key = Console.ReadKey();


            if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                m1();
                Console.Clear();
                Menu();
            }
            else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                m2();
                Console.Clear();
                Menu();
            }
            else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                m3();
                Console.Clear();
                Menu();
            }
            else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                m4();
                Console.Clear();
                Menu();
            }
            else if (key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5)
            {
                Console.Clear();
                m5();
                Console.Clear();
                Menu();
            }
            else if (key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.NumPad6)
            {
                Console.Clear();
                m6();
                Console.Clear();
                Menu();
            }
            else if (key.Key == ConsoleKey.D7 || key.Key == ConsoleKey.NumPad7)
            {
                Console.Clear();
                m7();
                Console.Clear();
                Menu();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Menu();
            }


        }



        static void m1()
        {
            Console.Clear();
            eladok.Add(new Elado(eladok, ref termekek, szallitok));
        }

        static void m2()
        {

        }

        static void m3()
        {
            
        }

        static void m4()
        {

        }

        static void m5()
        {

        }

        static void m6()
        {

        }

        static void m7()
        {

        }
    }
}
