namespace BubbleSort
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5] { 10, 3, 21, 6, 1 };
            int i, j, tmp;

            for(i=0; i < 5; ++i)
                for(j=0; j < 5 - i -1; ++j)
                {
                    if(ary[j] > ary[j + 1])
                    {
                        tmp = ary[j];
                        ary[j] = ary[j + 1];
                        ary[j + 1] = tmp;
                    }
                }
            Console.WriteLine("Mang da sap xep");
            for (i = 0; i < 5; ++i)
                Console.WriteLine("{0}", ary[i]);
            Console.ReadLine();
        }
        
    }
}