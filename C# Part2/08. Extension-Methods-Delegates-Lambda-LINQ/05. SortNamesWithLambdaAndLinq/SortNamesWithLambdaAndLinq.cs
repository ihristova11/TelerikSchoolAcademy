//Using the extension methods OrderBy() and ThenBy()
//with lambda expressions sort the students by first name
//and last name in descending order. Rewrite the same with LINQ.

namespace _05.SortNamesWithLambdaAndLinq
{
    using System;
    using System.Linq;
    class SortNamesWithLambdaAndLinq
    {
        static void Main()
        {
            var students = new[] 
            { 
                new {firstName = "Ivan", lastName = "Kostov"},
                new {firstName = "Petko", lastName = "Georgiev"},
                new {firstName = "Georgi", lastName = "Ivanov"}
            };


            //Sorting with lambda expressions
            var sorted =
                students.OrderByDescending(student => student.firstName)
                .ThenByDescending(student => student.lastName);
            Console.WriteLine("Students names sorted by descending order:");
            foreach (var item in sorted)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }

            Console.WriteLine();

            //Sorting with LINQ
            var sorted1 =
                from student1 in students
                orderby student1.firstName descending, student1.lastName descending
                select student1;
            Console.WriteLine("Students names sorted by descending order:");
            foreach (var item in sorted1)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }
        }
    }
}
