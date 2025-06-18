double i, j, res = 0;
string opr;

Console.Write("Value 1 : ");
i = Double.Parse(Console.ReadLine());

Console.Write("Value 2 : ");
j = Double.Parse(Console.ReadLine());

Console.Write("Enter the opeator:");
opr = Console.ReadLine();

if (opr == "+")
{
    res = i + j;
}
else if (opr == "-")
{
    res = i - j;
}
else if (opr == "*")
{
    res = i * j;
}
else if (opr == "/")
{
    res = i / j;
}
else
{
    Console.WriteLine("I don't know");
}
Console.WriteLine(res);