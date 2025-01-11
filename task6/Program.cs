void metod(int num, int[] arr)
{
    for (int i = 0; i < num; i++)
    {
        arr[i] = Convert.ToInt16(Console.ReadLine());
        if (arr[i]%2==0)
        {
            arr[i]=0;
        }
        else {
            arr[i]=1;
        }
    }
    for (int i=0; i<num; i++)
    {
        System.Console.Write(arr[i]+" ");
    }
}
int num = Convert.ToInt16(Console.ReadLine());
int[] arr = new int[num];
metod(num, arr);