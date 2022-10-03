Console.Clear();

int number = new Random().Next(100, 1000);

int RemooveSecondDigit(int num)
{
    int first = num / 100;
    int third = num % 10;   
    return first * 10 + third;
}
int result = RemooveSecondDigit(number);

Console.WriteLine($"Случайное число - {number}");
Console.WriteLine($"Итоговое число - {result}");