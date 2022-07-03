int SumOfDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int remainder = num % 10;
        num = num / 10;
        sum = sum + remainder;
    }
    return sum;
}

Console.Write("Пожалуйста, введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(number);

Console.WriteLine("Сумма цифр введенного числа: " + result);
