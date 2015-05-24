namespace Task1To4_3DPoint
{
    using System;
    public struct Point3D
    {
        //FIELDS
        private int x;
        private int y;
        private int z;
        private static readonly Point3D zeroPoint = new Point3D ( 0, 0, 0 ); //TASK 2 - CREATING A ZEROPOINT


        //CONSTRUCTORS
        public Point3D(int firstCoordinate, int secondCoordinate, int thirdCoordinate)
        {
            this.x = firstCoordinate;
            this.y = secondCoordinate;
            this.z = thirdCoordinate;
        }


        //PROPERTIES
        public int CoordinateX
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int CoordinateY
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public int CoordinateZ
        {
            get { return this.z; }
            set { this.z = value; }
        }
        public static Point3D ZeroPoint//TASK 2 - PROPERTY FOR THE ZEROPOINT
        {
            get { return zeroPoint; }
        }


        //METHODS
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", CoordinateX, CoordinateY, CoordinateZ);
        }
    }
}
