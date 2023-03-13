using System;
using System.Collections.Generic;

namespace Gyertyak
{
    internal class IllatosMecses : IGyertya
    {
        Random r = new Random();

        private int _cikkszam;
        private int _ar;
        private Alapanyag _alapanyag;
        private float _suly;
        private List<Szallito> _szallitok;
        private int _egesiIdo;
        private string _illat;
        private Elado _elado;

        public IllatosMecses(Elado elado, List<Szallito> szallitok)
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
            _elado = elado;
        }

        public int Cikkszam { get => _cikkszam; set => _cikkszam = value; }
        public int Ar { get => _ar; set => _ar = value; }
        public float Suly { get => _suly; set => _suly = value; }
        public int EgesiIdo { get => _egesiIdo; set => _egesiIdo = value; }
        public string Illat { get => _illat; set => _illat = value; }
        public Alapanyag Alapanyag { get => _alapanyag; set => _alapanyag = value; }
        public List<Szallito> Szallitok { get => _szallitok; set => _szallitok = value; }
        public Elado Elado { get => _elado; set => _elado = value; }
    }
}
