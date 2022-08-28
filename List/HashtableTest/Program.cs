using System.Collections;
namespace HashtableTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("a", "A");
            ht.Add("b", "B");
            ht.Add("c", "C");
            ht.Add("e", "E");
            ht.Add("f", "F");

            ICollection c = ht.Keys;
            foreach (string str in c)
                Console.WriteLine(str + ": " + ht[str]);
        }
    }
}