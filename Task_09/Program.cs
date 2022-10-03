Console.Clear();

int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");
Console.WriteLine();
// int firstDigit = number/10;
// int secondDigit = number % 10;
// if (firstDigit == secondDigit)
// Console.WriteLine("Числа равны");
// else if (firstDigit > secondDigit) Console.WriteLine($"Первое число {firstDigit}, больше второго числа {secondDigit}");
// else Console.WriteLine($"Второе число {secondDigit}, больше первого числа {firstDigit}");
// Console.WriteLine();
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Большее число {maxDigit}");

int MaxDigit (int num)
{
int firstDigit = num/10;
int secondDigit = num % 10;
if (firstDigit == secondDigit) return 0;
if (firstDigit > secondDigit) return firstDigit;
return secondDigit;
}

int maxDigit = MaxDigit (number);
string result =maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine();
Console.WriteLine($"Наибольшая цифра числа {number} - {result}");