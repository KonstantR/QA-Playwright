int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double persentOccupied = double.Parse(Console.ReadLine());

int volume = length * width * height;
double volumeInLiters = volume * 0.001;
double requiredLiters = volumeInLiters * (1 - persentOccupied/100);

Console.WriteLine($"{requiredLiters:F2}");

