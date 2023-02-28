// На вход два числа, вывод: является ли второе кратным первому
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine($"{a} кратно {b}");
}
else
{
    Console.WriteLine($"{a} не кратно {b}, остаток {a % b}");
}