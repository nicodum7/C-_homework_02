// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int number = 161;
int a = 7;
int b = 23;
string result = " ";

if (number % a == 0 && number % b == 0) result = "да";
else result = "нет";
Console.WriteLine(result);

