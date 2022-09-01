Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());



if (num < 100)
{
    Console.WriteLine("Нет третьего числа");
}

if (num < 1000 && num >= 100)
{
    Console.WriteLine(num % 100/10);
}

if (num < 10000 && num >= 1000)
{
    Console.WriteLine(num % 1000 % 100/10);
}

if (num < 100000 && num >= 10000)
{
    Console.WriteLine(num % 10000 % 1000/100);
}

if (num < 1000000 && num >= 100000)
{
    Console.WriteLine(num % 100000 % 10000/1000);
}

if (num < 10000000 && num >= 1000000)
{
    Console.WriteLine(num % 1000000 % 100000/10000);
}

// И так далее.. если есть другой способ, подскажите, ломал голову долго, очень хочу знать, наверняка существует способ короче, о котором я не знаю, спасибо!