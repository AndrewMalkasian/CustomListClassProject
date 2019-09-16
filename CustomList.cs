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
        public int value;

        public int Capacity
        {
            get { return capacity; }
        }

        public int Count
        {
            get { return count; }
        }
        public T this[int i]
        {
            get
            {
                return items[i];
                
            }
            set
            {
                if (i < 0 || i > count)
                {
                    throw new IndexOutOfRangeException("This isn't within the index.");
                }
                items[i] = value;

            }
        }
        public static CustomList<T> operator +(CustomList<T> one, CustomList<T> two)
        {

            CustomList<T> tempList = new CustomList<T>();


            // tempList {}
            for (int i = 0; i < one.count; i++)
            {
                tempList.Add(one[i]);
            }

            for (int i = 0; i < two.count; i++)
            {
                tempList.Add(two[i]);
            }
            return tempList;
        }
        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {

            CustomList<T> tempList = new CustomList<T>();

            for (int i = 0; i < one.count; i++)
            {
                tempList.Add(one[i]);
            }

            for (int i = 0; i < two.count; i++)
            {
                tempList.Remove(two[i]);
            }
            return tempList;
        }


        

        // constructor
        public CustomList()
        {
            items = new T[4];
            count = 0;
            capacity = 4;
        }

        public void Add(T value) // covers adding of objects
        {

            if (Capacity == Count)
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

        public void Remove(T value) //covers removal of objects
        {

            for (int i = 0; i < Count; i++)
            {
                if (value.Equals(items[i]))
                {
#pragma warning disable CS1717 // Assignment made to same variable
                    for (i = i; i < Count - 1; i++)
#pragma warning restore CS1717 // Assignment made to same variable
                    {
                        items[i] = items[i + 1];
                    }
                    count--;
                }
            }


        }
        public override string ToString()
        {
            string returnToStrings = string.Empty; // same as "";

            //foreach (T item in items)
            //{
            //  returnToStrings += string.Format("{0} ", item);
            //}
            //return returnToStrings;

            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    returnToStrings += string.Format("{0}", items);
                }
                else
                {
                    returnToStrings += string.Format("{0} ,", items);
                }

            }

            return returnToStrings;


        }




    }

}
// member methods
//public void ArrayConnector(params T[] comboArray)
//{

//    for (int i = 0; i < comboArray.Length; i++)
//    {

//    }
//}



