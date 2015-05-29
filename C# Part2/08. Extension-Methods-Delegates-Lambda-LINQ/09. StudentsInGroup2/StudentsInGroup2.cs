namespace _09.StudentsInGroup2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StudentsInGroup2
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
                {
                    new Student("Ivan", "Ivanov", 326541, "0123456", "ivan11@abv.bg", new List<int> { 2, 3, 2, 5, 4 }, 1),
                    new Student("Petar", "Petrov", 325486, "0233466", "pesho_petrov@abv.bg", new List<int> { 6, 4, 4, 5 , 6 }, 3),
                    new Student ("Georgi", "Hristov", 326556, "0223456", "ghristov@abv.bg", new List<int> { 5, 6, 5, 5, 6 }, 2)
                };
            //TASK 9
            //Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), 
            //GroupNumber. Create a List<Student> with sample students. Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.
            Console.WriteLine("-------------------Students from Group 2 in descending order-------------------");
            var group2Students = students.Where(student => student.GroupNumber == 2).OrderBy(student => student.FirstName);
            foreach (var item in group2Students)
            {
                Console.WriteLine("{0} {1} {2}", item.FirstName, item.LastName, item.FN);
            }

            Console.WriteLine();

            //TASK 10
            //Implement the previous using the same query 
            //expressed with extension methods.
            Console.WriteLine("-------------------Students from Group 2 in descending order-------------------");
            var groupTwoStudents = students.Where(student => student.GroupNumber == 2).OrderBy(st => st.FirstName);
            foreach (var item in groupTwoStudents)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.FirstName, item.LastName, item.FN, item.GroupNumber);
            }

            Console.WriteLine();

            //TASK 11
            //Extract all students that have email in abv.bg. Use string methods and LINQ.
            Console.WriteLine("--------------------------Students with email in ABV--------------------------");
            var studentsWithABVMail = students.Where(student => student.Email.Substring(student.Email.IndexOf('@') + 1) == "abv.bg");
            foreach (var item in studentsWithABVMail)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.FirstName, item.LastName, item.Email, item.GroupNumber);
            }

            Console.WriteLine();

            //Task 12
            //Extract all students with phones in Sofia. Use LINQ.
            Console.WriteLine("--------------------------Students with Sofia phones--------------------------");
            var studentsWithSofiaPhone = students.Where(student => student.Tel.ToString().Substring(0, 2) == "02");
            foreach (var item in studentsWithSofiaPhone)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.FirstName, item.LastName, item.Tel, item.GroupNumber);
            }

            Console.WriteLine();

            //TASK 13
            //Select all students that have at least one mark Excellent (6) 
            //into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            Console.WriteLine("-------------------Students with at least one excellent mark-------------------");
            var studentsWithAtLeastOneSixMark = from student in students
                                                where student.Marks.Contains(6)
                                                select new { fullName = student.FirstName + " " + student.LastName, Marks = student.Marks };
            foreach (var student in studentsWithAtLeastOneSixMark)
            {
                Console.WriteLine(student.fullName + " { " + string.Join(" ", student.Marks) + " }");
            }

            Console.WriteLine();

            //TASK 14
            //Write down a similar program that extracts the students with exactly 
            //two marks "2". Use extension methods.
            Console.WriteLine("--------------------------Students with 2 F marks--------------------------");
            List<Student> studentsWith2Marks = students.GetStudentsBy2Marks(2);
            foreach (var item in studentsWith2Marks)
            {
                Console.WriteLine("{0} {1} " + string.Join(" ", item.Marks), item.FirstName, item.LastName);
            }

            Console.WriteLine();

            //TASK 15
            //Extract all Marks of the students that enrolled in 2006.
            //(The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            Console.WriteLine("-----------------------Marks of the students from 2006------------------------");
            var marksOfStudentsEnrolled2006 = students.Where(student => student.FN.ToString().Substring(4, 2) == "06");
            foreach (var student in marksOfStudentsEnrolled2006)
            {
                Console.WriteLine(string.Join(" ", student.Marks));
            }
        }
    }
}
