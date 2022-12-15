/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите b2: ");                    
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = (k1 * x + b1);

//Как данные с 7 по 17 строку записать в метод не разобрался 
//Прошу после выставления оценки прислать пример как это сделать для самостоятельного разбора. Спасибо

PrintArray(x, y);

void PrintArray(double x, double y)
{
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}
