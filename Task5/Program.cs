void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //заполнение массива collection числами от 1 до 10
        index++; // index=index+1;
    }
}
void PrintArray(int[] col) //void - когда метод ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 ставится для того, чтобы не было нулевой позиции при отсутствии элемента в массиве

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index ++;
    }
    return position;
}

int[] array = new int[10]; // создает массив с 10 случайными числами. По умолчанию они все нули

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

