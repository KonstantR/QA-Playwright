//1. входни данни
int countPens = int.Parse(Console.ReadLine()); //брой пакети химикали
int countMarkers = int.Parse(Console.ReadLine()); //брой на пакети маркери
int quantityCleaner = int.Parse(Console.ReadLine()); // литри препарат
int discount = int.Parse(Console.ReadLine()); //процент отстъпка -> 15%

//2. обща сума за химикали = бр. химикали * 5.80
double sumPens = countPens * 5.80;
//3. обща сума за маркери = бр. маркери * 7.20
double sumMarkers = countMarkers * 7.20;
//4. обща сума за препарат = кол. препарат * 1.20
double sumCleaner = quantityCleaner * 1.20;
//5. обща сума за всичко = обща сума за химикали + обща сума за маркери + обща сума за препарат
double totalSum = sumPens + sumMarkers + sumCleaner;

//6. обща сума за всичко - отстъпка
totalSum = totalSum - (discount / 100.0) * totalSum;

//7. отпечатвам крайната сума след отстъпката
Console.WriteLine(totalSum);
