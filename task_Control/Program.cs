// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Сколько строк вы хотите ввести? ");
int size = int.Parse(Console.ReadLine() ?? "0");
string[] arrayStrings = new string[size];
int length = 3;
int position = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine() ?? "0");
    if (element.Length <= length)
    {
        arrayStrings[position] = element;
        position++;
    }
}
Console.WriteLine();
PrintArray(arrayStrings);