


string[] array = {"33", "mamamia", "how", "name", "is", ":)"};
//string[] array1 = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine(); 

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length > 3)
        array[i] = "!";

//Console.Write($"{array[i]} ");
}
 
Console.WriteLine();

array = array.Except(new string[]{"!"}).ToArray();

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}


