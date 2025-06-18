string input = "3.14";
double pi;

if (double.TryParse(input, out pi))
{
    Console.WriteLine("Parsed successfully: " + pi);
}
else
{
    Console.WriteLine("Parsing failed.");
}
