Console.WriteLine("INPUT YOUR GRADE");
int gradeInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your grade is {gradeInput} out of 100");

if (gradeInput >= 90)
{
    Console.WriteLine("Your grade is an A");
}
else if (gradeInput >= 80 && gradeInput <= 89)
{
    Console.WriteLine("Your grade is a B");
}
else if (gradeInput >= 70 && gradeInput <= 79)
{
    Console.WriteLine("Your grade is a C");
}
else if (gradeInput >= 60 && gradeInput <= 69)
{
    Console.WriteLine("Your Grade is a D");
}
else 
{
    Console.WriteLine("Your grade is an F");
}



