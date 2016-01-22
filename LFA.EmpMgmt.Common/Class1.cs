using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LFA.EmpMgmt.Common
{
    /// <summary>
    /// User Class for storing User Details
    /// </summary>
    public class User
    {
        #region Private Members
        //Private access modifier that is accessable only with the body of this class.
        private string _password;

        #endregion

        #region Private Methods

        private bool IsAdminUser()
        {
            return ((this.UserName == "admin" && this._password == "password"));
        }

        #endregion

        #region Public Members
        //Properties are public methods that you use for access to the private member variables
        //and can be accessed outside of the class
        //auto-implemented property
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }

        //Static Property to access from class level and share among assemblies.
        public static int NoOfUsers { get; set; }

        public string Password
        {
            //writing  private makes this property read only cannot read this property.
            private get { return _password; }
            set { _password = value; }
        }

        #endregion

        #region Constructor

        //Default Constructor
        //useful for initializing the properties of the object.
        public User()
        {
            this._password = "guest";
            this.UserName = "guest";
            this.IsAdmin = this.IsAdminUser();
            NoOfUsers++;
        }

        //Paramaterized Constructor
        public User(string userName, string password)
        {
            this._password = password;
            this.UserName = userName;
            this.IsAdmin = this.IsAdminUser();
            NoOfUsers++;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Authenticate void method that returns nothing to check User credentials .
        /// </summary>
        /// <param name="user"></param>
        public void Authenticate()
        {
            string userType = this.IsAdmin ? "Admin User" : "Guest User";

            if ((this.UserName == "admin") && (this._password == "password"))
            {
                Console.WriteLine("Welcome " + userType + " :-" + this.UserName);
            }
            else if ((this.UserName == "guest") && (this.Password == "guest"))
            {
                Console.WriteLine("Welcome " + userType + ":-" + this.UserName);
            }
            else
            {
                Console.WriteLine("Incorrect username or password");
            }
        }

        #endregion

    }
}
