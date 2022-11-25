using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    internal class Numbercategory
    {

        public int Num;

        public Numbercategory()
        {

        }

        public string NumberCategory(int n)
        {
            int count = 0;
            for (int i = 1; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                return "the number is a Compposite number";
            }
            else
            {
                return "The number is a Prime number";
            }

        }
    }
}
