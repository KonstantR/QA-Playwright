//1. въвежда стойността на доларите (дробно число)
double usd = double.Parse(Console.ReadLine());

//2. преобразуваме долари в евро => долари * 0.88
double eur = usd * 0.88;

//3. отпечатваме евро, форматирана с 2 цифри
Console.WriteLine($"{eur:F2}");
