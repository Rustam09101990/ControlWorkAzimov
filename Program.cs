
// все натуральные числа в промежутке от m n 
void Numbers (int m, int n)
{
   if (m > n)
       return;
    Console.Write($"{m} ");
    Numbers(m + 1, n);
}
Numbers(5, 100);

///Функция Аккермана 

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return akkerman(m - 1, 1);
    else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");
// Задача 3
using System.Linq.Expressions;

void PrintArray(int[] array, int current = 0)
{

    {
        Console.Write(" " + array[current++]);
        PrintArray(array, current);
    }
}

int [] NewArray = [1,2,3,5,6,7,8,10];
PrintArray(NewArray);
