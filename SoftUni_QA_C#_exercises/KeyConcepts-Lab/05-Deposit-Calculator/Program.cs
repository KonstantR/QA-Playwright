//1. входни данни
double depositSum = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine()); //5.7% -> 0.057

//2. изчисляваме крайната сума
//amount = deposited amount + term of deposit * (deposited amount * annual interest rate) / 12
double finalSum = depositSum + months * (depositSum * (percent / 100)) / 12;

//3. отпечатваме крайната сума
Console.WriteLine(finalSum);
