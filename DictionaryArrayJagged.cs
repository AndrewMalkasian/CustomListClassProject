using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomListClassProject
{
    class DictionaryArrayJagged

    {
       public Dictionary<int[][], CustomList<object>> test = new Dictionary<int[][], CustomList<object>>();
       int[][] jaggedArray = new int[3][];
        public void TestMethod()
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[2] { 1, 2 };
            jaggedArray[2] = new int[2] { 4, 5 };
            jaggedArray[3] = new int[2] { 1, 2 };

            int[][,] jagDimArray = new int[2][,]
            {
                new int [,] { { 1 , 3 } , { 2 , 4 } }, //jagDimArray[0]
                new int [,] { {1,2}, {3, 4 }, {5, 7 } , {1, 2 } } //jagDimArray[1]
            };

        }





    }
}
