string season = Console.ReadLine();
string accommodationtype = Console.ReadLine();
int countOfNights = int.Parse(Console.ReadLine());
double priceForOneNight = 0;
double discountPercent = 0;

if (season == "Spring")
{
    discountPercent = 20;
    
    if (accommodationtype == "Hotel")
    {
        priceForOneNight = 30;   
    }
    else if (accommodationtype == "Camping")
    {
        priceForOneNight = 10;
    }
}

else if (season == "Summer")
{
    discountPercent = 0;

    if (accommodationtype == "Hotel")
    {
        priceForOneNight = 50;
    }
    else if (accommodationtype == "Camping")
    {
        priceForOneNight = 30;
    }

}

else if (season == "Autumn")
{
    discountPercent = 30;
    
    if (accommodationtype == "Hotel")
    {
        priceForOneNight = 20;
    }
    else if (accommodationtype == "Camping")
    {
        priceForOneNight = 15;
    }

}

else if (season == "Winter")
{
    discountPercent = 10;

    if (accommodationtype == "Hotel")
    {
        priceForOneNight = 40;
    }
    else if (accommodationtype == "Camping")
    {
        priceForOneNight = 10;
    }
     
}

double priceForAllNights = countOfNights * priceForOneNight;
double discount = priceForAllNights * discountPercent / 100;
double finalPrice = priceForAllNights - discount;
Console.WriteLine($"{finalPrice:F2}");