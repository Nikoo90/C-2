Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = (num % 100 - num % 10) / 10;
Console.WriteLine(result);
