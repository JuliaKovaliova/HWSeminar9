int Input (string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowIntegersFromN (int n, int m)
{
    if (n>=m) 
    {
        ShowIntegersFromN(n, m+1); 
        Console.Write($"{m} ");
    }
    else 
        if (n<0 || n==0) Console.WriteLine("Error");
}

Console.WriteLine("Задача 64:");
int n = Input("Enter positive integer: ");
ShowIntegersFromN(n,1);
Console.WriteLine();


// Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumIntegersFromMToN (int m, int n)
{
    if (m==n) return n;
    return SumIntegersFromMToN(Math.Max(m, n), Math.Min(m,n)+1)
    + Math.Min(m,n);
}
Console.WriteLine();
Console.WriteLine("Задача 66:");
int firstNum = Input ("Enter first number: ");
int secondNum = Input ("Enter second number: ");
Console.WriteLine(SumIntegersFromMToN(firstNum, secondNum));