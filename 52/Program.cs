// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите колличество строк - i: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите колличество столбцов - j: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[M, N];
Random rnd = new Random();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write(array[i, j] + " "); 
    } 
    Console.WriteLine(); 
}
for (int j = 0; j < N; j++)
{
    double sum = 0;
    for (int i = 0; i < M; i++)
    {
        sum = array[i, j] + sum;
    } 
    Console.WriteLine($"среднее арифметическое j = {j}: {sum / M}"); 
}

