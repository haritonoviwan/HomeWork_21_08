// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int m = GetNumberFromUser("Введите количество чисел М: ", "Ошибка ввода");
int[] m_array = GetArrayFromUser(m);
int positive_numbers = QuantityOfPositiveNumbers(m_array);
Console.Write(String.Join(" ", m_array));
Console.Write($" -> {positive_numbers}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArrayFromUser(int size)
{
    int[] array = new int[size];
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"Введите {index + 1} число: ");
        array[index] = int.Parse(Console.ReadLine());
    }
    return array;
}

int QuantityOfPositiveNumbers(int[] array)
{
    int quantity = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0)
        {
            quantity++;
        }
    }
    return quantity;
}