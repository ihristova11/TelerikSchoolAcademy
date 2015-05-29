namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    public class Courses
    {
        private ICollection<Students> students;
        private ICollection<Homework> homework;
        public Courses() 
        {
          this.Id = Guid.NewGuid();
          this.students = new HashSet<Students>();
          this.homework = new HashSet<Homework>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Materials { get; set; }
        public virtual ICollection<Students> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }

        }
        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homework;
            }
            set
            {
                this.homework = value;
            }

        }
       

    }
}
