//Write a program that finds the index of given element
//in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

class FindIndexWithBinarySearch
{
        static void Find(int[] arr, int start, int end, int element)
        {                            
                
                int middle = start + (end - start) / 2;

                while (start <= end)
                {
                   
                    if (element < arr[middle])
                    {
                        middle -= 1;
                    }
                    if (element > arr[middle])
                    {                       
                        middle += 1;
                    }
                    if (element == arr[middle])
                    {
                        Console.WriteLine("\nThe index of {0} is {1}.", element, middle);
                        return;
                    }
                }
       
        
                }        
            
        
        static void Main()
        {
            Console.Write("Enter the length of the array: ");
            int Length = int.Parse(Console.ReadLine());
            int[] array = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                Console.Write("Enter element {0}:", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter element for checking: ");
            int element = int.Parse(Console.ReadLine());
            Array.Sort(array);
            Console.WriteLine("\nThe program sorted your array in ascending order! This is the new arrangement:\n ");
                for(int j=0;j<=array.Length-1;j++)
                {
                    Console.WriteLine("Index: {0}, element: {1}.",j,array[j]);
                }
            Find (array, 0, array.Length-1, element);
        }

    }


