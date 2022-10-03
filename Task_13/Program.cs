Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) Console.WriteLine($"Число {number} не имеет третьей цифры");
else
{
    while (number > 1000)
    {
        number = number / 10;
    }

    int result = number % 10;
    Console.WriteLine($"Число {result}");
}