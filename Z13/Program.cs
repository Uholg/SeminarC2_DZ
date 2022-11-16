//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
int randomNumber= new Random().Next(1,100000);
Console.Write(randomNumber + " -> ");
string a = Convert.ToString(randomNumber);
 if (a.Length < 3)
{Console.Write("Третьей цифры нет");}
else
{Console.Write(a[2]);}