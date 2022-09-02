using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/akcija
    class Akcija
    {
        //public static void Main() => Solution();

        const int groupSize = 3;

        static void Solution()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());
            var books = new int[numberOfBooks];
            var totalCost = 0;
            for (int i = 0; i < numberOfBooks; i++)
            {
                books[i] = int.Parse(Console.ReadLine());
                totalCost += books[i];
            }
            Array.Sort(books, (i1, i2) => i2.CompareTo(i1));

            var discount = CalculateDiscount(books);
            Console.WriteLine(totalCost - discount);
        }

        static int CalculateDiscount(int[] books)
        {
            var discount = 0;
            for (int i = groupSize - 1; i < books.Length; i += groupSize)
            {
                discount += books[i];
            }

            return discount;
        }
    }
}
