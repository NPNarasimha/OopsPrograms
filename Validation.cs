using System;
using System.Collections.Generic;
using System.Text;

namespace OopsPrograms
{
    internal class Validation
    {
        public void UserValidation()
        {
            Console.WriteLine("Enter the name : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();

            if(userName=="np" && password == "123np")
            {
                Console.WriteLine("Login Successfull");
            }else if(userName=="np"&& password != "123np")
            {
                Console.WriteLine("password incorrect");
            }
            else if(userName != "np" && password == "123np")
            {
                Console.WriteLine("UserName incorrect");
            }
            else
            {
                Console.WriteLine("Account locked");
            }

        }
    }
}
