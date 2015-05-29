namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Model;
    public class StudentSystemConsoleClient
    {
        
        public static void Main()
        {
            var db = new StudentSystemDbContext();
            var student = new Students
            {
                Age = 16,
                FirstName = "Ivan",
                LastName = "Peshov",

            };
            db.Students.Add(student);
            db.SaveChanges();
            var savedStudent = db.Students.First();
            Console.WriteLine(savedStudent.Id + " " + savedStudent.FirstName +  " " + savedStudent.LastName);


        }
        
    }
}
