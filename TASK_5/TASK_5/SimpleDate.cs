using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct SimpleDate
    {
        int Day;
        int Year;
        int Month;

        public SimpleDate(int day,int year,int month)
        {
            Day=day;
            Year=year;
            Month=month;
        }
        public override string ToString()
        {
            return $"{Day}-{Month}-{Year}";
        }
        public bool IsLeapYear()
        {
            if(Year % 4 != 0)
            {
                return false;
            }

            if(Year % 100 != 0)
            {
                return true;
            }

            if(Year % 400 == 0)
            {
                return true;
            }
            else{
                return false;
            }
        }
    }
}
