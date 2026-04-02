//1. входни данни -> брой дни, които трябва да преобразувам
int days = int.Parse(Console.ReadLine());

//2. изчисляваме броя на минутите
int minutes = days * 24 * 60;

//3. отпечатваме информация за минутите
Console.WriteLine($"Minutes = {minutes}");
