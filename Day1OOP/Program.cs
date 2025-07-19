using System.Globalization;
using System.Security.Cryptography;

namespace Day1OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Point P01 = new Point();
            //int x, y;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter X :");
            //    flag= int.TryParse(Console.ReadLine(), out x);
            //}
            //while (flag==false||x<0);
            //P01.X = x;

            //do
            //{
            //    Console.Write("Enter Y :");
            //   flag= int.TryParse(Console.ReadLine(), out y);
            //}
            //while (flag == false || y<0);
            //P01.Y = y;

            //P01.PrintDistance(); 
            #endregion

            #region Q02
            //Person[] P01 = new Person[3];
            //int X;
            //bool Flag;

            //int MaxAge = P01[0].Age , MaxIndex = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter Person Name : ");
            //    P01[i].Name = Console.ReadLine();

            //    do
            //    {
            //        Console.Write("Enter Person Age : ");
            //        Flag = int.TryParse(Console.ReadLine(), out X); 
            //    }
            //    while (!Flag || X<=0);
            //    P01[i].Age = X;

            //    if (MaxAge < X)
            //    {
            //        MaxAge = X;
            //        MaxIndex = i;
            //    }
            //}

            //Console.WriteLine($"The Name Of The Oldest Person : {P01[MaxIndex].Name}");
            //Console.WriteLine($"The Age Of The Oldest Person : {P01[MaxIndex].Age}"); 
            #endregion
     
            #region Q03
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee();
            //EmpArr[0].Id = 1;
            //EmpArr[0].Name = "Mohamed";
            //EmpArr[0].Salary = 12000;
            //EmpArr[0].Gender = 'm';
            //EmpArr[0].HiringDate.Day = 5;
            //EmpArr[0].HiringDate.Month = 1;
            //EmpArr[0].HiringDate.Year = 2025;
            //EmpArr[0].SecurityLevel = SecurityPrivileges.DBA;

            //EmpArr[1] = new Employee();
            //EmpArr[1].SecurityLevel = SecurityPrivileges.guest;
            //EmpArr[2] = new Employee();
            //EmpArr[2].SecurityLevel = SecurityPrivileges.Developer;
            //Console.WriteLine();
            //Console.WriteLine(EmpArr[0].ToString()); 
            #endregion







        }
    }
}
