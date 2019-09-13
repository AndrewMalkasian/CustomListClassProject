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
            List<int> numbers = new List<int>();
            numbers.Add(40);
            numbers.Add(40);
            numbers.Add(40);
            numbers.Remove(40);


            Console.WriteLine(numbers);



        }
    }
}
