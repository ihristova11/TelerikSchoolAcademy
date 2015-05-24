namespace Task1To4_3DPoint
{
    using System;
    class Task1To4
    {
        static void Main()
        {
            //CREATING TWO POINTS
            Point3D point1 = new Point3D(4, 6, 2);
            Point3D point2 = new Point3D(2, 6, 4);

            //CALCULATING THE DISTANCE BETWEEN THE TWO CREATED POINTS
            System.Console.WriteLine(CalculateDistance.CalculateDistanceBetweenTwoPoints(point1, point2));

            //CREATING TWO PATHS
            Path path1 = new Path();
            Path path2 = new Path();

            //ADDING PATHS
            path1.AddPoints(point1);
            path1.AddPoints(point2);
            path2.AddPoints(point1);
            path2.AddPoints(point2);

            //SAVING THE PATHS IN THE TEXT FILE
            PathStorage.SavePath(path1);
            PathStorage.SavePath(path2);

            for (int i = 0; i < PathStorage.LoadPath().Count; i++)
            {
                Console.Write("Path{0}: ", i + 1);
                for (int j = 0; j < PathStorage.LoadPath()[i].Storage.Count; j++)
                {
                    Console.Write(PathStorage.LoadPath()[i].Storage[j].ToString());
                    if (j < PathStorage.LoadPath()[i].Storage.Count - 1)
                    {
                        Console.Write(" - ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
