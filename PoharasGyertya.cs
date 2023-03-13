using System;
using System.Collections.Generic;

namespace Gyertyak
{
    internal class PoharasGyertya : IGyertya
    {
        Random r = new Random();
        private int _cikkszam;
        private int _ar;
        private Alapanyag _alapanyag;
        private float _suly;
        private List<Szallito> _szallitok;
        private int _egesiIdo;
        private int _poharCikkszam;
        private Elado _elado;

        public PoharasGyertya(Elado elado, List<Szallito> szallitok)
        {
            _cikkszam = r.Next(100000, 999999);
            Console.Write("Ár: ");
            _ar = int.Parse(Console.ReadLine());
            Console.Write("Alapanyag: ");
            _alapanyag = (Alapanyag)Enum.Parse(typeof(Alapanyag), Console.ReadLine());
            Console.Write("Súly: ");
            _suly = int.Parse(Console.ReadLine());
            Console.Write("Égési idő: ");
            _egesiIdo = int.Parse(Console.ReadLine());
            _szallitok = new List<Szallito>();
            Console.Write("Pohár cikkszáma: ");
            _poharCikkszam = int.Parse(Console.ReadLine());
        }
        

        public float Suly { get => _suly; set => _suly = value; }
        public int EgesiIdo { get => _egesiIdo; set => _egesiIdo = value; }
        public Alapanyag Alapanyag { get => _alapanyag; set => _alapanyag = value; }
        public List<Szallito> Szallitok { get => _szallitok; set => _szallitok = value; }
        public int Cikkszam { get => _cikkszam; set => _cikkszam = value; }
        public int Ar { get => _ar; set => _ar = value; }
        public int PoharCikkszam { get => _poharCikkszam; set => _poharCikkszam = value; }
        public Elado Elado { get => _elado; set => _elado = value; }
    }
}
