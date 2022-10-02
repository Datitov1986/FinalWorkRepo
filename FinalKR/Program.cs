
string [] array1 = {"Hello", "Peace", "Geek", "Brain", "2", "Go"};
string [] array2 = new string[array1.Length];
PrintArray(array1);
ReplaceArray(array1, array2);
PrintArray(array2);


void PrintArray(string [] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]}  ");
    }
    Console.WriteLine();
}

void ReplaceArray(string [] array1, string [] array2)
{

    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}