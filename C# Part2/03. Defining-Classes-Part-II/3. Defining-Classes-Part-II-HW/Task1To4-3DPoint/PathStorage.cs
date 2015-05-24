namespace Task1To4_3DPoint
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public static class PathStorage
    {
        //FIELDS
        private static string someString = null;


        //METHODS
        public static void SavePath(Path somePath)
        {
            try
            {
                StreamWriter writer = new StreamWriter("storage.txt");
                using (writer)
                {
                    for (int count = 0; count < somePath.Storage.Count; count++)
                    {
                        someString += somePath.Storage[count] + " ";
                    }
                    writer.WriteLine(someString);
                    someString += Environment.NewLine;
                }
            }
            catch (IOException io)
            {
                Console.WriteLine("Error!" + io.Message);
            }
            catch
            {
                Console.WriteLine("Unknown error!");
            }
        }

        public static List<Path> LoadPath()
        {
            List<Path> paths = new List<Path>();
            try
            {
                StreamReader reader = new StreamReader("storage.txt");
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] arr = line.Split(' ');
                        Path pa = new Path();
                        foreach (string st in arr)
                        {
                            if (st != string.Empty)
                            {
                                int x = (int)(st[0] - 48);
                                int y = (int)(st[2] - 48);
                                int z = (int)(st[4] - 48);
                                pa.AddPoints(new Point3D(x, y, z));
                            }
                        }
                        paths.Add(pa);
                        line = reader.ReadLine();

                    }
                }
            }
            catch (IOException io)
            {
                Console.WriteLine("Error!" + io.Message);
            }
            catch
            {
                Console.WriteLine("Unknown error!");
            }
            return paths;
        }
    }
}
