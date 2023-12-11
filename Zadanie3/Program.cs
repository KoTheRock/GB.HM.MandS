// Задайте произвольную строку. Выясните, является ли она палиндромом

public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку :");
        string input = Console.ReadLine();

        bool Palindrome = IsPalindrome(input);
        Console.WriteLine($"Строка \"{input}\" является палиндромом");
    }
    static bool IsPalindrome(string input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}