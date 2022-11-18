/*Sem1
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

/*Sem3

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
}*/

/*Sem7

Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");

Console.WriteLine("Введите число m: ");

int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n: ");

int n = int.Parse(Console.ReadLine());

float[,] mass = new float[m,n];
Random rand = new Random();

double range = (double)(999999) - (double)(-999999);
for(int i = 0; i < n; i++)
{
    for (int j=0; j < m; j++)
 {
    double temp = rand.NextDouble();
    mass[i,j] = (float)Math.Round((temp * range) + (float)(-999999), 2);
    Console.Write(mass[i,j] + " ");
 }
 Console.WriteLine("");
}

Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("Введите первую позицию: ");

int row = int.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую позицию: ");

int colum = int.Parse(Console.ReadLine());

int[,] mass2 = new int[,] { { 1, 2, 3 }, 
                            { 3, 4, 5 }, 
                            { 5, 6, 7 } };

 try
        {
            Console.WriteLine(mass2[row, colum]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Tакого элемента нет.");
        }


Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

int[,] mass2 = new int[,] { { 11, 12, 13 }, 
                            { 1, 2, 3 }, 
                            { 1, 2, 3 } };

Random rand = new Random();
double rez= 0;
int size =0;
for(int i = 0; i < 3; i++)
{
    for (int j=0; j < 3; j++)
 {
    rez = mass2[j,i] + rez;
    size = size+1;
 }
 Console.Write(Math.Round(rez/size, 2)+"; ");
 rez = size = 0;
}
*/

/*Sem8

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

int[,] mass2 = new int[,] { { 1, 4, 7, 2 }, 
                            { 5, 9, 2, 3 }, 
                            { 8, 4, 2, 4 } };

for (int i= 0; i<mass2.GetLength(0); i++)
{
    for (int j= 0; j<mass2.GetLength(1); j++)
    {
        Console.Write(mass2 [i,j] + " ");
    }
    Console.WriteLine("");
}

int[] temp= new int[mass2.GetLength(1)]; 

for (int i= 0; i<mass2.GetLength(0); i++)
{
    for (int j= 0; j<mass2.GetLength(1); j++)
    {
        temp[j]=mass2[i,j];
    }
    Array.Sort(temp);
    Array.Reverse(temp);
    for (int z= 0; z<mass2.GetLength(1); z++)
    {
        mass2[i,z]=temp[z];
    }
}

Console.WriteLine("");

for (int i= 0; i<mass2.GetLength(0); i++)
{
    for (int j= 0; j<mass2.GetLength(1); j++)
    {
        Console.Write(mass2 [i,j] + " ");
    }
    Console.WriteLine("");
}

Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
int[,] mass2 = new int[,] { { 1, 4, 7, 2 }, 
                            { 5, 9, 2, 3 }, 
                            { 8, 4, 2, 4 },
                            { 5, 2, 6, 7 } };

for (int i= 0; i<mass2.GetLength(0); i++)
{
    for (int j= 0; j<mass2.GetLength(1); j++)
    {
        Console.Write(mass2 [i,j] + " ");
    }
    Console.WriteLine("");
}

int[] temp= new int[mass2.GetLength(1)]; 
int rez, temp_sum, min_sum;
rez = temp_sum = min_sum = 0;
for (int i= 0; i<mass2.GetLength(0); i++)
{
    for (int j= 0; j<mass2.GetLength(1); j++)
    {
        temp[j]=mass2[i,j];
        temp_sum = temp_sum + temp[j];
        
    }
    if ((i == 0) || (min_sum>temp_sum))
    {
        
        min_sum=temp_sum;
        rez = i;
    }
    temp_sum = 0;
}
Console.WriteLine("Cтрока с наименьшей суммой элементов - это строка с номером - " + (rez+1));


Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

int[,] first = new int[,] { { 1, 2}, 
                            { 3, 4 }};
int[,] second = new int[,] { { 5, 6}, 
                            { 7, 9 }};
int[,] rez= new int[,]{{0,0}, {0,0}};

rez[0,0]= (first[0,0] * second[0,0]) + (first[0,1] * second[1,0]);
Console.Write(rez[0,0] + " ");
rez[0,1]= (first[0,0] * second[0,1]) + (first[0,1] * second[1,1]);
Console.WriteLine(rez[0,1]);
rez[1,0]= (first[1,0] * second[0,0]) + (first[1,1] * second[1,0]);
Console.Write(rez[1,0]+ " ");
rez[1,1]= (first[1,0] * second[0,1]) + (first[1,1] * second[1,1]);
Console.Write(rez[1,1]);*/


/*Sem9

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int first(int n)
{

    if (n == 0) return 0;
    Console.Write(n+ " ");
    return first(n - 1);
}   

first(8);
Console.WriteLine("");

//Задача 66: Задайте значения n и m. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от n до m.
int second(int n, int m)
{
    int sum=0;
    if ((n-m) > 0)
    {
        
        for (int i=m; i<=n;i++)
        {
            sum=sum+i;
        }
        
    }
    else
        {
            for (int i=n; i<=m;i++)
            {
                sum=sum+i;
            }
            
        }
    return sum;
} 

Console.WriteLine(second(4,8));
