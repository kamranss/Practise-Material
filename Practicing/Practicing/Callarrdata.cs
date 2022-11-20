using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    internal class Callarrdata
    {


        public Callarrdata()
        {

        }

        public string ArrayOnScreen(string[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            return "finished";

        }


        public void CalculateArr(int[,] a)
        {

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum1 += a[i,i];
            }
            int j = a.GetLength(0) - 1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum2 += a[i,j];
                j--;
            }
            Console.WriteLine( sum1-sum2 );




        }
    }

}




   

