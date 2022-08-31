namespace EmployeeInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INPUT INFORMATION\n=========");

                Console.Write("\nEnter ID:");
                string id = Console.ReadLine();

                Console.WriteLine("\nEnter First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("\nEnter Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("\nEnter Email:");
                string email = Console.ReadLine();

                Console.WriteLine("\nEnter Phone Number:");
                string phone = Console.ReadLine();

                Console.WriteLine("\nEnter Date Of Birth (mm/dd/yyyy):");
                DateTime dateOfBarth = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Joining date (mm/dd/yyyy):");
                DateTime JoiningDateTime = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("\nDESIGNATION:\n===============" +
                    "\n1.CEO\n2.President\n3.SoftwareEngineer\n4.TraineeEngineer\n5.ProjectManager" +
                    "\n6.SystemEngineer\n7.Webdeveloper\n8.QualityAnalyst");
                Console.Write("\nInput any one serial number of designations given above:");
                int deg =Int32.Parse(Console.ReadLine());
                Employee anEmployee = new Employee(id, firstName, lastName, email, phone, dateOfBarth, JoiningDateTime, deg);

                string[] roles = anEmployee.GetRole(Console.ReadLine());
                Console.WriteLine("\nOUTPUT\n============");
                Console.WriteLine("\nEmployee ID:" + anEmployee.ID + "\nName: " + anEmployee.GetFullName() +
                    "\nDateOFBirth: " + anEmployee.DateOfBirth.ToShortDateString() + "\nJoiningDate: " +
                    anEmployee.JoiningDateTime.ToShortDateString() + "\nDesignation: " + anEmployee.Designation +
                    "\nAge:" + anEmployee.GetAge() + "\n\nRole plays:\n======");

                for(int i = 0; i <roles.Length; i++)
                {
                    Console.WriteLine((i+1).ToString() + "-" + roles[i].Trim());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            doSalary();
            Console.ReadLine();
        }
        static void doSalary()
        {
            Console.WriteLine("\n\nSALARY CALCULATE: \n=========");
            Console.WriteLine("Input basic salary:");
            var bs = Console.ReadLine();
            Salary s = new Salary();

            var bsReturn = s.CalculateSalary(Convert.ToInt32(bs));
            var overTime = s.CalculateSalary(Convert.ToInt32(bs));

            Console.WriteLine(">>Basic Salary:        {0}/={1}", s.basicSalary, s.currency);
            Console.WriteLine(">>Hour Rent :          {0}/={1}", s.hoursRent, s.currency);
            Console.WriteLine(">>Medical Allowance    {0}/={1}", s.medicalAllowance, s.currency);
            Console.WriteLine(">>Conveyance Allowance {0}/={1}", s.conveyance, s.currency);
            Console.WriteLine(">> Over Time:          {0}/={1}", s.overtime, s.currency);
            Console.WriteLine("....................");
            Console.WriteLine("    Gross Salary:      {0}/={1}", bsReturn, s.currency);

            

        }
    }
}