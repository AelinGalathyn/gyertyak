using System;
using System.Collections.Generic;

namespace Gyertyak
{
    internal class LampionGyertya : IGyertya
    {
        Random r = new Random();
        private int _cikkszam;
        private int _ar;
        private Alapanyag _alapanyag;
        private float _suly;
        private List<Szallito> _szallitok;
        private int _egesiIdo;
        private float _atmero;
        private float _magassag;

        public LampionGyertya(int cikkszam, int ar, Alapanyag alapanyag, float suly, float atmero, float magassag)
        {
            _cikkszam = r.Next(100000, 999999);
            _ar = ar;
            _alapanyag = alapanyag;
            _suly = suly;
            _egesiIdo = 0;
            _atmero = atmero;
            _magassag = magassag;
        }

        public void ujSzallito(Szallito szallito)
        {
            _szallitok.Add(szallito);
        }

        public void szallitoTorol(Szallito szallito)
        {
            _szallitok.Remove(szallito);
        }

        public int Cikkszam { get => _cikkszam; set => _cikkszam = value; }
        public int Ar { get => _ar; set => _ar = value; }
        public float Suly { get => _suly; set => _suly = value; }
        public int EgesiIdo { get => _egesiIdo; set => _egesiIdo = value; }
        public float Atmero { get => _atmero; set => _atmero = value; }
        public float Magassag { get => _magassag; set => _magassag = value; }
        public Alapanyag Alapanyag { get => _alapanyag; set => _alapanyag = value; }
        public List<Szallito> Szallitok { get => _szallitok; set => _szallitok = value; }
    }
}
