
Console.Clear();
string[] ArrayA = {"Hello", "2", "world", ":-)","ghgh","hg"};
string[] Find(string[] ArrayA)
{
    string[] ArrayB = new string[0];
    int j = 0;
    for (int i = 0; i < ArrayA.Length; i++)
    {
        if (ArrayA[i].Length <= 3)
        {
            int lenght = ArrayB.Length;
            Array.Resize(ref ArrayB, lenght + 1);
            ArrayB[j] = ArrayA[i];
            j++;

        }

    }
    return (ArrayB); 
}
void WriteArray(string[] ArrayA, string[] ArrayB)

{
    Console.Write("[");
    for (int i = 0; i < ArrayA.Length; i++)
    {
        Console.Write(ArrayA[i]);
        if (i != ArrayA.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < ArrayB.Length; i++)
    {
        Console.Write(ArrayB[i]);
        if (i != ArrayB.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

WriteArray(ArrayA, Find(ArrayA));