//1. входни данни
double distance = double.Parse(Console.ReadLine());
double time = double.Parse(Console.ReadLine());

//2. изчисляваме скоростта = distance / time
double speed = distance / time;

//3. отпечатваме скоростта
Console.WriteLine($"{speed:F2}");
