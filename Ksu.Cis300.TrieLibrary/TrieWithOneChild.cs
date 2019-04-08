using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    class TrieWithOneChild : ITrie
    {
        private bool _isEmpty;

        private ITrie _onlyChild;

        private char _label;
        public ITrie Add(string s)
        {
            if(s == "")
            {
                _isEmpty = true;
                return this;
            }
            else if( s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }

            else if(s[0] == _label)
            {
                _onlyChild = _onlyChild.Add(s.Substring(1));
                return this;
            }

            else
            {
                return new TrieWithManyChildren(s, _isEmpty, _label, _onlyChild);
            }

        }

        public bool Contains(string s)
        {
            if(s == "")
            {
                return _isEmpty;
            }
            if(s[0] == _label)
            {
               return _onlyChild.Contains(s.Substring(1));
            }
            else
            {
                return false;
            }
        }

        public TrieWithOneChild(string s, bool empty)
        {
            if (s == "" || s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }

            _isEmpty = empty;
            _label = s[0];
            _onlyChild = new TrieWithNoChildren();
           _onlyChild = _onlyChild.Add(s.Substring(1));
        }
    }
}
