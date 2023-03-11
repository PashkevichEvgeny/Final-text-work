string[] wordLessOrEqualThree(string userText)
{
    int wordSize = 3;
    string[] array = userText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int amountWords = 0;
    foreach (var item in array) if (item.Length <= wordSize) amountWords += 1;
    string[] new_array = new string[amountWords];
    amountWords = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= wordSize)
        {
            new_array[amountWords] = array[i];
            amountWords += 1;
        }
    }
    return new_array;
}

Console.Write("Напишите несколько слов: ");
string userString = Console.ReadLine()!;
string[] testArray = wordLessOrEqualThree(userString);
Console.WriteLine($"[\"{string.Join("\", \"", testArray)}\"]");