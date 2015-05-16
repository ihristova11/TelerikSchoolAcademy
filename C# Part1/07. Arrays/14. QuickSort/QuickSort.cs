//Write a program that sorts an array of strings
//using the quick sort algorithm (find it in Wikipedia).

using System;

class QuickSort
{
   public static void Quicksort(string[] element, int left, int right)
        {
            int i = left, j = right;
            string mid = element[(left + right) / 2];

            while (i <= j)
            {
                while (element[i].CompareTo(mid) < 0)
                {
                    i++;
                }

                while (element[j].CompareTo(mid) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                  
                    string Temp = element[i];
                    element[i] = element[j];
                    element[j] = Temp;

                    i++;
                    j--;
                }
            }

            
            if (left < j)
            {
                Quicksort(element, left, j);
            }

            if (i < right)
            {
                Quicksort(element, i, right);

            }
         }
    

        static void Main()
        {
            Console.Write("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            string[] array = new string[length];
            for (int counter = 0; counter < length; counter++)
            {
                Console.Write("Enter element {0}:",counter);
                array[counter] =Console.ReadLine();
            }               

          
            Quicksort(array, 0, array.Length - 1);
          
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }    
    }


