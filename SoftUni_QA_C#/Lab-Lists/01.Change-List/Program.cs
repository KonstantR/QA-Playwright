List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Delete"))
    {

        int numberToDelete = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAll(element => element == numberToDelete);
    }
    else if (command.StartsWith("Insert"))
    {

        int elementToInsert = int.Parse(command.Split(" ")[1]);
        int positionToInsert = int.Parse(command.Split(" ")[2]);
        numbers.Insert(positionToInsert, elementToInsert);
    }
    
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));