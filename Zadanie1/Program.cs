// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

public class Program
{
    static void Main()
    {
        char[,] charArray = {
        
        {'3', 'h', 'm', '2', ')'},
        {'=', 'g', '2', '/', '4',}
        };

        string result = string.Empty;

        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result += charArray[i, j];
            }
        }
        Console.WriteLine("Строка из массива символов: " + result);
    }
}