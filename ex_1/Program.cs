// вывести случайное число из отрезка [10, 99]
int number = new Random().Next(10, 100);

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}

Console.WriteLine($"Слуайное число из отрезка [10, 99]: {number}");
