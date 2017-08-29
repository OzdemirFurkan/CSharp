using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollectionsSample
{
    public class Mylist<TType> where TType : struct
    {
        private TType?[] _mylist;
        private int _lastindex;

        public Mylist()
        {
            _mylist = new TType?[0];
        }

        public int Capacity { get; private set; }
        public int Numberofmember { get {
            return _mylist.Where(item => !item.Equals(null)).Count();
        } }

        public void myAdd(TType member)
        {
            if (Numberofmember==0 || Numberofmember % 5 == 0) {
                Array.Resize(ref _mylist, _mylist.Length + 5);
                _lastindex = Array.IndexOf(_mylist, null);
                _mylist[_lastindex] = member;
                Capacity = _mylist.Length;
            }
            else {
                _lastindex = Array.IndexOf(_mylist, null);
                _mylist[_lastindex] = member;
            }
        }

    }
}
