using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation
{
    class Program
    {
        static String message = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots.So far, the universe is winning";
        static void Main(string[] args)
        {
            Console.WriteLine(message);

            Console.WriteLine("What word do you want to look for in the above statement");
            string UserResponse = Console.ReadLine();

            Console.WriteLine($"What word do you want to change {UserResponse} to ?");
            string UserResponse2 = Console.ReadLine();

            if (message.Contains(UserResponse))
            {
                string NewMessage = message.Replace(UserResponse,UserResponse2);
                Console.WriteLine(NewMessage);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {UserResponse} " );
                for (int i = UserResponse.Length - 1; i>=0; i --)
                {
                    Console.WriteLine(UserResponse[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
