// Задача 43 Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
float k_1 = GetNumberFromUser("Введите угловой коэффициент k первой прямой: ", "Ошибка ввода");
float b_1 = GetNumberFromUser("Введите cмещение b первой прямой: ", "Ошибка ввода");
float k_2 = GetNumberFromUser("Введите угловой коэффициент k второй прямой: ", "Ошибка ввода");
float b_2 = GetNumberFromUser("Введите смещение b второй прямой: ", "Ошибка ввода");
Console.Write($"k1 = {k_1}, b1 = {b_1}, k2 = {k_2}, b2 = {b_2} -> ");
if (k_1 == k_2)
{
    if (b_1 == b_2)
        Console.WriteLine("Прямые совпадают");
    else
        Console.WriteLine("Прямые параллельны, точки пересечения нет");
}
else
{
    float[] my_intersection = FoundIntersection(k_1, b_1, k_2, b_2);
    Console.Write($"({String.Join("; ", my_intersection)})");
}

float GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = float.TryParse(Console.ReadLine(), out float userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

float[] FoundIntersection(float k1, float b1, float k2, float b2)
{
    float[] x_y = new float[2];
    x_y[0] = (b2 - b1) / (k1 - k2);
    x_y[1] = k1 * x_y[0] + b1;
    return x_y;
}