using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
               
                 throw new ArgumentOutOfRangeException("Sides should be positive.");
                
            }
            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return area;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero"; break;
                case 1: return "one"; break;
                case 2: return "two"; break;
                case 3: return "three"; break;
                case 4: return "four"; break;
                case 5: return "five"; break;
                case 6: return "six"; break;
                case 7: return "seven"; break;
                case 8: return "eight"; break;
                case 9: return "nine"; break;
                default: throw new ArgumentException("Number is not a digit!"); break;
            }

            
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("No elements");
            }

            int max = Int32.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }


        public static void PrintNumberWithPrecisionTwo(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintNumberMultipliedByHundredPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintWithAlignmentEight(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static bool CheckIfItsHorisontal(double y1, double y2)
        {
            bool isHorizontal = (y1 == y2);

            return isHorizontal;
        }

        public static bool CheckIfItsVertical(double x1, double x2)
        {
            bool isVertical = (x1 == x2);

            return isVertical;
        }
        static double CalcDistanceIn2D(double x1, double y1, double x2, double y2)
        {
            if (y1 == y2 && x1 == x2)
            {
                throw new ArgumentException("There is no distance between points!");
            }
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintNumberWithPrecisionTwo(1.3);
            PrintNumberMultipliedByHundredPercent(0.75);
            PrintWithAlignmentEight(2.30);
            Console.WriteLine(CalcDistanceIn2D(3, -1, 3, 2.5));
            Console.WriteLine("It is {0} that the line is horizontal. ", CheckIfItsVertical(2, 2));
            Console.WriteLine("It is {0} that the line is vertical. " + CheckIfItsVertical(3, 3));

            Student ivan = new Student("Ivan", "Ivanov", "17.03.1992");

            Student pesho = new Student("Pesho", "Peshov", "03.11.1993");


            Console.WriteLine("{0} older than {1} -> {2}",
                ivan.FirstName, pesho.FirstName, ivan.IsOlderThan(pesho));
        }
    }
}
