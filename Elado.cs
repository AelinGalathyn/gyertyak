using System.Collections.Generic;
using System;

namespace Gyertyak
{
    class Elado
    {
        private string _name;
        private string _website;
        private List<IGyertya> _gyertyak;

        public Elado(List<Elado> eladok, ref BinarisKeresofa<IGyertya, int> termekek, List<Szallito> szallitok)
        {
            Console.Write("Név: ");
            _name = Console.ReadLine();
            Console.Write("Weboldal: ");
            _website = Console.ReadLine();
            _gyertyak = new List<IGyertya>();
        }

        private void ellenorzes(List<Elado> eladok)
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
        }

        private void ujTermek(ref BinarisKeresofa<IGyertya, int> termekek, List<Szallito> szallitok)
        {
            Console.Write("Termék típusa: ");
            string ttype = Console.ReadLine();
            switch (ttype)
            {
                case "poharas gyertya":
                    ujPoharas(ref termekek, szallitok);
                    break;
                case "illatos mécses":
                    ujMecses(ref termekek, szallitok);
                    break;
                case "lampiongyertya":
                    ujLampion(ref termekek, szallitok);
                    break;
                default:
                    Console.WriteLine("Nincs ilyen típus!");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    ujTermek(ref termekek, szallitok);
                    break;
            }
        }

        public void ujPoharas(ref BinarisKeresofa<IGyertya, int> termekek, List<Szallito> szallitok)
        {
            PoharasGyertya pg = new PoharasGyertya(this, szallitok);
            _gyertyak.Add(pg);
            termekek.Beszuras(pg, pg.Cikkszam);
        }

        public void ujMecses(ref BinarisKeresofa<IGyertya, int> termekek, List<Szallito> szallitok)
        {
            IllatosMecses pg = new IllatosMecses(this, szallitok);
            _gyertyak.Add(pg);
            termekek.Beszuras(pg, pg.Cikkszam);
        }

        public void ujLampion(ref BinarisKeresofa<IGyertya, int> termekek, List<Szallito> szallitok)
        {
            LampionGyertya pg = new LampionGyertya(this, szallitok);
            _gyertyak.Add(pg);
            termekek.Beszuras(pg, pg.Cikkszam);
        }



        public string Name { get => _name; set => _name = value; }
        public string Website { get => _website; set => _website = value; }
        public List<IGyertya> Gyertyak { get => _gyertyak; set => _gyertyak = value; }
    }
}
