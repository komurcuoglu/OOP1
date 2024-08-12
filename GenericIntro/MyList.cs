using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList() { 
            items = new T[10];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[(int)tempArray.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length-1] = item;

        }
    }
}
