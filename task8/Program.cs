string word = Console.ReadLine();
int vowels = Convert.ToInt16(0);
int consonants = Convert.ToInt16(0);

for (int i=0; i<word.Length; i++)
{
    if (word[i]=='e' || word[i]=='o' || word[i]=='a' || word[i]=='i' || word[i]=='y')
    {
        vowels++;
    }
    else {
        consonants++;
    }
    if (word[i]==' ')
    {
        consonants--;
    }
}
System.Console.WriteLine("Vowels: "+vowels);
System.Console.WriteLine("Consonants: "+consonants);