//Write a method that from a given array of 
//students finds all students whose first name
//is before its last name alphabetically. 
//Use LINQ query operators.

namespace _03.StudentsWithFirstNameBeforeTheLast
{
    using System;
    using System.Linq;
    public class StudentsWithFirstNameBeforeTheLast
    {
        static void Main()
        {
            var students = new[] 
            { 
                new {firstName = "Ivan", lastName = "Kostov"},
                new {firstName = "Petko", lastName = "Georgiev"},
                new {firstName = "Georgi", lastName = "Ivanov"}
            };
            var comparedNames =
                from student in students
                where student.firstName.CompareTo(student.lastName) < 0
                select student;
            Console.WriteLine("Students whose first name is before their last:");
            foreach (var item in comparedNames)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }
        }
    }
}
