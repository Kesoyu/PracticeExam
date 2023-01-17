Console.WriteLine("Witaj, Świecie");
main();


int[] initTable(int range)
{
    int[] array = new int[range];
    Random random = new Random();
    for(int i = 0; i < range; i++)
    {
        array[i] = random.Next(1, 10);
    }
    return array;
}

void main()
{
    int[] array = initTable(100);
    //showArray(array);
    array = sortBySelection(array);
    //showArray(array);


}

void showArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        
        if (i != array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i] + "\n");
        }
    }
}


int[] sortBySelection(int[] array)
{
    int[] helpArray = new int[array.Length];
    array.CopyTo(helpArray, 0);
    for (int i = 0; i < array.Length; i++)
    {
        int highestValueIdx = theHighestValue(array,i);
        Console.WriteLine(highestValueIdx +": "+ array[highestValueIdx]);
        int helpValueHolder = array[i];
        array[i] = array[highestValueIdx];
        array[highestValueIdx] = helpValueHolder;
        showArray(array);
    }
    return array;
}

int theHighestValue(int[] array, int zakres)
{
    int maxValue = zakres;
    for(int i = zakres; i < array.Length; i++)
    {
        if (array[maxValue] < array[i])
        {
            maxValue = i;
        }
    }
    return maxValue;
}