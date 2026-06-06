//1. въвеждаме две дробни числа
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());

//2. извършваме операцията събиране
double sum = firstNumber + secondNumber;
//3. извършваме операцията изваждане
double subtract = firstNumber - secondNumber;
//4. извършваме операцията умножение
double product = firstNumber * secondNumber;
//5. извършваме операцията деление
double division = firstNumber / secondNumber;

//6. отпечатване 
Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {sum:F2}");
Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {subtract:F2}");
Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {product:F2}");
Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {division:F2}");
