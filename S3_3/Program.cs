// Vvesti koordinaty dvuh tochek i naiti rasstoyanie mejdu nimi

double S(double x1, double y1, double x2, double y2)
{
   double s = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
   return s; 
}
Console.WriteLine("Vedite koordinaty pervoy tochki");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Vedite koordinaty vtoroy tochki");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double rasstoyanie = S(x1, y1, x2, y2);
Console.WriteLine("Rasstoyanie mejdu tochkami = " + rasstoyanie);
