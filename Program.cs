using System;

namespace DeliverableOne
{
    class Program
    {
        private bool hasUpper(string word)
        {
            foreach (char c in word)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }
        private bool hasLower(string word)
        {
            foreach (char c in word)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program passwordCheck = new Program();
            Console.WriteLine("Create a password with at least one lowercase letter, one uppercase letter and an !, the password must be at least 7 characters long and 12 characters maximum.");
            Console.Write("Enter password: ");
            string inputPassword = Console.ReadLine();

            if (inputPassword.Length >= 7 && 
                inputPassword.Length <= 12 && 
                passwordCheck.hasUpper(inputPassword) &&
                passwordCheck.hasLower(inputPassword) &&
                inputPassword.Contains("!")) {                
                Console.WriteLine("Password valid and accepted");                                
            } else {
                Console.WriteLine("Error");
            }
        }
    }
}
