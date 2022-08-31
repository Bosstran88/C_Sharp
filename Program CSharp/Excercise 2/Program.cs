namespace Excercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

        }
        abstract class Animal
        {
            public string Name { get; set; }

            public double Weight { get; set; }
            public Animal() { }
            public Animal(string name, double weight)
            {
                Name = name;
                Weight = weight;
            }
            public override string ToString()
            {
                return base.ToString();
            }
            public static void Show()
            {
                Console.WriteLine("Name : {0}, Weight: {1}",)
            }
        }
    }
}