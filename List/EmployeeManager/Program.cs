using System.Collections;
namespace EmployeeManager
{
    public class Employee
    {
        private int id;
        private string name;
        private int age;
        private double salary;

        public Employee(int id, string name, int age, double salary)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }
        public Employee() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return string.Format("{1} | {2} | {3} | {4}", id, name, age, salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList adc = new ArrayList();

            int choose =0;
            while (true)
            {
                Menu();
                string choose = Console.ReadLine();

            }
                
            
        }
        public static void Menu()
        {
            Console.WriteLine("1: Add Employee");
            Console.WriteLine("2: Delete Employee");
            Console.WriteLine("3: Update Emply");
            Console.WriteLine("4: Show Display");
        }
    }

   
}