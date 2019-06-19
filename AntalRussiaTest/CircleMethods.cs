using System;

namespace AntalRussiaTest
{
    /// <summary>
    /// Методы для кругов.
    /// </summary>
    public class CircleMethods : ICircleMethods
    {
        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Площадь круга</returns>
        public double area(double radius)
        {
            if(radius == 0)
            {
                return 0.0;
            }
            if(radius < 0)
            {
                throw new ArgumentOutOfRangeException("radius can't be negative.");
            }
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
