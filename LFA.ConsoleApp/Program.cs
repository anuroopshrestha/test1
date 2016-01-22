using LFA.EmpMgmt.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string condition = "";
            do
            {
                Console.Write("Enter User:");
                string userName = Console.ReadLine();
                Console.Write("Password:");
                string password = Console.ReadLine();

                //Object User created with default constructor
                User guestUser = new User();
                guestUser.Authenticate();

                //Object user created with paramaterized constructor
                User user = new User(userName, password);
                user.Authenticate();

                //Accessing extented method IsAdminUser() from object.
                Console.WriteLine(user.IsAdminUser());

                Console.WriteLine("Total no of users :" + User.NoOfUsers.ToString());

                //Cannot read Password property as it is set as private read only property
                //Console.WriteLine(user.Password); 

                //Accessing Static Method via class cannot be instantiated.
                Console.WriteLine(MyExtension.IsAdminUser(user));

            }
            while (condition != "N");


            #region Arguments example

            // Sending Arguments from command line 
            // Open cmd prompt and change directory to LFA.EmpMgmt\LFA.Week102\LFA.Week102\bin\Debug location
            // type LFA.Week102.exe admin password 
            // 
            //do
            //{
            //    if (args.Length > 1)
            //    {
            //        if ((args[0] == "admin") && (args[1] == "password"))
            //        {
            //            Console.WriteLine("Welcome " + args[0]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect username or password");
            //        }
            //    }
            //    else
            //    {
            //        //Creating user object
            //        User user;
            //        Console.Write("Enter User:");
            //        string userName = Console.ReadLine();
            //        Console.Write("Password:");
            //        string password = Console.ReadLine();
            //        user = new User(userName,password);
            //    }
            //} while (Console.ReadLine() != "N");

            #endregion


            Console.ReadLine();

        }
    }
}
