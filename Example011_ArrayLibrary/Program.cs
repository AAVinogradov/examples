// заполнения массива случайными числами и вывод, а после поиск индекса определенного значения (например 4 или 444)

//заполнение массива случайными числами
void FillArray(int[] collection) // метод заполнения массива
{
    int lenght = collection.Length; // получение длмны массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); // положить в ячейку рандомное число от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)
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
    int position = -1; //специально присваивается -1 для того чтобы туда перешло не существующее значение массива при вводе, например введе 444, которого не будет в массиве

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //найдет первое значение, а не последнее
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; // создание массива равного 10 элементам, по умолчанию заполнен нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 444); // сюда можно прописать значение 444 для поиска несуществующего значения, которое должно будет перейти в -1 
Console.WriteLine(pos);