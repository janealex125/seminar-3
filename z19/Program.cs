// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
string m = n.ToString(); 
if ((m)[0] == (m)[4] && m[1] == m[3] ) Console.WriteLine( "Число является палиндромом");
else if((m)[0] != (m)[4]) Console.WriteLine("Число  не является палиндромом");