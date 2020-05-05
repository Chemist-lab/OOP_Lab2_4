using System;

namespace main
{
    public class Program
    {
        public static string mainProg(int[] numArr)
        {

            int[] arr = new int[5];

            int maxInArr = arr[0], maxInArrPos = 0, max5 = 0, sum = 0;
            for (int i = 0; i < 5; i++)
            {
                arr[i] = numArr[i]; 
            }

            for (int i = 0; i < 5; i++)
            {
                if (arr[i] > 5)
                {
                    max5++;

                }

            }
            Console.WriteLine("\nNum > 5  =  " + max5);

            for (int i = 0; i < 5; i++)
            {
                if (arr[i] > maxInArr)
                {
                    maxInArr = arr[i];
                    maxInArrPos = i;
                }
            }
            for (int i = maxInArrPos + 1; i < 5; i++)
            {
                sum += arr[i];

            }

            string outp = sum + " " + max5;

            //Console.WriteLine("\nSum of Numb > max num - " + sum);

            return outp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Array is");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(mainProg(arr));
            


        }
    }
}
