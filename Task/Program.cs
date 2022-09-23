/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.Clear();
string[] array = { "hello", "2", "world", ":-)" };//или {“1234”, “1567”, “-2”, “computer science”}; {“Russia”, “Denmark”, “Kazan”};
void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.Write("Первоначальный массив");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SortArray(string[] array)
{
    Console.WriteLine("Все элементы массива, длина которых меньше или равна 3-м символам");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + "  ");
        }
    }
    Console.WriteLine();
}
PrintArray(array);
Console.WriteLine();
SortArray(array);
Console.WriteLine();
