namespace InsertionSort
{
    internal class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] ary =new int[5] {10, 3, 21, 6, 1 };
            int i, j, temp;
            for(i = 1;i < 5; i++)
            {
                temp = ary[i];
                j = i - 1;
                while(j >= 0 && temp < ary[j])
                {
                    ary[j + 1] = ary[j];
                    j--;
                }
                ary[j + 1] = temp;
            }
            Console.WriteLine("Mang da duoc sap xep:");
            for(i = 0; i< 5; i++)
            {
                Console.Write("{0} ", ary[i]);
            }
            Console.ReadLine();
        }
    }
}