/*
// ======= Pyramid ======= \\

for (int i = 10; i >= 1; i--)
{
    for (int j = 1; j <= 10 - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

// ======= Reversed Pyramid ======= \\

  for (int i = 10; i >= 1; i--)
{
    for(int j = 1; j <= 10 - i; j++)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

// ======= Hollow Pyramid ======= \\

  int rows = 10;

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= rows - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= i; k++)
    {
        if (k == 1 || k == i || i == rows)
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}*/