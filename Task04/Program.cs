Console.WriteLine("Введите трёхзначное целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number % 10;
Console.WriteLine($"Последняя цифра: {lastDigit}");

