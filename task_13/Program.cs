Console.WriteLine("Введите число: ");
string num = Convert.ToString(Console.ReadLine());

Console.WriteLine(num[2]);

int index = num.Length;
int find = index;
Console.WriteLine(index);

if (find < 3)
{
    Console.WriteLine("Нет третьей цифры");
}