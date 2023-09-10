int a = 1;
int b = 2;
int c = 3;


while (true)
{
    Console.WriteLine("Choose entry method (1, 2, 3, 0 to exit):");

    int e = Convert.ToInt32(Console.ReadLine());
    if (e == a)
    {
        Console.Write("Enter start value: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter step value: ");
        int step = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Generated sequence:");
        for (int i = 0; i < n; i++)
        {
            int element = start + i * step;
            Console.Write(element + " ");
        }
    }
    else if (e == b)
    {
        Console.Write("Enter start value: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end value: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter step value: ");
        int step = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Generated sequence:");
        for (int i = start; i <= end; i += step)
        {
            Console.Write(i + " ");
        }
    }
    else if (e == c)
    {
        Console.Write("Enter start value: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter step value: ");
        int step = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Generated sequence:");
        int element = start;
        for (int i = 0; i < n; i++)
        {
            Console.Write(element + " ");
            element *= step;
        }
    }
    else if (e == 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}