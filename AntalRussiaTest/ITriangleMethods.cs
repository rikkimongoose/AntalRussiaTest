namespace AntalRussiaTest
{
    /// <summary>
    ///  Методы для треугольников.
    /// </summary>
    public interface ITriangleMethods
    {
        /// <summary>
        /// Вычисляет площадь треугольника.
        /// </summary>
        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        /// <returns>Площадь треугольника</returns>
        double area(double a, double b, double c);
    }
}