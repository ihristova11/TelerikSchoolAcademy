namespace _09.StudentsInGroup2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class ExtensionMethod
    {
        public static List<Student> GetStudentsByGroup(this List<Student> list, int group)
        {
            var groupOfStudents = list.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
            return groupOfStudents.ToList();
        }
        public static List<Student> GetStudentsBy2Marks(this List<Student> list, int mark)
        {
            var groupOfStudents = list.Where(st => st.Marks.Count(x => x == mark) == 2);
            return groupOfStudents.ToList();
        }
    }
}
