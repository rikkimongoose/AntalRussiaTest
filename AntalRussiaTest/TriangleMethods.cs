using System;
namespace AntalRussiaTest
{
    /// <summary>
    ///  Методы для треугольников.
    /// </summary>
    public class TriangleMethods : ITriangleMethods
    {
        /// <summary>
        /// Вычисляет площадь треугольника.
        /// </summary>
        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        /// <returns>Площадь треугольника</returns>
        public double area(double a, double b, double c)
        {
            if(a == 0 || b == 0 || c == 0)
            {
                return 0.0;
            }

            if (a < 0)
            {
                throw new ArgumentOutOfRangeException("a can't be negative");
            }

            if (b < 0)
            {
                throw new ArgumentOutOfRangeException("b can't be negative");
            }

            if (c < 0)
            {
                throw new ArgumentOutOfRangeException("c can't be negative");
            }
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
