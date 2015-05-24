namespace Task1To4_3DPoint
{
    using System;
    //TASK 3
    public static class CalculateDistance
    {
        //METHOD
        public static double CalculateDistanceBetweenTwoPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double distanceBetweenPoints = Math.Sqrt(Math.Pow(secondPoint.CoordinateX - firstPoint.CoordinateX, 2) + Math.Pow(secondPoint.CoordinateY - firstPoint.CoordinateY, 2) + Math.Pow(secondPoint.CoordinateZ - firstPoint.CoordinateZ, 2));
            return distanceBetweenPoints;
        }
    }
}
