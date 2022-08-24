
int SecondNumber (int number)
{
    int ed = number%10;
    // int des = (number%100)/10;
    int sot = number/100;
    int number2 = sot*10+ed;
    return number2;
       
}
int rand = new Random().Next(100,1000);

int secondNumber = SecondNumber(rand);
Console.WriteLine($"new number of {rand} is {secondNumber}");