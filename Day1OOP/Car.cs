using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1OOP
{
    internal class Car
    {
		#region Attributes
		private int id;
		private int speed;
		private string model;
		#endregion


		#region properties
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
        #endregion

        //     public Car()
        //     {
        //Id = default;
        //Speed = default;
        //Model = default;
        //     }


        public Car(int id)
        {
            Id = id;
          
        }
        public Car(int id, int speed):this (id)
        {
           // Id = id;
            Speed = speed;
           
        }
        public Car(int id , int speed , string model):this(id,speed)
        {
            //Id = id;
			//Speed = speed;
			Model = model;
        }



        public override string ToString()
        {
            return $"ID {id}  :: Speed {speed} :: Model {model}";
        }



    }
}
