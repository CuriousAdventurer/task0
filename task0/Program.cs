//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());//Console.ReadLine() - считывание с консоли
int result = number*number;
Console.WriteLine("Квадрат числа = " + result); //склеивание строки (конкатенация)
