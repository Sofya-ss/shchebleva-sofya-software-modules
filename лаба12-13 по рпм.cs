// See https://aka.ms/new-console-template for more information
//Задание 1
Console.WriteLine("Задание 1");
Console.WriteLine("Введите х1");
string input1 = Console.ReadLine();
Console.WriteLine("Введите х2");
string input2 = Console.ReadLine();

int x1  = Convert .ToInt32(input1);
int x2 = Convert.ToInt32(input2);

long square1 = (long)x1 * x1; long square2 = (long)x2 * x2; 

 int result = (square1 >= square2) ? x1 : x2;
 Console.WriteLine($"Число, квадрат которого больше: {result}");


//Задание 2
Console.WriteLine("Задание 2");

Console.WriteLine("Введите a");
string input3 = Console.ReadLine();
Console.WriteLine("Введите b");
string input4 = Console.ReadLine();
Console.WriteLine("Введите c");
string input5 = Console.ReadLine();

int x3 = Convert.ToInt32(input3);
int x4 = Convert.ToInt32(input4);
int x5 = Convert.ToInt32(input5);

if (x3 + x4 > x5 && x3 + x5 > x4 && x5 + x4 > x3)
{
    if (x3 == x4 || x3 == x5 || x5 == x4)
    {
        Console.WriteLine("Треугольник равнобедренный");
    }
    else
    {
        Console.WriteLine("Треугольник не равнобедренный");
    }
}
else
{
    Console.WriteLine("Треугольник с такими сторонами не существует");
}

//Задание 3
Console.WriteLine("Задание 3");

Console.WriteLine("Введите номер месяца");
int month = Convert.ToInt32(Console.ReadLine());
switch (month)
{
case 1: case 3: case 5: case 7: case 8: case 10: case 12:
    Console.WriteLine("В этом месяце 31 день");
break;
case 4: case 6: case 9: case 11:
    Console.WriteLine("В этом месяце 30 дней");
break;
case 2:
    Console.WriteLine("В этом месяце 28 дней");
break;
default:
    Console.WriteLine("Некорректный номер месяца");
break;

}

//Задание 4

Console.WriteLine("Задание 4");

Console.WriteLine("Введите свои очки");
int points = Convert.ToInt32(Console.ReadLine());

string rank = points switch
{
    < 0 => "ошибка",
    >= 0 and <= 99 => "новичок",
    >= 100 and <= 499 => "бронза",
    >= 500 and <= 999 => "серебро",
    >= 1000 => "золото",
};

Console.WriteLine($"Ваш ранг: { rank}");

