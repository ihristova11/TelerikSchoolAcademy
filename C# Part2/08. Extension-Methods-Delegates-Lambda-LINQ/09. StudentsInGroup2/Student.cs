namespace _09.StudentsInGroup2
{
    using System;
    using System.Collections.Generic;
    public static class Student
    {
        //Fields
        private string firstName;
        private string lastName;
        private int fn;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;


        //Constructors
        public Student(string firstName, string lastName, int fn, string tel, string email, List<int>marks, int groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.fn = fn;
            this.tel = tel;
            this.email = email;
            this.marks = marks;
            this.groupNumber = groupNumber;
        }


        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; } 
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int FN
        {
            get { return this.fn; }
            set { this.fn = value; }
        }
        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

    }
}
