using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject 
{

    public class Operator : CustomList<int>
    {

        // number is  a dot notation so I need to make a dot notation for the value of the plus operator.


        public int Count;

        public Operator(int Count)
        {
            this.Count = Count;
        
        }
            
        

    }
    //public static CustomList operator +(CustomList<int> one,
    //                                      CustomList<int> two)
    //{
    //    CustomList<int> TestList = new CustomList<int>(one.Count + two.Count, one.value + two.value);
    //    return TestList;
    //}
    

   
        //    for (int i = 0; i < temparray.Count ; i++)
        //    {

        //    Console.WriteLine(temparray[i]);

        //    }
        //        return temparray;
        //}

        //CustomList<int> result = new CustomList<int>();
        //    one = new CustomList<int>();
        //    one.Add(1);
        //    one.Add(3);
        //    one.Add(5);

        //    two = new CustomList<int>();
        //    two.Add(2);
        //    two.Add(4);
        //    two.Add(6);


        //    result = one. + two;
        //    return result;

        //}
        //public Operator()
        //{
        //    //able to assign a variable in the parameter and use with .(dot) notation. 
        //}
        //public void display()
        //{
        //    Console.WriteLine();
        //}
}
