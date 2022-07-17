// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int M = 5;
int N = 5;
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
int k = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());
if (k > M - 1 || k < 0 || l > N - 1 || l < 0)
{
    Console.WriteLine("Нет такого эллемента в массиве!");
} else {
    Console.Write(array[k, l]);
}


