using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    public class CustomList<T>
    {
        //(10 points): As a developer, I want a Capacity property implemented on the custom-built list class,
        //so that I can publicly see the size of my private array.
        // member variables
       
        private T[] items;
        private int capacity;
        private int count;
        public int Capacity
        {
            get {return capacity;}
        }
       
        public int Count
        {
             get {return count; }
        }
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }



        // constructor
        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
        }

        public void Add(T value)
        {

           if(Capacity == Count)
            {
                capacity *= 2; // capacity is a stored variable and will keep the value until assigned into new array
                T[] newArray = new T[capacity];
                for (int i = 0; i < Count; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }

            items[count] = value;
            count++;


            
           
            
               
                   
                
        }
    }

        // member methods

        //(10 points): As a developer, I want a read-only Count property implemented on the 
        //custom-built list class, so that I can get a count of the number of elements in my custom 
        //list class instance.

}

