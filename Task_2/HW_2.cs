//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();

int number;
while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine($"Ошибка ввода!");
}

int x1 = 100;
int x2 = 1000;
int n = 10;
while (true)
{
    if (-100 < number && number < 100)
    {
        Console.WriteLine($"{number} -> третьей цифры нет");
        break;
    }
    

    if (x1 <= number && number < x2)
    {
        int num3 = number % n;
        Console.WriteLine($"{number} -> {num3}");
        break;
    }
    else
    {

    }
}

// if // ввести х1 и х2 и умножать их на 10, после каждой проверки, если она не выполнилась и првоерять заново
//break;




//Math.Pow (число, степень)
//double nam = Math.Pow (10, 2);