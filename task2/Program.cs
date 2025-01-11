// System.Console.Write("Celsius: ");
// float num = Convert.ToInt16(Console.ReadLine());
// System.Console.WriteLine((num*9/5)+32);

//task3
// System.Console.Write("Radius: ");
// double num = Convert.ToDouble(Console.ReadLine());
// double num2 = Convert.ToDouble(3.14);
// double num3 = Convert.ToDouble(num2*25);
// System.Console.WriteLine("Area: "+num3);
// System.Console.WriteLine("Circumference: "+num2);


//task4
// System.Console.Write("Year: ");
// int num = Convert.ToInt16(Console.ReadLine());
// if (num%4==0)
// {
//     System.Console.WriteLine("Leap Year: Yes");
// }


//task5
// void metod (int num, int[] arr)
// {
//     int min = Convert.ToInt16(999);
//     int max = Convert.ToInt16(-999);
//     for (int i=0; i<num; i++){
//         arr[i] = Convert.ToInt16(Console.ReadLine());
//     }
//     for (int i=0; i<num; i++)
//     {
//         if (min>arr[i])
//         {
//             min=arr[i];
//         }
//     }
//     for (int i=0; i<num; i++)
//     {
//         if (max<arr[i])
//         {
//             max=arr[i];
//         }
//     }
//     System.Console.WriteLine("min: "+min);
//     System.Console.WriteLine("max: "+max);
//     System.Console.WriteLine("sum: "+(min+max));
// }
// int num = Convert.ToInt16(Console.ReadLine());
// int[] arr = new int[num];
// metod(num,arr);



//task6
// void metod(int num, int[] arr)
// {
//     for (int i = 0; i < num; i++)
//     {
//         arr[i] = Convert.ToInt16(Console.ReadLine());
//         if (arr[i]%2==0)
//         {
//             arr[i]=0;
//         }
//         else {
//             arr[i]=1;
//         }
//     }
//     for (int i=0; i<num; i++)
//     {
//         System.Console.Write(arr[i]+" ");
//     }
// }
// int num = Convert.ToInt16(Console.ReadLine());
// int[] arr = new int[num];
// metod(num, arr);



//task7
// void metod(int num, int[] arr)
// {
//     int cnt = Convert.ToInt16(0);
//     for (int i = 0; i < num; i++)
//     {
//         arr[i] = Convert.ToInt16(Console.ReadLine());
//     }
//     int num2 = Convert.ToInt16(Console.ReadLine());
//     for (int i = 0; i < num; i++)
//     {
//         for (int j = 0; j < num; j++)
//         {
//             if ((arr[i] + arr[j]) == num2)
//             {
//                 System.Console.WriteLine(arr[i] + " " + arr[j]);
//                 cnt++;
//             }
//         }
//         if (cnt >= 2)
//         {
//             break;
//             }
//     }
// }
// int num = Convert.ToInt16(Console.ReadLine());
// int[] arr = new int[num];
// metod(num, arr);


//task8

// string word = Console.ReadLine();
// int vowels = Convert.ToInt16(0);
// int consonants = Convert.ToInt16(0);

// for (int i=0; i<word.Length; i++)
// {
//     if (word[i]=='e' || word[i]=='o' || word[i]=='a' || word[i]=='i' || word[i]=='y')
//     {
//         vowels++;
//     }
//     else {
//         consonants++;
//     }
//     if (word[i]==' ')
//     {
//         consonants--;
//     }
// }
// System.Console.WriteLine("Vowels: "+vowels);
// System.Console.WriteLine("Consonants: "+consonants);

