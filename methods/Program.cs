void FillArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-25, 26);
    }
}

void PrintArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i == 0) Console.Write($"[{mass[i]}, ");
        else if (i == mass.Length - 1) Console.WriteLine($"{mass[i]}]");
        else Console.Write($"{mass[i]}, ");
    }
}

int FindSum1(int[] mass)
{
    int i = 0;
    int sum = 0;
    while (i < mass.Length)
    {
        if (i % 2 != 0)
        {
            sum = sum + mass[i];
        }
        i++;
    }
    return sum;
}

void FindEvenNumbers(int[] mass)
{
    int count = 0;
    int i = 0;
    while (i < mass.Length)
    {
        if (mass[i] % 2 == 0) count++;
        i++;
    }
    Console.WriteLine($"Четных чисел в массиве: {count}");
}

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

int FindSum(int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + n % 10;
        n /= 10;
    }
    return res;
}

void UserFillArr(int size)
{
    int[] arr = new int[size];
    int ind = 0;
    while (ind < size)
    {
        arr[ind] = Convert.ToInt32(Console.ReadLine());
        ind++;
    }
    for (int i = 0; i < size; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length - 1) Console.WriteLine($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temprary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprary;
    }
}