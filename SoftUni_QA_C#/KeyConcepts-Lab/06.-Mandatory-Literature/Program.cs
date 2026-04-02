//1. входни данни
int totalPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int needDays = int.Parse(Console.ReadLine());

//2. изчисляваме колко време му трябва, за да прочете книгата = общ брой страници / страници, които чете за 1 час
int totalTime = totalPages / pagesPerHour;

//3. изчисляваме нужните часове четене на ден: общо време за четене на книгата / дните, за които трябва да я прочете
int needHoursPerDay = totalTime / needDays;

//4. отпечатваме нужните часове четене на ден
Console.WriteLine(needHoursPerDay);

