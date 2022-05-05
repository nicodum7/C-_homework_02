// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
int Number1 = 16;
int Number2 = 4;
int result = 0;

int MultipleNumber()
{
    result = Number1 % Number2;
    return result;
}
MultipleNumber();
Console.WriteLine();

if (result == 0) Console.WriteLine($"{Number1} кратно числу {Number2}");
else
{
    Console.WriteLine($"{Number1} не кратно {Number2}, остаток от деления равен {Number1 % Number2}");
}
Console.WriteLine();