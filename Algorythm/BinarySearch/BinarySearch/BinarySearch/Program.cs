/// BinarySearch
Console.WriteLine("Witaj świecie");
main();
static void main()
{
    const int length = 100; 
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
        array[i] = i+1;
    for (int i = 0; i < length; i++)
        Console.Write(array[i] + ", ");
    int position = binarySearch(length, array, 29); //should be 28
    Console.WriteLine("Searched position\n" + position);

}

static int binarySearch(int length, int[] array, int search)
{
    int left=0,right=length-1;
    while (left <= right)
    {
        int sr = (left + right) / 2;
        if (array[sr] == search)
            return sr;
        if (search > array[sr])
        {
            left = sr - 1;
        }
        else
        {
            right= sr+1;
        }
    }
    return -1;
}