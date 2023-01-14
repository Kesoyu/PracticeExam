Console.WriteLine("Witaj, Świat!");
main();

static void main()
{
    const int length = 5;
    string[] array = new string[5];
    array[0] = "oko";
    array[1] = "rower";
    array[2] = "kaktus";
    array[3] = "kajak";
    array[4] = "jamaj";
    for (int i = 0; i < length; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
    for (int i = 0; i < length; i++)
        if (isPalindrom(array[i]))
            Console.WriteLine(array[i] + " słowo jest palindromem");
        else
            Console.WriteLine(array[i] + " słowo nie jest palindromem");

}

static bool isPalindrom(string word)
{
    for(int i = 0; i < word.Length/2; i++)
        if (word[i] != word[(word.Length-1) - i])
            return false;
    return true;
}