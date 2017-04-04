using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class MidTerm
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arg1 = random.Next(10);

            Circle circle = new Circle(arg1, "Circle A");
            Square square = new Square(arg1, "Square A");
            Sphere sphere = new Sphere(arg1, "Sphere A");
            Cube cube = new Cube(arg1, "Cube A");

            Shape[] shapeArray = new Shape[] { circle, square, sphere, cube };
            PrintValues(shapeArray);

            // redunant example ft. inheritance checks for TwoDimensionalShape vs. ThreeDimensionalShape

            foreach (Shape i in shapeArray)
            {
                if (i.GetType().BaseType.Name == "TwoDimensionalShape")
                    Console.WriteLine(i.Id + " Area         = " + i.Area);
                else if (i.GetType().BaseType.Name == "ThreeDimensionalShape")
                {
                    ThreeDimensionalShape x = (ThreeDimensionalShape)i;

                    Console.WriteLine(x.Id + " Surface Area = " + x.Area);
                    Console.WriteLine(x.Id + " Volume       = " + x.Volume);
                }
            }
            Console.WriteLine();

            // testing section
            /*Console.WriteLine(circle.Id + " Area: " + circle.Area);
            Console.WriteLine();
            Console.WriteLine(circle.ToString());
            Console.WriteLine();
            
            Console.WriteLine(square.Id + " Area: " + square.Area);
            Console.WriteLine();
            Console.WriteLine(square.ToString());
            Console.WriteLine();
            
            Console.WriteLine(sphere.Id + " Surface Area: " + sphere.Area);
            Console.WriteLine(sphere.Id + " Volume: " + sphere.Volume);
            Console.WriteLine();
            Console.WriteLine(sphere.ToString());
            Console.WriteLine();
            
            Console.WriteLine(cube.Id + " Surface Area: " + cube.Area);
            Console.WriteLine(cube.Id + " Volume: " + cube.Volume);
            Console.WriteLine();
            Console.WriteLine(cube.ToString());
            Console.WriteLine();*/
        }
        public static void PrintValues(Shape[] myArr)
        {
            foreach (Shape i in myArr)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
        }
    }
    public abstract class Shape
    {
        // name of shape
        private string name;

        public Shape(string s)
        {
            // calling the set accessor of the Id property.
            Id = s;
        }

        public string Id
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // Area is a read-only property - only a get accessor is needed:
        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return Id + " Area         = " + string.Format("{0:F2}", Area) + "\n";
        }
    }
    // Shape derived classes
    public abstract class TwoDimensionalShape : Shape
    {
        public TwoDimensionalShape(string id) : base(id)
        {
            this.Id = id;
        }
    }
    public abstract class ThreeDimensionalShape : Shape
    {
        public ThreeDimensionalShape(string id) : base(id)
        {
            this.Id = id;
        }

        // Volume is a read-only property - only a get accessor is needed:
        public abstract double Volume
        {
            get;
        }

        public override string ToString()
        {
            return Id + " Surface Area = " + string.Format("{0:F2}", Area) + "\n"
                 + Id + " Volume       = " + string.Format("{0:F2}", Volume) + "\n";
        }
    }
    // TwoDimensionalShape derived classes
    class Circle : TwoDimensionalShape
    {
        private int radius;

        public Circle(int radius, string id) : base(id)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return (Math.PI * Math.Pow(radius, 2));
            }
        }
    }
    class Square : TwoDimensionalShape
    {
        private int side;

        public Square(int side, string id) : base(id)
        {
            this.side = side;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return Math.Pow(side, 2);
            }
        }
    }
    /*class Triangle : TwoDimensionalShape
    {

    }*/
    // ThreeDimensionalShape derived classes
    class Sphere : ThreeDimensionalShape
    {
        private int radius;

        public Sphere(int radius, string id) : base(id)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the surface area of a sphere:
                return (4 * Math.PI * Math.Pow(radius, 2));
            }
        }

        public override double Volume
        {
            get
            {
                // Given the side, return the volume of a sphere:
                return ((4 / 3) * Math.PI * Math.Pow(radius, 3));
            }
        }
    }
    class Cube : ThreeDimensionalShape
    {
        private int side;

        public Cube(int side, string id) : base(id)
        {
            this.side = side;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the surface area of a cube:
                return (6 * Math.Pow(side, 2));
            }
        }

        public override double Volume
        {
            get
            {
                // Given the side, return the volume of a cube:
                return (Math.Pow(side, 3));
            }
        }
    }
    /*class Tetrahedron : ThreeDimensionalShape
    {

    }*/
}
