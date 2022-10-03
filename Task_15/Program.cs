Console.WriteLine("Пожалуйста, введите число соответствующее дню недели");
Console.WriteLine();
Console.WriteLine("Подсказка: ");
Console.WriteLine("1 - понедельник");
Console.WriteLine("2 - вторник");
Console.WriteLine("3 - среда");
Console.WriteLine("4 - четверг");
Console.WriteLine("5 - пятница");
Console.WriteLine("6 - суббота");
Console.WriteLine("7 - воскресенье");
Console.WriteLine();

int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 8)
{
    if (number == 6 || number == 7) Console.WriteLine("Это выходной день (ДА!!!)");
    else Console.WriteLine("Это рабочий день (НЕТ!!!)");
}
else Console.WriteLine("ПОЖАЛУЙСТА, введите корректную цифру");