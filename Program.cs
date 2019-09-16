using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> toStringTest = new List<int>();
            //toStringTest.Add(40);
            //test.Add(40);
            //numbers.Add(40);
            //numbers.Remove(40);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if(numbers.ToString()
            //}


            //Console.WriteLine(numbers);
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            //act
            one.Add(1);
            one.Add(3);
            one.Add(5);

            two.Add(2);
            two.Add(4);
            two.Add(6);
            CustomList<int> three = one + two;

            Console.WriteLine(three);
           
            


        }
    }
}
