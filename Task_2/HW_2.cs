//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Clear();

int userInput;

while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out userInput))
        break;
    Console.WriteLine($"Ошибка ввода!");
}

int userNumber;

while (true)
{
    if (userInput == 0)
    {
        Console.WriteLine("Третьей цифры нет");
        break;
    }

    if (userInput< 0)
    {
        userNumber = userInput * -1;
        int num = Convert.ToInt32(userNumber);
        string numtext = Convert.ToString(num);
        if (numtext.Length > 2)
        {
            Console.WriteLine($"{userInput} -> {numtext[2]}");
            break;
        }
        else
        {
            Console.WriteLine($"{userInput} -> третьей цифры нет");
            break;
        }
    }

    if (userInput > 0)
    {
        int num = Convert.ToInt32(userInput);
        string numtext = Convert.ToString(num);
        if (numtext.Length > 2)
        {
            Console.WriteLine($"{userInput} -> {numtext[2]}");
            break;
        }
        else
        {
            Console.WriteLine($"{userInput} -> третьей цифры нет");
            break;
        }
    }
}