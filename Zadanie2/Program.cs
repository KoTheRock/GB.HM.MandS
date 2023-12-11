// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


public class Program
{
    static void Main()
    {
        string symbols = new string(new char[] { 'a', 'b', 'C', 'd', 'F', 'G', 'h', 'i', 'j', 'K', 'l', 'M', 'n', 'O', 'p', 'Q', 'R', 's', 'T' });

        string lowerCase = symbols.ToLower();
  
        Console.WriteLine("Строка из массива символов: " + symbols);
        Console.WriteLine("Строка из массива строчных символов : " + lowerCase);
        
    }
}