
namespace _18.StudentsGroupedByGroupName
{
    using System;
    using System.Linq;
    public class Student
    {
        //Properties
        public Student(string fullName, string groupName)
        {
            this.FullName = fullName;
            this.GroupName = groupName;
        }
        public string FullName { get; private set; }
        public string GroupName { get; private set; }
    }
}
