namespace StudentSystem.Model
{
    using System;
    public class Homework
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime TimeSent { get; set; }
        public Guid CorsesId { get; set; }
        public virtual Courses Courses { get; set; }
        public int StudentsId { get; set; }
        public virtual Students Student { get; set; }


    }
}
