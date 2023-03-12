using System.Collections.Generic;

namespace Gyertyak
{
    enum Alapanyag
    {
        szója, paraffin, sztearin, méhviasz
    }
    internal interface IGyertya
    {
        int Cikkszam { get; set; }
        Alapanyag Alapanyag { get; set; }
        float Suly { get; set; }
        List<Szallito> Szallitok { get; set; }
        int EgesiIdo { get; set; }
        int Ar { get; set; }

        void ujSzallito(Szallito szallito);
        void szallitoTorol(Szallito szallito);
    }
}
