string[] wordLessOrEqualThree(string userText)
{
    string[] array = userText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int amountWords = 0;
    foreach (var item in array) if (item.Length <= 0) amountWords += 1;
    string[] new_array = new string[amountWords];
    amountWords = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[amountWords] = array[i];
            amountWords += 1;
        }
    }
    return new_array;
}