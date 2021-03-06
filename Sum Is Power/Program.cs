﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Is_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumIsPower(new int[] { 8, 8, 8 }));
            Console.WriteLine(sumIsPower(new int[] { 8, 8, 8,8 }));
            Console.ReadLine();
        }
        public static int sumIsPower(int[] arr)
        {
            int sum = 0;
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            for (int i = 1; i < Int32.MaxValue; i++)
            {
                result *= 2;

                if (result > sum)
                {
                    break;
                }
                else
                {
                    if (result == sum)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}
