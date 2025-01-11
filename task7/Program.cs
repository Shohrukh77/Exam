void metod(int num, int[] arr)
{
    int cnt = Convert.ToInt16(0);
    for (int i = 0; i < num; i++)
    {
        arr[i] = Convert.ToInt16(Console.ReadLine());
    }
    int num2 = Convert.ToInt16(Console.ReadLine());
    for (int i = 0; i < num; i++)
    {
        for (int j = 0; j < num; j++)
        {
            if ((arr[i] + arr[j]) == num2)
            {
                System.Console.WriteLine(arr[i] + " " + arr[j]);
                cnt++;
            }
        }
        if (cnt >= 2)
        {
            break;
            }
    }
}
int num = Convert.ToInt16(Console.ReadLine());
int[] arr = new int[num];
metod(num, arr);