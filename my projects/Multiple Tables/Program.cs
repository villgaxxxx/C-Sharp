for(int i = 1; i <= 12; i++)
{
    Console.WriteLine($"======= Table {i} =======");
    for(int j = 1; j <= 12; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}