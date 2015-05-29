using System;

namespace Methods
{
    class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public string Town { get; set; }

        public string Hobby { get; set; }

        public Student(string firstName, string lastName, string dateOfBirth, string town = null, string hobby = null)
        {
            DateTime parsedDayOfBirth;
            if (!DateTime.TryParse(dateOfBirth, out parsedDayOfBirth))
            {
                throw new FormatException("Incorrect date format!");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = parsedDayOfBirth;
            this.Town = town;
            this.Hobby = hobby;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new ArgumentException("First name can't be null!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length == 0 || value == null)
                {
                    throw new ArgumentException("Second name can't be null!");
                }

                this.lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                if (value.Year > DateTime.Now.Year || value.Year < 1850)
                {
                    throw new ArgumentException("Inavlid birthday. The person isn't borned yet or there is no such an old person!");
                }

                this.birthDate = value;
            }
        }

        public bool IsOlderThan(Student otherStudent)
        {
            bool isOlder = this.DateOfBirth > otherStudent.DateOfBirth;
            return isOlder;
        }
        
    }
}
