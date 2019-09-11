using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>
    {
        // member variables
        private T[] items;
        private T[] count 
       
            public T[] Count
            {
                get
                {
                    return count;
                }
                set
                {
                    count = value;
                }
            }



        // constructor
        public CustomList()
        {
            items = new T[4];
        }

        // member methods
    }
}
