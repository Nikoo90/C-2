Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (num < 100) Console.WriteLine("no third digit");
else
{
    if (num >= 1000)
    {
        while (true)
        {
            num /= 10;
            if (num < 1000)
            {
                result = num % 10;
                break;
            }
        }
    }
    else result = num % 10;

    Console.WriteLine($"Trird number: {result}");
}