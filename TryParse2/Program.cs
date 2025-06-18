string input = "abc";
int number;

if (int.TryParse(input, out number))
{
    Console.WriteLine("Parsed successfully: " + number);
}
else
{
    Console.WriteLine("Parsing failed.");
}
