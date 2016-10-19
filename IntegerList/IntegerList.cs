using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerList
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;

        /// <summary>
        /// This constructor creates new IntegerList by initaliazing its private field with size 4.
        /// </summary>
        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        /// <summary>
        /// This constructor creates new IntegerList by initaliazing its private field with size given by initialSize.
        /// </summary>
        /// <param name="initalSize">How much size private field will take.</param>
        public IntegerList(int initalSize)
        {
            if(initalSize < 0)
            {
                throw new ArgumentException("Argument musn't be negative.");
            }
            else
            {
                _internalStorage = new int[initalSize];
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public int GetElement(int index)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
