
int FindMaxDigit (int number)
{
    int ed = number%10;
    int des = (number%100)/10;
    int sot = number/100;
    int max;

    if (ed>des) 
    {
      max = ed;  
    }
    
    else 
    {
      max = des;
    }

    if (max<sot)
    {
     max = sot;
    }
    return max;
       
}
int rand = new Random().Next(100,1000);

int maxDigit = FindMaxDigit(rand);
Console.WriteLine($"maximal digit of {rand} is {maxDigit}");