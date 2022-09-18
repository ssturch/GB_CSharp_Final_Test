Console.Write("Введите количество строк: ");
int qtyString = int.Parse(Console.ReadLine());
Console.WriteLine("Введите строки для анализа:");
string [] inputArray = InputStringArray(qtyString);
Console.Write("Получен массив строк: ");
ShowStringArray(inputArray);
Console.Write("Преобразованный массив строк: ");
ShowStringArray(StrArrProcByStrLength(inputArray, 3)); // цифра 3 в функции StrArrProcByStrLength не является магическим числом, оно соответсвует условию задачи

// Данная функция выводит строковый массив в консоль
void ShowStringArray (string [] array)
{
    Console.WriteLine($"[{String.Join(", ",array)}]");    
}

// Данная функция создает массив из строк введенных пользователем
string [] InputStringArray (int length)
{
    string [] result= new string [length];
    for (int i = 0; i < length; i ++)
    {
        string inputString = Console.ReadLine();
        result[i] = inputString;
    }
    return result;
}

// Данная функция создает новый массив из введенного массива согласно заданным условиям.
// Условие - создание массива из строк, чья длина меньше или равна определенному значению.
string [] StrArrProcByStrLength (string [] inputArray, int maxStringLength)
{
    string [] resultArray = new string [0];
    int countString = 0;
    for (int i = 0; i < inputArray.Length; i ++)
    {
        if (inputArray[i].Length <= maxStringLength)
        {
            countString ++;
            Array.Resize(ref resultArray, countString);
            resultArray [countString - 1] = inputArray[i];
        }
    }
    return resultArray;
}

