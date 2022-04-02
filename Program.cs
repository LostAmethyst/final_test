//Из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] GetArray(string[] firstArray)
{
    string[] newArray = new string[firstArray.Length];
    int realSize = 0;
    for (var i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[realSize] = firstArray[i];
            realSize++;
        }
    }
    Array.Resize(ref newArray, realSize);
    return newArray;
}