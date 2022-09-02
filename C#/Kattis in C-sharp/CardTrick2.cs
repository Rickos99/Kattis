using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/cardtrick2
    class CardTrick2
    {
        //public static void Main() => Solution();

        public static void Solution()
        {
           int cases = int.Parse(Console.ReadLine());
           while (cases-- > 0)
           {
               int cards = int.Parse(Console.ReadLine());
               int[] shuffle = Shuffle(cards);
               Console.WriteLine(string.Join(" ", shuffle));
           }
        }

        public static int[] Shuffle(int numberOfCards)
        {
            int[] cards = new int[0];
            while (numberOfCards > 0)
            {
                AddValueToFirstPositionInArray(ref cards, numberOfCards);
                RotateArrayRight(ref cards, numberOfCards);
                numberOfCards--;
            }
            return cards;
        }

        private static void RotateArrayRight<T>(ref T[] arr)
        {
            T[] rotArr = new T[arr.Length];
            rotArr[0] = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                rotArr[i + 1] = arr[i];
            }
            arr = rotArr;
        }

        private static void RotateArrayRight<T>(ref T[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                RotateArrayRight(ref arr);
            }
        }

        private static void AddValueToFirstPositionInArray<T>(ref T[] arr, T val)
        {
            T[] resArr = new T[arr.Length + 1];
            resArr[0] = val;
            for (int i = 0; i < arr.Length; i++)
            {
                resArr[i + 1] = arr[i];
            }
            arr = resArr;
        }
    }
}
