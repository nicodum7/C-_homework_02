﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int число = 32679;
if (число / 100 > 0) Console.WriteLine($"{число / 100 % 10}");
else Console.WriteLine($"У числа {число} нет третьей цифры");

Console.WriteLine();



