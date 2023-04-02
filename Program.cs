Console.Clear();




void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    
}


void SecondArrayStatus(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


Console.WriteLine("задайте размер массива введя целое не отрицательное число: ");
int k = Int32.Parse(Console.ReadLine());

string[] arr1 = new string[k];
string[] arr2 = new string[arr1.Length];


Console.WriteLine("введите значения для каждого индекса массива: ");
FillArray(arr1);
Console.WriteLine("Выведим первоначальный массив: ");
PrintArray(arr1);
SecondArrayStatus(arr1, arr2);
Console.WriteLine("Выведим массив длина элементов которого меньше или равна 3 ");
PrintArray(arr2);
