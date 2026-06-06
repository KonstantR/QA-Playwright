
int countNumbers = int.Parse(Console.ReadLine());
double sum = 0;
for (int count = 1; count <= countNumbers; count++)
{
    double value = double.Parse(Console.ReadLine());
    sum = sum + value;
}
Console.WriteLine(sum);