using System;
using System.Collections.Generic;

namespace Gyertyak
{
    internal class Program
    {
        public static List<Elado> eladok = new List<Elado>();
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
            Console.WriteLine("6 - Terméket árúsítók keresése");
            Console.WriteLine("7 - Teljes terméklista");
            Console.WriteLine("8 - Termék keresése");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    m1();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    m2();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    m3();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    m4();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    m5();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    m6();
                    break;
                case ConsoleKey.D7:
                    Console.Clear();
                    m7();
                    break;
                case ConsoleKey.D8:
                    Console.Clear();
                    m8();
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }
        }



        static void m1()
        {

        }

        static void m2()
        {

        }

        static void m3()
        {
            Console.Write("Eladó: ");
            string eladoNeve = Console.ReadLine();
            Elado elado = eladok.Find(x => x.Name == eladoNeve);
            while (elado == null)
            {
                Console.Clear();
                Console.Write("Eladó: ");
                eladoNeve = Console.ReadLine();
                elado = eladok.Find(x => x.Name == eladoNeve);
            }
            Console.Write("Termék típusa: ");
            string ttype = Console.ReadLine();
            switch (ttype)
            {
                case "poharas gyertya":
                    elado.ujPoharas();
                    break;
                case "illatos mécses":
                    elado.ujMecses();
                    break;
                case "lampiongyertya":
                    elado.ujLampion();
                    break;
                default:
                    Console.WriteLine("Nincs ilyen típus!");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    m3();
                    break;
            }
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

        static void m8()
        {

        }
    }
}
