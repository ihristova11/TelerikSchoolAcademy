namespace Task1To4_3DPoint
{
    using System;
    using System.Collections.Generic;
    public class Path
    {
        //FIELDS
        private List<Point3D> storage = new List<Point3D>();


        //PROPERTIES
        public List<Point3D> Storage
        {
            get { return storage; }
        }


        //METHODS
        public void AddPoints(Point3D point)
        {
            storage.Add(point);
        }
    }
}
