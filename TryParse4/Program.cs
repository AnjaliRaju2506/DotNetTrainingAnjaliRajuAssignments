string input = "2025-06-16";
DateTime date;

if (DateTime.TryParse(input, out date))
{
    Console.WriteLine("Parsed date: " + date.ToShortDateString());
}
else
{
    Console.WriteLine("Invalid date format.");
}
