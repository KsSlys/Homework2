//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число");
int a = int.Parse(Console.ReadLine());
if(a <= 99){
    Console.WriteLine("Третьей цифры нет");
}
else{
    while (a > 1000){
        a /= 10; // a = a / 10
    }
    Console.WriteLine(a%10);
}