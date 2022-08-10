/*
Задача 41:
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

Пример:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("введите числа:");
int count = 0;
int minusCount = 0;
int zero = 0;

while (true)
{
    string number = Console.ReadLine();

    if (number == "stop")
    {
        break;
    }

    if (int.Parse(number) > 0)
    {
        count++;
    }
    if (int.Parse(number) < 0)
    {
        minusCount++;
    }
    if (int.Parse(number) == 0)
    {
        zero++;
    }

}
Console.WriteLine(count + " Чисел больше нуля!");
Console.WriteLine(minusCount + " Чисел меньше нуля!");
Console.WriteLine(zero + " Чисел равных нулю!");
