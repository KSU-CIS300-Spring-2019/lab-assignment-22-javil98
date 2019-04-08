using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithNoChildren : ITrie
    {
        private bool _isEmpty;

        private ITrie _onlyChild;

        private char _label;
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _isEmpty = true;
                return this;
            }
            else
            {
                return new TrieWithOneChild(s, _isEmpty);
            }
        }

        public bool Contains(string s)
        {
            if (s == "")
            {
                return _isEmpty;

            }
            else
            {
                return false;
            }
        }
    }
}
