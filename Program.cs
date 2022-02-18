for (int i = 0; i < 100; i++)
{
    if (!(i.ToString().Contains('4') || i.ToString().Contains('5')))
    {
        Console.WriteLine(i);
    }
    else { Console.WriteLine("\n"); }
}
