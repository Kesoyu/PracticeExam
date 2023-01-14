Console.WriteLine("Hello, World!");
main();

static void main()
{
    Random random = new Random();
    for(int i = 0; i < 10; i++)
    {
        int number = random.Next(1, 100);
        if (isPrime(number))
            Console.WriteLine(number + " number is prime");
        else
            Console.WriteLine(number + " number isnt prime");
    }
}

static bool isPrime(int value)
{
    if (value < 2 && value>0)   
    {
        return true;
    }
    for(int i = 2; i <= value / 2; i++)
    {
        if (value % i == 0)
        {
            return false;
        }
    }
    return true;
}