namespace Model
{

    public class Point
    {
        private float[] coordinates = {0, 0, 0, 1};

        public float X
        {
            get { return coordinates[0]; }
            set { coordinates[0] = value; }
        }

        public float Y
        {
            get { return coordinates[1]; }
            set { coordinates[1] = value; }
        }

        public float Z
        {
            get { return coordinates[2]; }
            set { coordinates[2] = value; }
        }

        public Point() { }

        public Point(float x, float y)
        {
            coordinates[0] = x;
            coordinates[1] = y;
        }

        public Point(float x, float y, float z)
        {
            coordinates[0] = x;
            coordinates[1] = y;
            coordinates[2] = z;
        }

        private Point(float x, float y, float z, float all)
        {
            coordinates[0] = x;
            coordinates[1] = y;
            coordinates[2] = z;
            coordinates[3] = all;
        }

        /// <summary>
        /// Creates deep copy of the Point object.
        /// </summary>
        /// <returns>Point</returns>
        public Point DeepCopy()
        {
            return new Point(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);
        }

        /// <summary>
        /// Divide all members in the array by the last one. 
        /// This done to apply transformations to the Point that affect all dimesions.
        /// </summary>
        private void Normalize()
        {
            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = coordinates[i] / coordinates[3];
            }
        }
    }
}