// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3.
void StringArrayThree(string[] array)
{
    string[] newarray = new string[array.Length];
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[i] = array[i];
            Console.Write($" {newarray[i]} ");
        }
    }
    Console.WriteLine("]");
}

void PrintArr(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    Console.WriteLine();
}

Console.WriteLine("Введите строку: ");
string s = Convert.ToString(Console.ReadLine() ?? "");
char[] separators = new char[] { ' ', ',', '.' };
string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("Введенный массив строк: ");
PrintArr(subs);
Console.WriteLine("Массив строк, длина которых меньше или равна 3: ");
StringArrayThree(subs);
Console.ReadKey();