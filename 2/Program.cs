// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int First = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int Third = Convert.ToInt32(Console.ReadLine());

if (First < Second)
{
    if(Second < Third)
    {
        Console.WriteLine("Самое большое число " + Third);
    } 
    else
    {
        Console.WriteLine("Самое большое число " + Second);
    }
}
else
{
    if(First < Third)
    {
        Console.WriteLine("Самое большое число " + Third);
    }
    else
    {
        Console.WriteLine("Самое большое число " + First);
    }
}
