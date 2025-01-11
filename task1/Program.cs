int num = Convert.ToInt16(Console.ReadLine());
int sum = Convert.ToInt16(0);
for (int i=num; i>0; i/=10)
{
    sum+=i%10;
}
System.Console.WriteLine("Sum: "+sum);