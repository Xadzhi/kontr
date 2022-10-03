string[] Str = new string[11] {"Hello", "2", "world", ":-0","1234", "1567", "-2", "computer science","Russia", "Denmark", "Kazan"};
string[] AA = new string[Str.Length];
void Metod(string[] Str, string[] AA)
{    int A = 0;
    for (int i = 0; i < Str.Length; i++)
    {if(Str[i].Length <= 3)
        {
        AA[A] = Str[i];
        A++;
        }
    }
}
void Print(string[] array)
{    for (int i = 0; i < array.Length; i++)
    {        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Metod(Str, AA);
Print(AA);