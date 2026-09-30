using static System.Numerics.Vector3;
using System;

Console.WriteLine("Задание 1");

Console.WriteLine("Значения вектора1:(1,3,4)");
Console.WriteLine("Значения вектора2:(1,2,1)");

var v1 = 1;
var v2 = 3;
var v3 = 4;

var v4 = 1;
var v5 = 2;
var v6 = 1;

var ScalProd = v1 * v4 + v2 * v5 + v3 * v6;

Console.WriteLine($"скалярное произведение: {ScalProd}");

var a = Math.Sqrt(v1 * v1 + v2 * v2 + v3 * v3);

var a1 = Math.Sqrt(v4 * v4 + v5 * v5 + v6 * v6);

Console.WriteLine($"Длина первого: {a}");

Console.WriteLine($"Длина второго: {a1}");

var b = Math.Sqrt(Math.Pow(v4 - v1, 2) + Math.Pow(v5 - v2, 2) + Math.Pow(v6 - v3, 2));
Console.WriteLine($"Евклидово расстояние между ними: {b}"); ;

var CosShod = (ScalProd) / b;

Console.WriteLine($"Косинусное сходство: {CosShod}");

Console.WriteLine("Задание 2");



var x1 = 1;
var x2 = 2;
var x3 = 3;
var x4 = 4;

Console.WriteLine("x1=1");
Console.WriteLine("x2=2");
Console.WriteLine("x3=3");
Console.WriteLine("x4=4");

double result1 = Math.Exp(x1);
double result2 = Math.Exp(x2);
double result3 = Math.Exp(x3);
double result4 = Math.Exp(x4);



Console.WriteLine($" е в степени х1: {result1}");
Console.WriteLine($" е в степени х2: {result2}");
Console.WriteLine($" е в степени х3: {result3}");
Console.WriteLine($" е в степени х4: {result4}");


var Sum = result1 + result2 + result3 + result4;

Console.WriteLine($"Общая сумма: {Sum}");

var Sum1 = result1 / Sum;
var Sum2 = result2 / Sum;
var Sum3 = result3 / Sum;
var Sum4 = result4 / Sum;


Console.WriteLine($"Сумма1: {Sum1}");
Console.WriteLine($"Сумма2: {Sum2}");
Console.WriteLine($"Сумма3: {Sum3}");
Console.WriteLine($"Сумма4: {Sum4}");
Console.WriteLine("Задание 3");

int N = 600;
int M = 251;
int T = 1000;

Console.WriteLine("N=600");
Console.WriteLine("M=251");
Console.WriteLine("M=1000");

long totalOperations = (long)N * M * T;

double millionsOperations = totalOperations * 1_000_000;

Console.WriteLine($"Общее количество операций: {totalOperations}");
Console.WriteLine($"В миллионах: {millionsOperations:F3}");
