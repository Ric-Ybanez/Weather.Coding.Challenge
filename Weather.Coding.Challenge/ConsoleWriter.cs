using System;
using System.Collections.Generic;
using System.Text;
using Weather.Coding.Challenge.Services;

namespace Weather.Coding.Challenge
{
    public static class ConsoleWriter
    {
        public static void ExitApplication()
        {
            Console.WriteLine("Press any key to exit application..");
            Console.ReadLine();
        }

        public static void PrintOutput(ServiceResponse response)
        {
            if (response == null) 
            {
                Console.WriteLine("Invalid zipcode provided");
                ExitApplication();
                return;
            }
                
            Console.WriteLine("Should I go outside?");

            Console.WriteLine(response.IsShouldGoOutSide ? "Yes" : "No");

            Console.WriteLine("Should I wear sunscreen?");

            Console.WriteLine(response.IsShouldWearSunScreen ? "Yes" : "No");

            Console.WriteLine("Can I fly my kite?");

            Console.WriteLine(response.IsCanFlyKite ? "Yes" : "No");
        }

        public static string ReadZipCode() 
        {
            Console.WriteLine("Please input zipcode: ");
            string zipCode = Console.ReadLine();
            return zipCode;
        }

        
    }
}
