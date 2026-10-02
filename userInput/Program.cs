Console.WriteLine("Enter your name: ");
string userName = Console.ReadLine();

Console.WriteLine("Enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());

int age_5Years = userAge + 5;
Console.WriteLine($"Hello, {userName}! In 5 years, you will be {age_5Years}.");

//Checks category
if (userAge < 13)
{

    Console.WriteLine("You are a child.");
}
else if (userAge >= 13 && userAge <= 19)
{
    Console.WriteLine("You are a teenager.");
}
else if (userAge > 19 && userAge <= 110)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("Invalid age inputted");
}