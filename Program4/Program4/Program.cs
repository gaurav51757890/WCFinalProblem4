using System;
using System.Collections.Generic;

namespace Program4
{
    class Program
    {
        /// <summary>
        /// Program to find the duplicate numbers in an array. If duplicate returns true else return false.
        /// Size of the array should be between 1 and 105.
        /// Elements should be in the range of -109 and 109.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Input the size of the element to store in the array : ");
            Console.WriteLine("------------------------------------------------------------------------\n");
            int Size = Convert.ToInt32(Console.ReadLine().Trim());

            int[] nums = new int[Size];
            var setofNumbers = new HashSet<int>();

            if (Size > 105 || Size < 1)
            {
                Console.WriteLine("Size should be between 1 and 105");
                return;
            }
            else
            {
                Console.WriteLine("Input the elements of array :");
                for (int i = 0; i < Size; i++)
                {
                    int input = Convert.ToInt32(Console.ReadLine().Trim());
                    if (input > 109 || input < -109)
                    {
                        Console.WriteLine("Value entered should be between -109 and 109");
                        return;
                    }
                    else
                    {
                        if (setofNumbers.Contains(input))
                        {
                            Console.WriteLine("Arrays Elements are duplicate:" + true);
                            return;
                        }
                        nums[i] = input;
                        setofNumbers.Add(nums[i]);
                    }
                }
                Console.WriteLine("Arrays Elements are not duplicate :" + false);
            }
        }
    }
}
