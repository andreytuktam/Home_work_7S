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


