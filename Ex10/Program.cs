Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int a1 = num % 100;
int a2 = a1 / 10;

Console.WriteLine($"Вторая цифра числа {num} - {a2}");
