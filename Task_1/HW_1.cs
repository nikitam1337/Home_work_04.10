// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Clear();

int EnterNumber()
{
    int number;
    while (true)
    {
        Console.Write("Введите трёхзначное число: ");
        if (int.TryParse(Console.ReadLine(), out number))
            if (99 < number && number < 1000)
                break;
        Console.WriteLine($"Ошибка ввода!");
    }
    return number;
}

int num123 = EnterNumber();
int num1 = num123 / 10;
int num2 = num1 % 10;

Console.WriteLine($"{num123} -> {num2}");