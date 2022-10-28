/* Sem1
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a);

}
else if (a==b)
    {
        Console.WriteLine("Они равны");
    }
else
{
    Console.WriteLine(b);
}

Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

Console.WriteLine("Введите первое число: ");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c2 = int.Parse(Console.ReadLine());

int max = a2;

if (max < b2)
{
    max=b2;
}
if (max < c2)
{
    max=c2;
}

Console.WriteLine(max);

Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

Console.WriteLine("Введите число: ");

int number2 = int.Parse(Console.ReadLine());

int temp = number2;
if (number2 >= 0)
{
    for(int i=1; i<=number2; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}
else
{
    for(int i=number2; i<=1; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }
}
*/

/*Sem2

Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.WriteLine("Введите трёхзначное число: ");
string a = Console.ReadLine();

if (a.Length>=3 ||(( a.Length == 4) & (a[0] == '-')))
{
    if(a[0] != '-')
    {
        Console.WriteLine(a[1]);
    }
    else
    {
        Console.WriteLine(a[2]);
    }
}
else
{
    Console.WriteLine("Число не трёхзначное");
}

Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.WriteLine("Введите трёхзначное число: ");
string b = Console.ReadLine();

if ((b.Length>=3) & (b[0] != '-') || ((b.Length>=4) & (b[0] == '-')))
{
    if(b[0] != '-')
    {
        Console.WriteLine(b[2]);
    }
    else
    {
        Console.WriteLine(b[3]);
    }
}
else
{
    Console.WriteLine("Число не трёхзначное, третьей цифры нет ");
}

Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

Console.WriteLine("Введите цифру, обозначающую день недели (От 1 до 7): ");
int c = int.Parse(Console.ReadLine());

if((c<=7) & (c>=1))
{
    if((c==6) || (c==7))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("ошибка1.не правильная цифра");
}
*/

//Sem3

Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите пятизначное число: ");

string a = Console.ReadLine();

if((a[0] ==a[4]) & (a[1] ==a[3]))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите координату x для первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y для первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z для первой точки: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x для второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y для второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z для второй точки: ");
int z2 = int.Parse(Console.ReadLine());

double rez = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));

Console.WriteLine("расстояние между точками в 3D пространстве: " + rez);


Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.WriteLine("Введите пятизначное число: ");
int c = int.Parse(Console.ReadLine());
for (int i=1;i<=c; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}