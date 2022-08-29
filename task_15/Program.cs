Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num == 1) Console.WriteLine("Понедельник не является выходным.");
else if (num == 2) Console.WriteLine("Вторник не является выходным.");
else if (num == 3) Console.WriteLine("Среда не является выходным.");
else if (num == 4) Console.WriteLine("Четверг не является выходным.");
else if (num == 5) Console.WriteLine("Пятница не является выходным.");
else if (num == 6) Console.WriteLine("Суббота не является выходным.");
else if (num == 7) Console.WriteLine("Воскресение является выходным.");
else
{
    Console.WriteLine("Введено не верное число");
}