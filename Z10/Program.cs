//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
int randomNumber= new Random().Next(100,1000);
Console.Write(randomNumber + " -> ");
string a = Convert.ToString(randomNumber);

Console.Write(a[1]);