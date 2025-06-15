using System;
using System.Collections.Generic;
using System.Text;

namespace zd5_1_Demin
{
    static public class Validation
    {
        
        static public double Check_Sum(string sum_kr)
        {
            try
            {
                double sum = Convert.ToDouble(sum_kr);
                if (sum > 0)
                {
                    return sum;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        static public int Check_Time(string time_kr)
        {
            try
            {
                int time = Convert.ToInt32(time_kr);
                if (time > 0 && time < 120)
                {
                    return time;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        static public double Check_Scrol(double scroll)
        {
            try
            {

                if (scroll >= 0 && scroll <= 100)
                {
                    return scroll;
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }
    }
}
