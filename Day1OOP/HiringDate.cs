using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1OOP
{
    internal class HiringDate
    {

		private int day;

		public int Day
		{
			get { return day; }

			set {  
				if (value >0 && value < 30)
				day = value; 
			    }
		}

        private int month;

        public int Month
        {
            get { return month; }

            set
            {
                if (value > 0 && value < 12)
                    month = value;
            }
        }
        private int year;

        public int Year
        {
            get { return year; }

            set
            {
                if (value > 1900 && value <= 2025)
                    year = value;
            }
        }

    }
}
