Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1; 
Console.Write("Четные числа от 1 до " + N + ": ");

while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}

Console.WriteLine();

