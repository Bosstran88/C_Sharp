namespace AddEmployee
{
    internal class AddEmployee
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Xin chao dai ca {0}",name);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Dai ka hay nhap address:");
            string add = Console.ReadLine();
            Console.WriteLine("Dai ka que "+add+" a");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("sdt cua dai ka la:");
            string phone = Console.ReadLine();
            Console.WriteLine(phone);

        }   
    }
}