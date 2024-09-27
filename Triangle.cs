namespace GrundernaOOP
{
    // Class representing a triangle.
    public class Triangle
    {
        // Private fields to store the base and height of the triangle.
        private double _triangleBase;
        private double _triangleHeight;

        // Constructor to initialize the triangle's base and height.
        public Triangle(double triangleBase, double triangleHeight)
        {
            // Assign constructor parameters to the private fields.
            this._triangleBase = triangleBase;
            this._triangleHeight = triangleHeight;
        }

        // Method to calculate and display the hypotenuse of the triangle
        public void GetHypotenuse()
        {
            // Using the Pythagorean theorem to calculate the hypotenuse.
            // Hypotenuse = sqrt(base^2 + height^2).
            Console.WriteLine($"Hypotenuse of a triangle with the base {_triangleBase} and height {_triangleHeight}: {Math.Sqrt((Math.Pow(_triangleBase, 2)) + (Math.Pow(_triangleHeight, 2)))}");
        }

        // Method to calculate and display the area of the triangle.
        public void GetArea()
        {
            // Area = 0.5 * base * height.
            Console.WriteLine($"Area of a triangle with the base {_triangleBase} and height {_triangleHeight}: {0.5 * (_triangleBase * _triangleHeight)}");
        }
    }
}