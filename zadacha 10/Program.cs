// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.Clear();
Console.Write("Для выхода из программы команда Exit.\n или введите трёхзначное число: ");
 while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
            Console.WriteLine("Вторая цифра этого числа "+ (input[1]))
       ;
    }
