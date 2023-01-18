// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
// 645 -> 6

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
String inputNumberString = Console.ReadLine();

int inputNumberInt = 0;

try
{   // преобразование как учились на семинаре. Но тогда, есть проблемы с большими числами
    inputNumberInt = Convert.ToInt32(inputNumberString);
}
catch (System.Exception)
{   // здесь вырезаем нужный размер строки, чтобы дальнейший код сработал. 
    // Да и напрашивается такое решение. Правда я не стал обрабатывать случай, если введут число с запятой. 
    inputNumberInt = Convert.ToInt32(inputNumberString.Substring(inputNumberString.Length - 3));
}

Console.Write($"Введенное число: {inputNumberString}. ");

if (-99 < inputNumberInt && inputNumberInt < 100)  // только в этом случае не будет 3-й цифры
    Console.Write($" Третьей цифры нет");
else
    // a - числа до. B -искомое. сс - две цифры после  aa..aaBcc/100 = aa..aaB.  aa..aaB % 10 = B   
    Console.Write($" третья цифра {(inputNumberInt / 100) % 10}");
