// See https://aka.ms/new-console-template for more information

int tickets = 10;
int discount = tickets - 3; 
Console.WriteLine("Enter your age");

int ageofBuyer = Convert.ToInt32(Console.ReadLine());

if (ageofBuyer >= 65 || ageofBuyer <= 12)
{
    Console.WriteLine("You are eligble for discount");
    Console.WriteLine($"your price is {discount} GHC");
}
else
{
    Console.WriteLine("You are not eligible for discount");
    Console.WriteLine($"your price is still {tickets} GHC");
}


