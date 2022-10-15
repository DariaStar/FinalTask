// Написать программу, которая из имеющегося массива строк формиирует массив из строк, 
// длина которых меньше или равно терм символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выоплнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] InputArray() 
{
    Console.WriteLine("Enter elements devided by spaces: ");
    return Console.ReadLine().Split(" ");
}

int Count(string[] inArray) 
{
    int count = 0;
    for(int i = 0; i < inArray.Length; i++) {
        if(inArray[i].Length <= 3) 
        {
            count++;
        }
    }

    return count;
}

string[] OutputArray(string[] inArray) 
{
    string[] output = new string[Count(inArray)];
    for(int i = 0, j = 0; i < inArray.Length; i++) 
    {
        if(inArray[i].Length <= 3) 
        {
            output[j] = inArray[i];
            j++;
        }
    }

    return output;
}
string[] inArray = InputArray();
string[] outArray = OutputArray(inArray);
Console.WriteLine($"3 or less symbols elements are: {string.Join(", ", outArray)}");