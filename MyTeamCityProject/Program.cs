using System;

namespace MyTeamCityProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGreeting());
        }

        public static string GetGreeting() => "Hello, TeamCity!";
    }
}
