Console.WriteLine("Введите четыре значения через пробел: ");

double[] mas = Console.ReadLine().Split().Select(double.Parse).ToArray();

double x = (mas[2] - mas[0]) / (mas[1] - mas[3]); 
double y = mas[1] * x + mas[0]; 

Console.WriteLine("Точка пересечения двух прямых: (" + x + ", " + y + ")");
