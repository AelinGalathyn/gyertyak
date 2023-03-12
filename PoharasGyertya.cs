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

        public PoharasGyertya(int cikkszam, int ar, string alapanyag, float suly, int egesiIdo)
        {
            _cikkszam = r.Next(100000, 999999);
            _ar = ar;
            _alapanyag = (Alapanyag)Enum.Parse(typeof(Alapanyag), alapanyag);
            _suly = suly;
            _szallitok = new List<Szallito>();
            _egesiIdo = egesiIdo;
        }

        public void ujSzallito(Szallito szallito)
        {
            _szallitok.Add(szallito);
        }

        public void szallitoTorol(Szallito szallito)
        {
            _szallitok.Remove(szallito);
        }

        public float Suly { get => _suly; set => _suly = value; }
        public int EgesiIdo { get => _egesiIdo; set => _egesiIdo = value; }
        public Alapanyag Alapanyag { get => _alapanyag; set => _alapanyag = value; }
        public List<Szallito> Szallitok { get => _szallitok; set => _szallitok = value; }
        public int Cikkszam { get => _cikkszam; set => _cikkszam = value; }
        public int Ar { get => _ar; set => _ar = value; }
        public int PoharCikkszam { get => _poharCikkszam; set => _poharCikkszam = value; }
    }
}
