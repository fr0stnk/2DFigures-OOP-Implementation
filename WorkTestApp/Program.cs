using System;

namespace WorkTestApp
{
    /// <summary>
    /// Фигура.
    /// </summary>
    abstract class Figure
    {
        #region Поля
        public string name { get; set; }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Иницилизация нового объекта <смотри ref="T:WorkTestApp.Figure"/> класс.
        /// </summary>
        public Figure()
        {
            name = "Нет имени";
        }

        /// <summary>
        /// Иницилизация нового объекта <смотри cref="T:WorkTestApp.Figure"/> класс.
        /// </summary>
        /// <param name="n">Название фигуры.</param>
        public Figure(string n)
        {
            name = n;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns>Площадь.</returns>
        public abstract double Area();
        #endregion
    }

    /// <summary>
    /// Окружность.
    /// </summary>
    class Circle : Figure
    {
        #region Поля
        double _radius;
        /// <summary>
        /// Получает или передает радиус.
        /// </summary>
        /// <value>Радиус.</value>
        public double radius
        {
            get { return _radius; }
            set { _radius = value < 0 ? -value : value; }
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Иницилизация нового объекта <смотри cref="T:WorkTestApp.Circle"/> класс.
        /// </summary>
        public Circle()
        {
            radius = 0.0;
            name = "Окружность";
        }

        /// <summary>
        /// Иницилизация нового объекта <смотри cref="T:WorkTestApp.Circle"/> класс.
        /// </summary>
        /// <param name="r">Радиус.</param>
        public Circle(double r) : base("Окружность") 
        {
            radius = r;
        }
        #endregion


        #region Методы
        /// <summary>
        /// Площадь окружности
        /// </summary>
        /// <returns>Площадь.</returns>
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        #endregion
    }


    /// <summary>
    /// Треугольник.
    /// </summary>
    class Triangle : Figure
    {
        #region Поля
        double _aSide;
        double _bSide;
        double _cSide;

        /// <summary>
        /// Получает или передает сторону A.
        /// </summary>
        /// <value>Сторона A.</value>
        public double aSide
        {
            get { return _aSide; }
            set { _aSide = value < 0 ? -value : value; }
        }

        /// <summary>
        /// Получает или передает сторону B.
        /// </summary>
        /// <value>Сторона B.</value>
        public double bSide
        {
            get { return _bSide; }
            set { _bSide = value < 0 ? -value : value; }
        }

        /// <summary>
        /// Получает или передает сторону C.
        /// </summary>
        /// <value>Сторона C.</value>
        public double cSide
        {
            get { return _cSide; }
            set { _cSide = value < 0 ? -value : value; }
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Иницилизация нового объекта <смотри cref="T:WorkTestApp.Triangle"/> класс.
        /// </summary>
        public Triangle()
        {
            aSide = bSide = cSide = 0.0;
            name = "Треугольник";
        }

        /// <summary>
        /// Инициализация нового объекта <смотри cref="T:WorkTestApp.Triangle"/> класс.
        /// </summary>
        /// <param name="a">Сторона A.</param>
        /// <param name="b">Сторона B.</param>
        /// <param name="c">Сторона C.</param>
        public Triangle(double a, double b, double c) : base("Треугольник")
        {
            aSide = a;
            bSide = b;
            cSide = c;
        }
        #endregion

        #region Методы
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <returns>Площадь.</returns>
        public override double Area()
        {
            double p = (aSide + bSide + cSide) / 2;
            return Math.Sqrt(p * (p - aSide) * (p - bSide) * (p - cSide));
        }
        #endregion
    }

    /// <summary>
    /// Тесты.
    /// </summary>
    class Tests
    {
        public static void Main(string[] args)
        {
            Figure[] shapes = new Figure[4];

            shapes[0] = new Triangle(-3.0, -4.0, 5.0);
            shapes[1] = new Circle(5);
            shapes[2] = new Triangle();
            shapes[3] = new Circle();

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Объект - " + shapes[i].name);
                Console.WriteLine("Площадь равна - " + shapes[i].Area());
            }
        }
    }
}


