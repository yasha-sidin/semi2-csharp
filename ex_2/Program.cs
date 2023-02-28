// вывод случайного трехзначного числа и удаляет вторую цифру этого числа
int number = new Random().Next(100, 1000);

Console.WriteLine($"Рандомное число: {number}");

int result = (number / 100 * 10) + (number % 10);


 Console.WriteLine($"Ответ: {result}");
