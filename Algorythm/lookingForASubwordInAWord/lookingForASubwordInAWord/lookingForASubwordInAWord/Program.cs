Console.WriteLine("Witaj, Świat!");
main();

static void main()
{
    string word = "lokomotywa";
    string subword = "motyw";
    if (lookingForASubwordInAWord(word, subword))
        Console.WriteLine("W słowie " + word + " znajduję się słowo " + subword);
    else
        Console.WriteLine("W słowie " + word + " nie znajduję się słowo " + subword);

}
static bool lookingForASubwordInAWord(string word, string subword)
{
    for (int i = 0; i < word.Length - 1; i++)
    {
        for (int j = 0; j < subword.Length - 1; j++)
        {
            if (i + j > word.Length - 1)
                break;
            if (word[i + j] != subword[j])
            {
                break;
            }
            if (j == subword.Length - 2)
                return true;//jeżeli chcielibyśmy zwracać przedział to int[,] = [i,i+j]
        }
    }
    return false;
}