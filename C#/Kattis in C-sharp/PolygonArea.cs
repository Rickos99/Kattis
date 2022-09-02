using System;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/polygonarea
    class PolygonArea
    {
        //public static void Main() => Solution();

        static void Solution()
        {
           int numberOfVertices;
           while ((numberOfVertices = int.Parse(Console.ReadLine())) != 0)
           {
               var polyArea = new PolygonArea();
               var points = new Point[numberOfVertices];
               for (int i = 0; i < numberOfVertices; i++)
               {
                   var pointAsString = Console.ReadLine().Split(' ');
                   var pointX = int.Parse(pointAsString[0]);
                   var pointY = int.Parse(pointAsString[1]);
                   points[i] = new Point(pointX, pointY);
               }
               polyArea.outputResultString(polyArea.CalculateArea(points));
           }
        }


        private void outputResultString(double area)
        {
            var areaCalculatedClockwise = area > 0;
            var areaCalculationDirection = areaCalculatedClockwise ? "CW" : "CCW";

            var areaString = DoubleToString(Math.Abs(area), 1);
            Console.WriteLine($"{areaCalculationDirection} {areaString}");
        }

        private string DoubleToString(double number, int decimals)
        {
            int integerPart = (int)number;
            int decimalPart = (int)Math.Round((number % 1) * Math.Pow(10, decimals), 0);
            return $"{integerPart}.{decimalPart}";
        }

        private double CalculateArea(Point[] points)
        {
            double totalArea = 0;
            for (int i = 0; i < points.Length; i++)
            {
                // Wrap-around next i, if i+1 is out of range
                int nextI = i + 1 < points.Length ? i + 1 : i - points.Length + 1;

                Point pointA = points[i];
                Point pointB = points[nextI];

                double height = (pointB.Y + pointA.Y) / 2.0;
                double width = pointB.X - pointA.X;
                double areaUnderLine = height * width;
                totalArea += areaUnderLine;
            }
            return totalArea;
        }
    }

    class Point
    {
        public int X { get; }
        public int Y { get; }


        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
