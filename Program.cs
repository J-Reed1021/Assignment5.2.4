namespace Assignment5._2._4
{
    internal class Program
    {
        static bool IsPalindrome(string text)
        {
            // If the string is empty or has one character, it's a palindrome
            if (text.Length <= 1)
                return true;

            // Check if the first and last characters are the same
            if (text[0] != text[text.Length - 1])
                return false;

            // Recursively call IsPalindrome with the middle substring
            return IsPalindrome(text.Substring(1, text.Length - 2));
        }

        static void Main()
        {
            Console.Write("Please enter a word to check if it is a palindrome: ");
            string inputString = Console.ReadLine();

            bool result = IsPalindrome(inputString);

            if (result)
                Console.WriteLine("The word is Palindrome.");
            else
                Console.WriteLine("The word is not Palindrome.");
        }
    }
}