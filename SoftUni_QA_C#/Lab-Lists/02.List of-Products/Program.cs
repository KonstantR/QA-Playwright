int countProducts = int.Parse(Console.ReadLine());

List<string> products = new List<string>();

for (int product = 1; product <= countProducts; product++)
{
    string productName = Console.ReadLine();
    products.Add(productName);
}

products.Sort();

int number = 1;
foreach (string productName in products)
{
    Console.WriteLine(number + "." + productName);
    number++;
}