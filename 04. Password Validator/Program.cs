using System;

namespace _04._Password_Validator
{
    class Program
    {
        static bool isValid = true;
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            AskForNewLengh(password);
            AskForNewPass(password);
            AskForLongerPass(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static void AskForNewLengh (string pass)
        {
            if (pass.Length < 6 || pass.Length>10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
                return;
            }
            
        }

        static void AskForNewPass (string pass)
        {
           
            for (int i = 0; i < pass.Length; i++)
            {
                char current = pass[i];

                if (((current<'a' || current>'z') && (current<'A' || current>'Z')) && (current<'0' || current>'9'))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    isValid = false;
                    return;
                }
            }

           
        }

        static void AskForLongerPass (string pass)
        {

            int digitCount = 0;
            for (int i = 0; i < pass.Length; i++)
            {
                char current = pass[i];
                if (current>='0' && current<='9')
                {
                    digitCount++;
                }
            }
            if (digitCount<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
                return;
            }
            
        }
    }
}
