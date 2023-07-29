// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] Array(int len) //заполняем массив данными
{
    string[] array = new string[len];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array) // метод вывода массива на экран
{
    foreach (string item in array)
    {
        System.Console.Write(item + ' ' );
    }
    System.Console.WriteLine();
}

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int Count_3(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int k = arr[i].Length;
        if (k < 4)
        {
            count++;
        }
    }
    return count;
}

string[] NewArr(int len,string[] arr)
{
    string[] arrayNew = new string[len];
    int i_New = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            arrayNew[i_New] = arr[i];
            i_New++;
        }
    }
    return arrayNew;
}


Console.Clear();
int len = Prompt("Введите длину массива ");

Console.WriteLine("Введите строки в массив через Enter:");
string[] arr = Array(len);

System.Console.WriteLine();
Console.WriteLine("Исходный массив:");
PrintArray(arr);

int count_3 = Count_3(arr);

string[] arrNew = NewArr(count_3, arr);
System.Console.WriteLine();
Console.WriteLine("Новый массив:");
PrintArray(arrNew);