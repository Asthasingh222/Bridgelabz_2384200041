using System;

    // Circle class with attributes and methods
    class Circle
    {
        // Private attribute
        private double radius;

        // Constructor to initialize radius
        public Circle(double r)
        {
            radius = r;
        }

        // Method to calculate area
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate circumference
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        // Method to display area and circumference
        public void DisplayDetails()
        {
            Console.WriteLine("Circle with Radius: " + radius);
            Console.WriteLine("Area: " + CalculateArea());
            Console.WriteLine("Circumference: " + CalculateCircumference());
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a Circle object
            Circle circle = new Circle(5);

            // Displaying Circle details
            circle.DisplayDetails();
        }
    }

