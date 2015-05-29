//Write a LINQ query that finds the first name
//and last name of all students with age between 18 and 24.

namespace _04.StudentsWithAgeBetween18And24
{
    using System;
    using System.Linq;
    class StudentsWithAgeBetween18And24
    {
        static void Main()
        {
            var students = new[] 
            { 
                new {firstName = "Ivan", lastName = "Kostov", age = 15},
                new {firstName = "Petko", lastName = "Georgiev", age = 20},
                new {firstName = "Georgi", lastName = "Ivanov", age = 23}
            };
            var studentsWithSpecificAge =
                from student in students
                where student.age >= 18 && student.age <= 24
                select student;
            Console.WriteLine("Students between 18 and 24: ");
            foreach (var item in studentsWithSpecificAge)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }
        }
        
    }
}
