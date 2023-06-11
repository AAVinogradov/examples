// заполнения массива случайными числами и вывод 

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
int[] array = new int[10]; // создание массива равного 10 элементам, по умолчанию заполнен нулями

FillArray(array);
PrintArray(array);
