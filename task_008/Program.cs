// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int dayNumber = 6;
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string Result = "";

if (dayNumber > 5) Result = $", а значит это выходной день";
else Result = $", а значит это рабочий день";

Console.WriteLine();
Console.WriteLine($"{dayNumber} день недели - {Days[dayNumber - 1]}{Result}");
Console.WriteLine();



