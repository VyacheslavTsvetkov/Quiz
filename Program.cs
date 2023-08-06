// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется 
//  пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int Start(string message)
{
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool ValidateNumber(int value)
{
    if (value <= 0)
    {
        Console.WriteLine("Количество элементов массива не может быть отрицательным, либо равно нулю." +
        "\n Попробуйте заново. ");
        return false;
    }
    return true;
}

string[] FillArray(string[] array)
{
    int count = array.Length;
    int i = 0;
    while (count != 0)
    {
        Console.Write($"введите {i + 1}-й элемент массива   ");
        array[i] = Console.ReadLine();
        i++;
        count--;
    }
    return array;
}

int N = Start("Введите число элементов массива");
Console.WriteLine();
string[] stringArray = new string[N];

if (ValidateNumber(N))
{
  FillArray(stringArray);
}
 