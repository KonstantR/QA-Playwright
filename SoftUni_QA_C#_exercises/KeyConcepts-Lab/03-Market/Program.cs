//1. входни данни
double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());

//2. изчислим колко трябва да се заплати за доматите
double tomatoSum = tomatoQuantity * tomatoPrice;
//3. изчислим колко трябва да се заплати за краставиците
double cucumberSum = cucumberQuantity * cucumberPrice;
//4. изчислим колко общо трябва да плати = сума за доматите + сума за краставиците
double totalSum = tomatoSum + cucumberSum;

//5. отпечатваме крайната сума
Console.WriteLine($"{totalSum:F2}");
