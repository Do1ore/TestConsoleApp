// Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу
// и треугольника по трем сторонам.
// Дополнительно к работоспособности оценим:
// Юнит-тесты
// Легкость добавления других фигур
// Вычисление площади фигуры без знания типа фигуры в compile-time
// Проверку на то, является ли треугольник прямоугольным

using SuperUsefulClassLibrary.Abstractions;
using SuperUsefulClassLibrary.Core;
using SuperUsefulClassLibrary.Implementation;

IGeometricFigure circle = ShapeFactory.CreateShape("circle", 200004343);
var result = circle.CalculateArea();
Console.WriteLine(result);

IGeometricFigure rectangle = ShapeFactory.CreateShape("triangle", 3, 4, 5);
Console.WriteLine(((Triangle)rectangle).IsRightTriangle());
Console.WriteLine(rectangle.CalculateArea());