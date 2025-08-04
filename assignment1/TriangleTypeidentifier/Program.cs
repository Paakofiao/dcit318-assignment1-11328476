// See https://aka.ms/new-console-template for more information
Console.WriteLine("First Side");
int sideOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second Side");
int sideTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Third Side");
int sideThree = Convert.ToInt32(Console.ReadLine());


if (sideOne == sideTwo || sideTwo == sideThree || sideOne==sideThree)
{
    Console.WriteLine("The triangle  is Isosceles");
}
else if (sideOne == sideTwo && sideTwo == sideThree)
{
    Console.WriteLine("The triangle is equilateral");
} 
else  {
    Console.WriteLine("The Triangle is Scalene");
}