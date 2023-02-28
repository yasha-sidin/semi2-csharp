// ввод числа, проверка кратно ли одновременно 7 и 23
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
//if (a % 7 == 0 && a % 23 == 0)
//{
//    Console.Write("Yes");
//}
//else
//{
//    Console.Write("No");
//}

bool result = a % 7 == 0 && a % 23 == 0;

Console.WriteLine(result);