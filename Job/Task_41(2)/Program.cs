/*
Задача 41:
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

Пример:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите количество чисел -M-:");

int nember = int.Parse(Console.ReadLine());
int[] enterNumber = new int [nember];
int countNumber = 0;
System.Console.WriteLine("-------------------\n");

for (int i = 0; i < enterNumber.Length; i++)
{
    System.Console.Write($"Введите число {i+1}: --> ");
    enterNumber[i] = int.Parse(Console.ReadLine());
    if(enterNumber[i]>0)
    {
            countNumber++;
    }
}
System.Console.WriteLine("-------------------");
System.Console.WriteLine($"Веедёных чисел больше нуля: {countNumber}");
System.Console.WriteLine();









