using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    internal class Arrmethods
    {
        public string   [] Arr1;
        public string   [] Arr2;
        

        public string   ArrMethod1(string[] arr )
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                 Console.WriteLine(arr[i]);
            }
            return "Finished";

        }
    }
}
