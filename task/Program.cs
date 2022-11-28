
int CountSuitableElements(string[] arr) // Подсчет элементов (строк) массива с подходящей длиной
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if(arr[i].Length<=3)
        {
            count++;
        }
    }
    return count;
}

string[] ArrayOfSuitableElements(string[] arr) // Создание массива из подходящих строк исходного массива
{
    string[] new_arr = new string[CountSuitableElements(arr)];
    int position = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if(arr[i].Length<=3)
        {
            new_arr[position]=arr[i];
            position++;
        }
    }
    return new_arr;
}

void PrintArray(string[] array) //Печать массива
{
    Console.Write("[");
    for(int i=0; i<array.Length; i++)
    {
        Console.Write('"');
        Console.Write($"{array[i]}");
        Console.Write('"');
        if(i<array.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

Console.Clear();
string[] arr = {"hello","2","world",":-)"}; // Тут можно ввести массив
PrintArray(arr);
Console.Write(" -> ");
PrintArray(ArrayOfSuitableElements(arr));