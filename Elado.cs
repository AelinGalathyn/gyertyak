using System.Collections.Generic;

namespace Gyertyak
{
    class Elado
    {
        private string _name;
        private string _website;
        private List<IGyertya> gyertyak;

        public Elado(string name, string website)
        {
            _name = name;
            _website = website;
            this.gyertyak = new List<IGyertya>();
        }

        public void ujPoharas()
        {


        }

        public void ujMecses()
        {

        }

        public void ujLampion()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string Website { get => _website; set => _website = value; }
        internal List<IGyertya> Gyertyak { get => gyertyak; set => gyertyak = value; }
    }
}
