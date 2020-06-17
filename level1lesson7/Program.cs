using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static int SumOfThe(int N, int[] data)
        {
            int temp = 0;
            if (N<2)
            {
                Console.WriteLine("initial conditions is not correct");
                return temp;
            }
            if (N != data.Length)
            {
                Console.WriteLine("initial conditions is not correct");
                return temp;
            }
            int sum = 0;
           
            foreach (int s in data) sum = sum + s;
            //Console.WriteLine("sum =" + sum);

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == (sum - data[i]))
                {
                    temp = data[i];
                    return data[i];
                }
            }
            Console.WriteLine("initial conditions is not correct");
            return temp;
        }

        //static void Main(string[] args)
        //{
        //    //int[] data = { -1,2,-3,4,-5,6,-7,8};
        //    //int sum = 0;
        //    //int temp;
        //    //int N = data.Length;
        //    //temp = SumOfThe(N, data);
        //    //Console.WriteLine("сумма =" + temp);
        //    //foreach (int s in data) sum = sum + s;
        //    //Console.WriteLine("sum =" + sum);

        //    //for (int i = 0; i < data.Length; i++)
        //    //{
        //    //    if (data[i] == (sum - data[i]))
        //    //    {
        //    //        temp = data[i];
        //    //        Console.WriteLine("сумма =" + temp);
        //    //    }

        //    //}

        //}
    }
}
