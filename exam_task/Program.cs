Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

// Проверка длины массива
if(sizeArray <= 0)
{
    Console.WriteLine("массив нулевой длины, попробуйте еще раз.");
    return;
}

// Создаем массивы
string[] array = new string[sizeArray];
string[] newArray = new string[array.Length];

// Собираем массив с клавиатуры
void FillArray(string[] arr)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Элемент {i + 1} = ", i);
        arr[i] = (Console.ReadLine()!);
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

// Создание нового массива с выполнением условия
void CreateNewArray(string[] arr1, string[] arr2)
{
    int index = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[index] = arr1[i];
            index++;
        }
    }
}

FillArray(array);
Console.Write("Ваш массив -> ");
PrintArray(array);
Console.WriteLine();
CreateNewArray(array, newArray);
Console.Write("массив с элементами <3 элементов -> ");
PrintArray(newArray);