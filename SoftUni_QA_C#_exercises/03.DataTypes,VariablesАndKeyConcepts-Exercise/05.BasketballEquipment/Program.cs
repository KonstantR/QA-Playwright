int feeForOneYear = int.Parse(Console.ReadLine());
double sneakersPrice = feeForOneYear - (feeForOneYear * 40 / 100);
double basketballUniformPrice = sneakersPrice - (sneakersPrice * 20 / 100);
double basketballBallPrice = basketballUniformPrice * 1/4;
double basketballAccessoriePrice = basketballBallPrice * 1/5;

double totalPrice = feeForOneYear + sneakersPrice + basketballUniformPrice + basketballBallPrice + basketballAccessoriePrice;
Console.WriteLine(totalPrice);

