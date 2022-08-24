namespace Lession3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = new string[5];
            weekdays[0] = " Sunday";
            weekdays[1] = "Monday";
            weekdays[2] = "Tuesday";
            weekdays[3] = "wednesday";
            weekdays[4] = "Thurday";

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(weekdays[i].ToString());
            }
           
            Console.ReadLine();
        }
    }
}