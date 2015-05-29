namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Model;
    public class StudentSystemDbContext: DbContext
    {
        public IDbSet<Homework> Homeworks { get; set; }
        public IDbSet<Students> Students { get; set; }

        public IDbSet<Courses> Courses { get; set; }



    }
}
