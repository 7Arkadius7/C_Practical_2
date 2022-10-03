Console.Clear();

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsAliqut(int arg1, int arg2)
{
    return arg1 % arg2 == 0;
}

if (IsAliqut (num1, num2)) Console.WriteLine($"{num1} кратно {num2}");
else Console.WriteLine($"{num1} не кратно {num2}, остаток: {num1 % num2} ");