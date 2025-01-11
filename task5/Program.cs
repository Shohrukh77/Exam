void metod (int num, int[] arr)
{
    int min = Convert.ToInt16(999);
    int max = Convert.ToInt16(-999);
    for (int i=0; i<num; i++){
        arr[i] = Convert.ToInt16(Console.ReadLine());
    }
    for (int i=0; i<num; i++)
    {
        if (min>arr[i])
        {
            min=arr[i];
        }
    }
    for (int i=0; i<num; i++)
    {
        if (max<arr[i])
        {
            max=arr[i];
        }
    }
    System.Console.WriteLine("min: "+min);
    System.Console.WriteLine("max: "+max);
    System.Console.WriteLine("sum: "+(min+max));
}
int num = Convert.ToInt16(Console.ReadLine());
int[] arr = new int[num];
metod(num,arr);