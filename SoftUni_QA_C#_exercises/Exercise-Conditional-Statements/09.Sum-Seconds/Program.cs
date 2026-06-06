int firstAthlete = int.Parse(Console.ReadLine());
int secondAthlete = int.Parse(Console.ReadLine());
int thirdAthlete = int.Parse(Console.ReadLine());

int sumTimeInSeconds = firstAthlete + secondAthlete + thirdAthlete;
int minutes = sumTimeInSeconds / 60;
int seconds = sumTimeInSeconds % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}