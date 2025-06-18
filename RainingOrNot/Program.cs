bool rain;

Console.Write("Write a value: ");
rain = bool.Parse(Console.ReadLine());

if (rain == true)
{
    Console.WriteLine("Take Umbrella");
}
else if (rain == false)
{
    Console.WriteLine("You Need not Take Umbrella");
}
else
{
    Console.WriteLine("I Don't know");
}
