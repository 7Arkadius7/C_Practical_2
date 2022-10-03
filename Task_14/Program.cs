Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int num = Convert.ToInt32(Console.ReadLine());

// if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"{num} кратно");
// else Console.WriteLine($"{num} не кратно");

bool Multiplicity(int arg1)
    {
        return arg1 % 7 == 0 && arg1 % 23 == 0;
    }

if (Multiplicity(num)) Console.WriteLine("Кратно!!!");
else Console.WriteLine("Не кратно!!!");