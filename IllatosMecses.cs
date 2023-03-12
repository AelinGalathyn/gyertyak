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

        public IllatosMecses(int ar, Alapanyag alapanyag, float suly, int egesiIdo, string illat)
        {
            _cikkszam = r.Next(100000, 999999);
            _ar = ar;
            _alapanyag = alapanyag;
            _suly = suly;
            _egesiIdo = egesiIdo;
            _illat = illat;
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
        public string Illat { get => _illat; set => _illat = value; }
        public Alapanyag Alapanyag { get => _alapanyag; set => _alapanyag = value; }
        public List<Szallito> Szallitok { get => _szallitok; set => _szallitok = value; }


    }
}
