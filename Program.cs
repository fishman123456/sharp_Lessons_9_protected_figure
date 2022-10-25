// See https://aka.ms/new-console-template for more information
// разработать абстрактный класс Геометрическая фигура с методами 
// площадь фигуры и периметр фигуры в пространстве имен figures
// разработать классы наследники
// Треугольник, Квадрат, Ромб,  Прямоугольник, Круг
// реализовать конструкторы которые однозначно определяют обьекты данных классов

using sharp_Lessons_9_protected_figure;

Circle one = new Circle();
one.Print();
Circle two = new Circle(10,20,2);
two.area();
two.Print();