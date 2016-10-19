using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList : IGenericList<X>
    {
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(X item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(X item)
        {
            throw new NotImplementedException();
        }

        public X GetElement(int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(X item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(X item)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
