// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int x = int.Parse(Console.ReadLine()!);
if (x == 1)
{
    Console.WriteLine("Понедельник");
}
else if (x == 2)
{
    Console.WriteLine("Вторник");
}
else if (x == 3)
{
    Console.WriteLine("Среда");
}
else if (x == 4)
{
    Console.WriteLine("Четверг");
}
else if (x == 5)
{
    Console.WriteLine("Пятница");
}
else if (x == 6)
{
    Console.WriteLine("Суббота");
}
else if (x == 7)
{
    Console.WriteLine("Воскресенье");
}
if (x > 0 & x < 5)
{
    Console.WriteLine("Будний день. ");
}
if (x < 5 & x < 7)
{
    Console.WriteLine("Выходной день. ");
}
else
{
    Console.WriteLine("Введите число, обозначающее день недели. ");
}