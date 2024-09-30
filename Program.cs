namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\nChoose a shape to calculate the area:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Triangle");
                Console.WriteLine("3. Square");
                Console.WriteLine("4. Rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice (0-4): ");


                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 4.");
                }

                switch (choice)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateTriangleArea();
                        break;
                    case 3:
                        CalculateSquareArea();
                        break;
                    case 4:
                        CalculateRectangleArea();
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program.");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            } while (choice != 0);
        }

        static void CalculateCircleArea()
        {
            double radius;
            while (true)
            {
                Console.WriteLine("Enter the radius of the Circle:");
                if (double.TryParse(Console.ReadLine(), out radius))
                    break;
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            Shape C = new Circle(radius);
            Console.WriteLine($"Area of Circle: {C.Area()}");
        }

        static void CalculateTriangleArea()
        {
            double triangleBase, triangleHeight;
            while (true)
            {
                Console.WriteLine("Enter the base of the Triangle:");
                if (double.TryParse(Console.ReadLine(), out triangleBase))
                    break;
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            while (true)
            {
                Console.WriteLine("Enter the height of the Triangle:");
                if (double.TryParse(Console.ReadLine(), out triangleHeight))
                    break;
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            Shape T = new Triangle(triangleBase, triangleHeight);
            Console.WriteLine($"Area of Triangle: {T.Area()}");
        }

        static void CalculateSquareArea()
        {
            double squareSide;
            while (true)
            {
                Console.WriteLine("Enter the side length of the Square:");
                if (double.TryParse(Console.ReadLine(), out squareSide))
                    break;
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            Shape S = new Square(squareSide);
            Console.WriteLine($"Area of Square: {S.Area()}");
        }

        static void CalculateRectangleArea()
        {
            double rectangleWidth, rectangleHeight;
            while (true)
            {
                Console.WriteLine("Enter the width of the Rectangle:");
                if (double.TryParse(Console.ReadLine(), out rectangleWidth))
                    break;
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            while (true)
            {
                Console.WriteLine("Enter the height of the Rectangle:");
                if (double.TryParse(Console.ReadLine(), out rectangleHeight))
                    break;
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            Shape R = new Rectangle(rectangleWidth, rectangleHeight);
            Console.WriteLine($"Area of Rectangle: {R.Area()}");

        }

        public class Shape
        {
            protected double length;
            protected double width;

            public virtual double Area()
            {
                return 0;
            }
        }

        public class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override double Area()
            {
                return Math.PI * radius * radius; // Area = πr²
            }
        }

        public class Triangle : Shape
        {
            private double @base;
            private double height;

            public Triangle(double @base, double height)
            {
                this.@base = @base;
                this.height = height;
            }

            public override double Area()
            {
                return 0.5 * @base * height; // Area = 1/2 * base * height
            }
        }

        public class Square : Shape
        {
            private double side;

            public Square(double side)
            {
                this.side = side;
            }

            public override double Area()
            {
                return side * side; // Area = side²
            }
        }

        public class Rectangle : Shape
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public override double Area()
            {
                return width * height; // Area = width * height
            }
        }
    }
}
