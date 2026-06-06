List<int> numbers = Console.ReadLine()
                         .Split(" ")
                         .Select(int.Parse)
                         .ToList();


while (true)
{
    string input = Console.ReadLine();


    if (input == "End")
    {
        break;
    }


    string[] cmdArg = input.Split(" ");
    string command = cmdArg[0];

    if (command == "Add")
    {
        int currentNumber = int.Parse(cmdArg[1]);
        numbers.Add(currentNumber);
    }
    else if (command == "Insert")
    {
        int currentNumber = int.Parse(cmdArg[1]);
        int index = int.Parse(cmdArg[2]);
        if (index >= 0 && index < numbers.Count)
        {
            numbers.Insert(index, currentNumber);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    else if (command == "Remove")
    {
        int index = int.Parse(cmdArg[1]);
        if (index >= 0 && index < numbers.Count)
        {
            numbers.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }

    }
    else if (command == "Shift")
    {
        string direction = cmdArg[1];
        int count = int.Parse(cmdArg[2]);

        if (direction == "left")
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
        else if (direction == "right")
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }
}
Console.WriteLine(string.Join(" ", numbers));
