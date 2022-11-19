// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int num1 = (user_num % 100000) / 10000;
int num2 = (user_num % 10000) / 1000;
int num4 = (user_num % 100) / 10;
int num5 = user_num % 10;

if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("Число является палиндромом!");
}
else 
{
    Console.WriteLine("Число не является палиндромом!");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значение x1: ");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y1: ");
var y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z1: ");
var z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение x2: ");
var x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y2: ");
var y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z2: ");
var z2 = Convert.ToInt32(Console.ReadLine());

var results = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2));
Console.WriteLine(results);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");
var num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i,3) + " ");
}