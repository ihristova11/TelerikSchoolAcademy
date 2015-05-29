
namespace StudentSystem.Model
{
    using System;
    using System.Collections.Generic;
    public class Students
    {
        private ICollection<Courses> courses;
        private ICollection<Homework> homework; 

        public Students() 
        {
            this.courses = new HashSet<Courses>();
            this.homework=new HashSet<Homework>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Number { get; set; }
        public virtual ICollection<Courses> Courses 
        {
            get 
            {
                return this.courses;
            }
            set 
            {
                this.courses = value;
            }
        
        }
        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homework; }
            set {this.homework=value; }
        }





    }
}
