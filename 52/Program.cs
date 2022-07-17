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

