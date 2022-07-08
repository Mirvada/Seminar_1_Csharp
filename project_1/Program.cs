// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя)

Console.Clear();
string str = "Привет!";

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int num = 4;
int res = num * num;
Console.WriteLine($"Квадрат числа {num} = {res}");