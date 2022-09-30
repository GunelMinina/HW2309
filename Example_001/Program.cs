// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.WriteLine("введите пятизначное число");
string numbr = Console.ReadLine();

if (numbr[0] == numbr[4] & numbr[1] == numbr[3]) 
    {   
    Console.WriteLine("Palindrom");
    }
else
    {
    Console.WriteLine("NE Palindrom");
    }
