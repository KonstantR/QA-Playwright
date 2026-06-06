int number = int.Parse(Console.ReadLine());

int result = GetMultipleOfEvenAndOdds(Math.Abs(number));
Console.WriteLine(result);











static int GetSumOfEvenDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        if (lastDigit % 2 == 0)
        {
            sum = sum + lastDigit;
        }
        num = num / 10;
    }
    return sum;
}

static int GetSumOfOddDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        if (lastDigit % 2 != 0)
        {
            sum = sum + lastDigit;
        }
        num = num / 10;
    }

    return sum;
}

static int GetMultipleOfEvenAndOdds(int num)
{
    int sumOfEvenDigits = GetSumOfEvenDigits(num);
    int sumOfOddDigfits = GetSumOfOddDigits(num);

    return sumOfEvenDigits * sumOfOddDigfits;

}
