Console.WriteLine("Введите любое натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;
while(a <= N)
{
if (a % 2 == 0)
Console.WriteLine("Четное число из N");
Console.WriteLine(a);
a = a + 2;
}