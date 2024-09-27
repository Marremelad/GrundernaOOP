namespace GrundernaOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Circle with a radius of 5.
            Circle circle = new Circle(5);
            
            // Create an instance of Triangle with a base of 3 and height of 15.37.
            Triangle triangle = new Triangle(3, 15.37);
            
            // Call the method to calculate and display the area of the circle.
            circle.GetArea();
            
            // Call the method to calculate and display the diameter of the circle.
            circle.GetDiameter();
            
            // Call the method to calculate and display the surface area of the sphere.
            circle.GetSphereArea();
            
            // Call the method to calculate and display the hypotenuse of the triangle.
            triangle.GetHypotenuse();
            
            // Call the method to calculate and display the area of the triangle.
            triangle.GetArea();
        }
    }
}