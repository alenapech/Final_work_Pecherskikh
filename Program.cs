string[] getInputArray() 
{
    string[] array = {"Monday", "Day", ":)", "Baby", "Sun", "Lesson", "Learning", "Book", "Cat", "Dog"};
    return array;
}

void printArray(string[] currentArray)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
Console.WriteLine();
}

string[] getOutputArray(string[] currentArray)
{
    string[] outputArray = new string[currentArray.Length];
    int k = 0;

    for (int i = 0; i < currentArray.Length; i++)
    {
        if(currentArray[i].Length <= 3) 
        {
            outputArray[k] = currentArray[i];
            k++;
        }
    }
    return outputArray; 
}

