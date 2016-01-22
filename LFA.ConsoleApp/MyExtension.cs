using LFA.EmpMgmt.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.ConsoleApp
{

    /// <summary>
    /// Extension class 
    /// </summary>
    public static class MyExtension
    {
        /// <summary>
        /// CheckLogin extension method extending the User class. i.e adding CheckLogin method in User class without recompiling the class.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>true if username and password is correct false otherwise</returns>
        public static bool IsAdminUser(this User user)
        {
            return (user.IsAdmin);
        }

        /// <summary>
        /// Extending on .NET int type to include a method for squaring numbers
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int Square(this int i)
        {
            return i * i;
        }

        /// <summary>
        /// Static method to access via Class name 
        /// </summary>
        /// <param name="i"></param>
        /// <returns>square root of i </returns>
        public static int Sqrt(int i)
        {
            return i * i;
        }

    }
}
