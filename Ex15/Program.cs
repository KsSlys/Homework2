//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Напишите день недели");
int num = int.Parse(Console.ReadLine());
if (num > 8){
    Console.WriteLine("Не является днем недели");
}
else{
    if (num == 6 || num == 7){
        Console.WriteLine("Да");
    }
    else{
        Console.WriteLine("Нет");
    }

}
