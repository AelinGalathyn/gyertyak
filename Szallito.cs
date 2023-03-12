using System.Collections.Generic;

namespace Gyertyak
{
    internal class Szallito
    {
        private string _name;
        private float _maxSuly;
        private float _minSuly;
        private List<string> _orszagok;

        public Szallito(string name, float maxSuly, float minSuly, List<string> orszagok)
        {
            _name = name;
            _maxSuly = maxSuly;
            _minSuly = minSuly;
            _orszagok = orszagok;
        }

        public void ujOrszag(string orszag)
        {
            _orszagok.Add(orszag);
        }

        public string Name { get => _name; set => _name = value; }
        public float MaxSuly { get => _maxSuly; set => _maxSuly = value; }
        public float MinSuly { get => _minSuly; set => _minSuly = value; }
        public List<string> Orszagok { get => _orszagok; set => _orszagok = value; }
    }
}
