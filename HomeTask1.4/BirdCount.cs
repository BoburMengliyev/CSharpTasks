using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask14
{
    internal class BirdCount
    {
        private int[] birdsPerDay;
        public static int[] LastWeek() 
        {
            return new int[] { 0, 2, 5, 3, 7, 8, 4 };
        }

        public BirdCount(int[] birdsPerDay) 
        {
            this.birdsPerDay = birdsPerDay;
        }

        public int Today() 
        {
            return birdsPerDay[birdsPerDay.Length - 1];
        }

        public int IncrementTodaysCount() 
        {
            return birdsPerDay[birdsPerDay.Length - 1]++;
        }

        public bool HasDayWithoutBirds() 
        {
            foreach (var count in birdsPerDay) 
            {
                if (count == 0) 
                {
                    return true;
                }
            }
            return false;
        }

        public int CountForFirstDays (int numberOfDays) 
        {
            int sum = 0;
            for (int i = 0; i < numberOfDays && i < birdsPerDay.Length - 1; i++) 
            {
                sum += birdsPerDay[i];
            }
            return sum;
        }

        public int BusyDays() 
        {
            int count = 0;
            foreach (var day in birdsPerDay) 
            {
                if (day >= 5) 
                {
                    count++;
                }
            }
            return count;
        }
    }
}
