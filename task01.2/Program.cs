Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел равна = {GetSumNums(num)}");

// Console.Write("Введите число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма чисел равна = {GetSumNums(num1)}");

// Console.Write("Введите число: ");
// int num2 = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма чисел равна = {GetSumNums(num2)}");

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        Console.Write($"{number} ");
        sum += number;
        number--;
    }
    return sum;
}
