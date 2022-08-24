// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
using static System.Console;
Console.WriteLine("Введите цифру, обозначающую день недели");
Console.WriteLine("1 - Понедельник, 2 - Вторник, 3 - Среда, 4 - Четверг, 5 - Пятница, 6 - Суббота, 7 - Воскресенье");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber == 6 ^  dayNumber == 7) // если ввели 6 или 7
{
  Console.WriteLine("Да, это выходной день");
}
else 
{
    Console.WriteLine("Нет, этот день не выходной");
}