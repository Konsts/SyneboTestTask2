using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WinterSeason(new int[] { 5, -2, 3, 8, 6 }));
            Console.WriteLine(WinterSeason(new int[] { -5, -5, -5, -42, 6, 12 }));
            Console.ReadLine();
        }

        public static int WinterSeason(int[] temp)
        {
            if (temp.Length < 2)
                throw new System.ArgumentException("The length of the temperature array can not be less than 2");
            int winterDays = 1;
            int firstWinterDay = temp[0];
            for (int i = 1; i < temp.Length; i++)
            {
                if (temp[i] > firstWinterDay)
                {
                    return winterDays;
                }
                else
                {
                    winterDays++;
                }
            }
            return winterDays;
        }
    }
}
