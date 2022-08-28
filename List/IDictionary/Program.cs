using System.Collections.Generic;
namespace IDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int usernamesCount = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for(int i = 0; i < usernamesCount; i++)
            {
                string input = Console.ReadLine();
                usernames.Add(input);
            }
            foreach(var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}