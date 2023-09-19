Console.Write("Первое число: ");
int number_one = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number_two = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (number_one > number_two) {
    max = number_one;
    Console.WriteLine(max);
    }
else max = number_two;
    Console.WriteLine("Максимальное число: " + max);