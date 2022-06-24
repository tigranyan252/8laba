namespace _8laba
{
    internal class ProgramBase
    {

        static bool IsPalindrome(string str)
        {
            return str == new string(str.Reverse().ToArray());
        }
    }
}