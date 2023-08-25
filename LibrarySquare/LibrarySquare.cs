using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySquare
{
    public abstract class Shape
    {
        public double Area { get; set; }
        public abstract double GetSquare();
    }
    public static class Validator
    {
        public static void ValidateNonNegative(double value, string paramName)
        {
            if (value < 0)
            {
                throw new Exception($"'{paramName}' должен быть положительны значением.");
            }
        }

        public static double IsRightTriangle(double a, double b, double c)
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                return (a * b) / 2;
            }
            return 0;
        }
        public static void ValidateTriangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new Exception($"Треугольника со сторонами {a}, {b}, {c} не существует.");
            }
        }
    }
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            Validator.ValidateNonNegative(a, nameof(a));
            Validator.ValidateNonNegative(b, nameof(b));
            Validator.ValidateNonNegative(c, nameof(c));
            Validator.ValidateTriangle(a, b, c);
            Validator.IsRightTriangle(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        public override double GetSquare()
        {
            double p = (A + B + C) / 2;
            Area = p * (p - A) * (p - B) * (p - C);
            return Math.Sqrt(Area);
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Validator.ValidateNonNegative(radius, nameof(radius));
            Radius = radius;
        }
        public override double GetSquare()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }
    }
}
