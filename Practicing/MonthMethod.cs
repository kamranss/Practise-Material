using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    internal class MonthMethod
    {
        public string [] monthname = { "Januray", "Februaty", "March", "April", "May", "Jun", "July", "August", "September","October ","November", "December" };
        public int number;
        public string  MonthName(int number)
        {
            return monthname[number];
            
        }
    }
}
