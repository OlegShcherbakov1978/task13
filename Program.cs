// Задача 13: Напишите программу,
// которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение 1


begin:

Console.Write("Введите трехзначное число: ");
string text = Console.ReadLine();

if (text.Length < 3)
{
    System.Console.WriteLine("третьей цифры нет");
    goto begin;
}
else
{
    System.Console.WriteLine(text[2]);
}
