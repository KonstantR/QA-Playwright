//1. входни данни
double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());

//2. изчисляваме площта на банята = дължина * широчина
double bathroomArea = bathroomWidth * bathroomHeight;
//3. добавяме 10% към площта на банята
bathroomArea = bathroomArea + 0.1 * bathroomArea; // 1.1 * bathroomArea
//4. изчисляваме площта на една плочка = дължина на плочката * широчина на плочката
double tileArea = tileWidth * tileHeight;
//5. изчисляваме брой плочки = площ на банята, която трябва да покрием / площта на една плочка
double tilesCount = bathroomArea / tileArea;
//6. отпечатваме брой плочки -> Math.Round
Console.WriteLine(Math.Round(tilesCount));
