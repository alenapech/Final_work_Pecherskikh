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


