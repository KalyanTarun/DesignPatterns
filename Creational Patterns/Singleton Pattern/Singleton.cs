using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    
    sealed class Login
    {
        private static Login login = null;
        private Login()
        {
           
        }
        public static Login SignIn()
        {
            if (login == null)
            {
                login = new Login();
                Console.WriteLine("You are signing In!!");
                return login; 
            }
            else
            {
                Console.WriteLine("You are already signed In!");
                return login;
            }
        }
    }
    public class Singleton
    {
        public static Main(string[] args)
        {
            Login loginPage=Login.SignIn();
        }
    }
}
