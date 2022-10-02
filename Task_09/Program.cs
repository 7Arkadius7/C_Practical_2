Console.Clear();

int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

int firstDigit = number/10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Первое число {firstDigit}, больше второго числа {secondDigit}");
}
else
 Console.WriteLine($"Второе число {secondDigit}, больше первого числа {firstDigit}");