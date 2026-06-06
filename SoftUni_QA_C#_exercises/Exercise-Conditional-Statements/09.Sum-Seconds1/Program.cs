int firstAthlete = int.Parse(Console.ReadLine());
int secondAthlete = int.Parse(Console.ReadLine());
int thirdAthlete = int.Parse(Console.ReadLine());

int sumTimeInSeconds = firstAthlete + secondAthlete + thirdAthlete;
int minutes = sumTimeInSeconds / 60;
int seconds = sumTimeInSeconds % 60;


Console.WriteLine($"{minutes}:{seconds:D2}");

