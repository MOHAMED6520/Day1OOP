using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1OOP
{
    internal struct Point
    {
		private int x;

		private int y;

        public int X
        {

            set
            {
                 if (value >= 0)
                x = value;
            }

            get { return x; }


          
        }
        public int Y
		{
			get { return y; }

			set {  
				if (value >= 0) 
				y = value; 
			    }
		}
         public void PrintDistance ()
        {
            if (this.X > this.Y)
                Console.WriteLine($"The Distanse Between Two Point : {this.X - this.Y}");

            else
                Console.WriteLine($"The Distanse Between Two Point : {this.Y - this.X}");

        }




    }
}
