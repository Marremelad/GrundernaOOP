namespace GrundernaOOP
{
    // Class representing a circle.
    public class Circle
    {
        // Private field to store the radius of the circle.
        private double _radius;

        // Constructor to initialize the circle's radius.
        public Circle(double radius)
        {
            // Assign the constructor parameter to the private field.
            this._radius = radius;
        }

        // Method to calculate and display the area of the circle.
        public void GetArea()
        {
            // Area = π * radius^2.
            Console.WriteLine($"Circle Area: {(_radius * _radius) * Math.PI}");
        }

        // Method to calculate and display the diameter of the circle.
        public void GetDiameter()
        {
            // Diameter = 2 * radius.
            Console.WriteLine($"Circle diameter: {_radius * 2}");
        }

        // Method to calculate and display the surface area of a sphere.
        public void GetSphereArea()
        {
            // Surface Area of a sphere = (4/3) * π * radius^3.
            Console.WriteLine($"Area of a sphere with the radius {_radius}: {(4.0/3.0) * (Math.PI) * (Math.Pow(_radius, 3))}");
        }
    }
}