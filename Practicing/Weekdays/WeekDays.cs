using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing.Weekdays
{
    internal class WeekDays : Method
    {
        public string[] weekdays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public override string Wdays()
        {
            base.Wdays();         
            return "1";
        }


        public  sealed override string Wdays(int number)
        {
            Console.WriteLine(weekdays[number]);
            return "1";

            // Project updated

            int n = 5;
            int m = 6;
            int sum = n + m;

            if (n == m)
            {
                Console.WriteLine(sum);
            }
            else
            {
                sum = (n + m) * 3;
            }
            Console.WriteLine(sum);


            //   kdlkjdlj

            int n = 8;
            int m = 51;


            if (n == m)
            {
                Console.WriteLine("enter different number");
            }
            else if (n < m)
            {
                Console.WriteLine(m - n);
            }
            else if (n > m)
            {
                Console.WriteLine((n - m) * 3);
            }

        }

    }

}
