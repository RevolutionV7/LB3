 using System;

namespace ConsoleApp1
{
    class Point
    {
        string name;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Point()
            : this("", 0, 0) { }
        public Point(string name, int x, int y)
        {
            Console.WriteLine("Введiть назву точки:");
            this.name = Console.ReadLine();
            Console.WriteLine("Введiть X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть Y:");
            this.y = int.Parse(Console.ReadLine());
        }
    }
    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
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
        public void InitializeFigure()
        {
            Console.WriteLine("Введiть кiлькiсть кутiв вашого многокутника(вiд 3 до 5):");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
            public double CalculatePerimeter()
            {
                double perimeter = 0;
                for (int i = 1; i < points.Length; i++)
                {
                    perimeter += this.LengthSide(points[i - 1], points[i]);
                }
                perimeter += this.LengthSide(points[0], points[points.Length - 1]);
                return perimeter;
            }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure cube = new Figure("cube");
            Console.WriteLine()
            Console.WriteLine("Периметр многокутника = "+cube.CalculatePerimeter());
            Console.ReadKey();
            if (Point >=3 )
            {
                Console.WriteLine("Ваша фiгура - трикутник.");
            }
            else if (Point = 4)
            {
                Console.WriteLine("Ваша фiгура - чотирикутник.");
            }
            else if (Point =< 5)
            {
                Console.WriteLine("Ваша фiгура - п'ятикутник.");
            }
        }
    }
}
