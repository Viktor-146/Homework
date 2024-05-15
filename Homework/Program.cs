string[] array = { "123", "1567", "-2", "computer science", "22" };

    string[] newArray = new string[array.Length];
    int count = 0;

    Console.WriteLine("Новый массив:");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[count] = array[i];
            
            count++;
        }
    }

    string[] finalArray = new string[count];

    for (int i = 0; i < count; i++)
    {
        finalArray[i] = newArray[i];
        Console.Write(finalArray[i]);
        if (i != count - 1)
        {
            Console.Write(", ");
        }
    }
Console.WriteLine();