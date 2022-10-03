Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    int res = num % 10;
    return res;
}

if (number < 100) Console.WriteLine($"Число {number} не имеет третьей цифры");
else
{
    int result = ThirdDigit(number);
    Console.WriteLine();
    Console.WriteLine($"Третья цифра числа {number} ->  {result}");
}