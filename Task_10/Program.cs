Console.Clear();

Console.WriteLine("Пожалуйста, введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
    {
        int arg = num / 10;
        int arg2 = arg % 10;
        return arg2;
    }
int secondDigit = SecondDigit(number);

if (number > 99 && number < 1000) Console.WriteLine($"Вторая цыфра числа {number} равна {secondDigit}");
else Console.WriteLine("Вы ввели не корректное число");