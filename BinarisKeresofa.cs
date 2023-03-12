using System;
using System.Collections;
using System.Collections.Generic;

namespace Gyertyak
{
    internal class BinarisKeresofa<T, K> : IEnumerable<T> where K : IComparable<K>
    {
        public enum BejarasModja
        {
            InOrder, PreOrder, PostOrder
        }

        class FaElem
        {
            public T tartalom;
            public K kulcs;
            public FaElem bal;
            public FaElem jobb;
        }

        private FaElem root;
        private BejarasModja bejaras;
        public BejarasModja Bejaras
        {
            set
            {
                bejaras = value;
            }
        }

        private T _Kereses(FaElem p, K kulcs)
        {
            if (p != null)
            {
                if (p.kulcs.CompareTo(kulcs) < 0)
                {
                    //jobb
                    return _Kereses(p.jobb, kulcs);
                }
                else if (p.kulcs.CompareTo(kulcs) > 0)
                {
                    //bal
                    return _Kereses(p.bal, kulcs);

                }
                else
                {
                    //kulcs egyenlő a miénkkel
                    return p.tartalom;
                }
            }
            else
            {
                throw new ArgumentException("Nincs ilyen elem a fában!");
            }
        }

        private IEnumerable<T> Tartalom
        {
            get
            {
                List<T> tmp = new List<T>();
                switch (bejaras)
                {
                    case BejarasModja.InOrder:
                    default:
                        _InOrderBejaras(tmp, root);
                        break;
                    case BejarasModja.PreOrder:
                        _PreOrderBejaras(tmp, root);
                        break;
                    case BejarasModja.PostOrder:
                        _PostOrderBejaras(tmp, root);
                        break;

                }
                return tmp;
            }
        }

        private void _Beszuras(ref FaElem p, T tartalom, K kulcs)
        {
            if (p == null)
            {
                p = new FaElem();
                p.tartalom = tartalom;
                p.kulcs = kulcs;
            }
            else
            {
                if (p.kulcs.CompareTo(kulcs) < 0)
                {
                    //jobb részfába szúrunk be
                    _Beszuras(ref p.jobb, tartalom, kulcs);
                }
                else if (p.kulcs.CompareTo(kulcs) > 0)
                {
                    //bal részfába szúrunk be
                    _Beszuras(ref p.bal, tartalom, kulcs);
                }
                else
                {
                    throw new ArgumentException("Van már ilyen kulcsú elem a fában!");
                }
            }
        }

        private FaElem _Torles(FaElem elem, K kulcs)
        {
            if (elem == null)
            {
                return elem;
            }

            int cmp = kulcs.CompareTo(elem.kulcs);

            if (cmp < 0)
            {
                elem.bal = _Torles(elem.bal, kulcs);
            }
            else if (cmp > 0)
            {
                elem.jobb = _Torles(elem.jobb, kulcs);
            }
            else
            {
                if (elem.bal == null)
                {
                    return elem.jobb;
                }
                else if (elem.jobb == null)
                {
                    return elem.bal;
                }

                FaElem minElem = Minimum(elem.jobb);
                elem.kulcs = minElem.kulcs;
                elem.tartalom = minElem.tartalom;
                elem.jobb = _Torles(elem.jobb, minElem.kulcs);
            }

            return elem;
        }

        private FaElem Minimum(FaElem elem)
        {
            while (elem.bal != null)
            {
                elem = elem.bal;
            }

            return elem;
        }

        private void _InOrderBejaras(List<T> lista, FaElem p)
        {
            if (p != null)
            {
                _InOrderBejaras(lista, p.bal);
                lista.Add(p.tartalom);
                _InOrderBejaras(lista, p.jobb);
            }
        }

        private void _PreOrderBejaras(List<T> lista, FaElem p)
        {
            if (p != null)
            {
                lista.Add(p.tartalom);
                _PreOrderBejaras(lista, p.bal);
                _PreOrderBejaras(lista, p.jobb);
            }
        }

        private void _PostOrderBejaras(List<T> lista, FaElem p)
        {
            if (p != null)
            {
                _PostOrderBejaras(lista, p.bal);
                _PostOrderBejaras(lista, p.jobb);
                lista.Add(p.tartalom);
            }
        }

        public T Kereses(K kulcs)
        {
            return _Kereses(root, kulcs);
        }

        public void Beszuras(T tartalom, K kulcs)
        {
            _Beszuras(ref root, tartalom, kulcs);
        }

        public void Torles(K kulcs)
        {
            root = _Torles(root, kulcs);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Tartalom.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Tartalom.GetEnumerator();
        }
    }
}
