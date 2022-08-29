Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int a = num / 100;
int b = num % 10;
int c = num - (a * 100 + b);
Console.WriteLine(c/10);

