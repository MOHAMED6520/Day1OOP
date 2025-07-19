using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1OOP
{
    enum SecurityPrivileges
    {
        guest,
        Developer, 
        secretary ,
        DBA
    }
    internal class Employee
    {
        private HiringDate hiringDate = new HiringDate ();

        public HiringDate HiringDate
        {
            get { return hiringDate; }
            set { hiringDate = value; }
        }


        public int Id { get; set; }
        public string Name { get; set; }
        private SecurityPrivileges securitylevel;

        public SecurityPrivileges SecurityLevel
        {
            get {
                return securitylevel;
                }

            set { 
                securitylevel = value; 
                }
        }

        private char gender;
        private double salary ;
        
        public double Salary
        {
            get {
               
                return salary; 
                }
            
            set {
                if (value >= 0)
                    salary = value; 
                }
        }

        public char Gender
        {
            get { return gender; }

            set { 
                if (value == 'M'|| value=='F'|| value == 'm'|| value == 'f')
                gender = value;
                }

        }


        
        public override string ToString()
        {
            return $"Id : {Id} :: Name : {Name} :: Gender : {Gender} ::Security Level {SecurityLevel} :: Salary :{Salary.ToString("c")} :: Hiring Date : {HiringDate.Day} / {HiringDate.Month} / {HiringDate.Year}" ;
        }



    }
}
