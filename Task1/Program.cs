int i = 0;
int[] array = new int[1000];

Console.WriteLine("Введите M чисел с клавиатуры через пробел: ");

int[] mas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int j = 0; j < mas.Length; j++) if (mas[j] > 0) i++;

Console.WriteLine($"Количество положительных чисел = {i}");