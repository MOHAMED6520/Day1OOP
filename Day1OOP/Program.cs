namespace Day1OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            ////Struct
            //Point P01;
            ////P01.X = 10;
            ////P01.Y = 10;
            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            //P01=new Point();
            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);
            //P01 = new Point(14 , 15);   
            ////Console.WriteLine(P01.X);
            ////Console.WriteLine(P01.Y);

            ////  Console.WriteLine(P01); 
            ////  P01.PrintPoint();      
            //    Console.WriteLine(P01.ToString()); 
            #endregion

            #region Encapsulation
            ////OOP                  
            ////Encapsulation
            //Employee Emp01 = new Employee(1,"Mohamed",15000);
            //Emp01.id = 1;
            //Emp01.name = "mohamed";
            //Emp01.salary = 14101;
            //Console.WriteLine(Emp01.id);
            //Console.WriteLine(Emp01.name);
            //Console.WriteLine(Emp01.salary);

            //Emp01.SetId(1);
            //Emp01.SetName("mohamed");
            //Emp01.SetSalary(-15000);

            //Console.WriteLine(Emp01.GetId());
            //Console.WriteLine(Emp01.GetName());
            //Console.WriteLine(Emp01.GetSalary());

            //Console.WriteLine(Emp01); 
            #endregion

            #region prop
            //Employee E01 = new Employee();
            //E01.Id = 12;          
            //E01.Name = "Mohamed";
            //E01.Salary = 12000;
            //E01.Address = "Cairo";

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Address); 
            #endregion


            #region Indexer
            // Indexer

            //PhoneBook phbook01 = new PhoneBook(3);

            //phbook01.AddPerson("Mohamed", 11111, 0);
            //phbook01.AddPerson("Ahmed", 22222, 1);
            //phbook01.AddPerson("Ali", 33333, 2);

            //// Console.WriteLine(phbook01.GetNumber("Mohamed")); 
            ////phbook01.UpdateNumber("Mohamed",2225541);
            //// Console.WriteLine(phbook01.getName(22222));

            //Console.WriteLine(phbook01["Mohamed"]);
            //phbook01["Mohamed"] = 1254512;
            //Console.WriteLine(phbook01["Mohamed"]); 
            #endregion


        }
    }
}
