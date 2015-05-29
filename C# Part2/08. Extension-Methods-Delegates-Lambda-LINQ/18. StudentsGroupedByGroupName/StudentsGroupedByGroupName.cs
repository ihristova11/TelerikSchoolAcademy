namespace _18.StudentsGroupedByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StudentsGroupedByGroupName
    {
        //TASK 18
        //Create a program that extracts all students
        //grouped by GroupName and then prints them to the console. 
        //Use LINQ.
        static void GroupByGroupNameWithLinq()
        {
            var studentsGroupedByGroupNameWithLinq =
                from student in students
                group student by student.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var currentGroup in studentsGroupedByGroupNameWithLinq)
            {
                Console.WriteLine(currentGroup.Key);

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FullName);
                }
                Console.WriteLine();
            }
        }

        //TASK 19 
        //Rewrite the previous using extension methods.
        static void GroupByGroupNameWithLambda()
        {
            var studentsGroupedByGroupNameWithLambda = students.GroupBy(x => x.GroupName).OrderBy(x => x.Key);

            foreach (var currentGroup in studentsGroupedByGroupNameWithLambda)
            {
                Console.WriteLine(currentGroup.Key);

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FullName);
                }
                Console.WriteLine();
            }
        }

        static Student[] students;
        static void Main()
        {
            students = new Student[]
            {
                new Student("Pesho", "=Art="),
                new Student("Gosho", "=Physics="),
                new Student("Sasho", "=Art="),
                new Student("Mariika", "=Math="),
                new Student("Vankata", "=Physics="),
                new Student("Stamat", "=Math=")
            };

            GroupByGroupNameWithLinq();

            GroupByGroupNameWithLambda();
        }
    }
}
