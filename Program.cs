using System;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = viralAdvertising(n);

            Console.WriteLine(result);
        }

        private static int viralAdvertising(int n)
        {
            int likedCount, sumLikedCount = 0;
            int sharedCount = 5;
            for (int i = 0; i < n; i++)
            {
                likedCount = (sharedCount / 2);
                sharedCount = likedCount * 3;
                sumLikedCount += likedCount;
            }

            return sumLikedCount;
        }
    }
}
