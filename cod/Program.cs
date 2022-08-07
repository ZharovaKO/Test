// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решение не рекомендуется
//  пользоваться коллекциями, лучше обойтись исключительно массивами

string[] firstArray = new string [7] {"hey", "2003", "how", "4589", "are", "friend", "you"};
string[] secondArray = new string [firstArray.Length];
int temp = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        secondArray[temp] = firstArray[i];
        temp++;
    }
}

void writeArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Массив до сортировки: ");
writeArray(firstArray);
Console.WriteLine("Массив после сортировки: ");
writeArray(secondArray);