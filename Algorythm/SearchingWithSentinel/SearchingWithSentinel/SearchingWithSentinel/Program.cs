// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
main();
static void main()
{
    const int range = 50;
    int[] array = new int[range];
    Random random = new Random();
    for(int i = 0; i < range; i++)
        array[i] = random.Next(1, 10);
    int result = searchingWithSentinel(array, 5);
    if (result == -1)
    {
        Console.WriteLine("nie znaleziono szukanej wartości");
    }
    else
    {
        Console.WriteLine("Szukana wartośc znaduje się pod index: " + result);
    }
}


static int searchingWithSentinel(int[] array, int number)
{
    int[] coppied = new int[array.Length+1];
    array.CopyTo(coppied, 0);
    coppied[array.Length] = number;
    showArray(coppied);
    showArray(array);
    for(int i = 0; i < coppied.Length; i++)
    {
        if (coppied[i] == number && i!=coppied.Length-1)
        {
            return i;
        }
        else if(coppied[i] == number && i == coppied.Length - 1)
        {
            return -1;
        }
    }
    return -1;
}

static void showArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i+1 != array.Length)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + "\n");
    }

}