void RandomArray(int elements)
{
    int[] array = new int[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите желаемое количество элементов массива: ");
int elem = Convert.ToInt32(Console.ReadLine());

Console.Write("Сгенерированный массив: ");

RandomArray(elem);