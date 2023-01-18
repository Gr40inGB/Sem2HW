// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

bool errorInput = true;
int inputNumber = -1;
while (errorInput)
{
    Console.Write("Введите день недели (цифру): ");
    inputNumber = int.Parse(Console.ReadLine());
    if (inputNumber < 1 || 7 < inputNumber)
    {
        errorInput = true;
        Console.Write("Такого дня недели не существует. ");
        continue;
    }
    else
        errorInput = false;
}

if (inputNumber == 6 || inputNumber == 7) Console.Write($"Вы ввели {inputNumber}. Это Выходной день - Да ");
else Console.Write($"Вы ввели {inputNumber}. Это не выходной день - Нет ");

