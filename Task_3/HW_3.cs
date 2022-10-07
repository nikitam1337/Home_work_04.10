//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

int number;
while (true)
{
    Console.Write("Введите номер дня недели: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine($"Ошибка ввода!");
}

if (number < 1)
{
    Console.WriteLine("В неделе всего 7 дней, перезапустите программу");
}

if (number > 7)
{
    Console.WriteLine("В неделе всего 7 дней, перезапустите программу");
}

if (number == 1)
{
    Console.WriteLine($"{number} -> Нет");
}

if (number == 2)
{
    Console.WriteLine($"{number} -> Нет");
}

if (number == 3)
{
    Console.WriteLine($"{number} -> Нет");
}

if (number == 4)
{
    Console.WriteLine($"{number} -> Нет");
}

if (number == 5)
{
    Console.WriteLine($"{number} -> Нет");
}

if (number == 6)
{
    Console.WriteLine($"{number} -> Да");
}

if (number == 7)
{
    Console.WriteLine($"{number} -> Да");
}