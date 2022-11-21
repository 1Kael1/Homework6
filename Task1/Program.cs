// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел которое вы хотите вводить");
int a = Convert.ToInt32(Console.ReadLine());
 int ineq = 0;
for (int i = 0; i < a; i++)
{
    Console.WriteLine($"Введите {i}ое число ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    if (num > 0)
    {
       ineq ++;
    }
    
}
Console.WriteLine($"Количество положительных чисел --->  {ineq}");