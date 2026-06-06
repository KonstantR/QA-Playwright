double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();

if (operation == "+")
{
    double result = firstNumber + secondNumber;
    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:F2}");
}
else if (operation == "-")
{
    double result = firstNumber - secondNumber;
    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:F2}");
}
else if (operation == "*")
{
    double result = firstNumber * secondNumber;
    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:F2}");
}
else if (operation == "/")
{
    double result = firstNumber / secondNumber;
    Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:F2}");
}
