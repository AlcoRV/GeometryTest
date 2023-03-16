namespace CustomGeometry
{
    public abstract class Figure2D : IAreaCalculator
    {
        /// <summary>
        ///     Метод для расчёта площади фигуры
        ///     При неполных или неверных данных вернёт 0
        ///     Можно дополнить, чтобы возвращал AreaException
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateArea();
    }
}