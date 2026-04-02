int hour = int.Parse(Console.ReadLine());
string dayOfWeek = Console.ReadLine();

if (hour >= 10 && hour <= 18 && dayOfWeek != "Sunday")
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}
