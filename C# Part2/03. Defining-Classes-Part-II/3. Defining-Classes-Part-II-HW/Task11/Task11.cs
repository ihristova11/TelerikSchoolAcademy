namespace Task11
{
    using System;
    [Version("0.01")]
    class Task11
    {
        static void Main()
        {
            Type type = typeof(Task11);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAtribute in allAttributes)
            {
                Console.WriteLine("Version: {0} ",
                    versionAtribute.Version);
            }
        }
    }
}
