// вывод случайного трехзначного числа и удаляет вторую цифру этого числа
//int number = new Random().Next(100, 1000);

//Console.WriteLine($"Рандомное число: {number}");

//int result = (number / 100 * 10) + (number % 10);


//Console.WriteLine($"Ответ: {result}");

string n = (new Random().Next(100, 1000)).ToString();

Console.WriteLine($"Сгенерированное число: {n}");

Console.Write(n[0]);
Console.Write(n[2]);
