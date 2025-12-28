using System.ComponentModel.Design;

namespace Lesson_10;

// public static class String
// {
//     public static int GetVowels(this string str)
//     {
//         if (string.IsNullOrEmpty(str))
//             return 0;
//
//         int count = 0;
//
//         for (int i = 0; i < str.Length; i++)
//         {
//             char c = char.ToLower(str[i]);
//
//             if (c == 'a' ||
//                 c == 'e' ||
//                 c == 'i' ||
//                 c == 'o' ||
//                 c == 'u' ||
//                 c == 'y')
//             {
//                 count++;
//             }
//         }
//
//         return count;
//     }
//
//     public static bool IsPalindrome(this string str)
//     {
//         if (string.IsNullOrEmpty(str))
//             return false;
//
//         str = str.ToLower();
//
//         int left = 0;
//         int right = str.Length - 1;
//
//         while (left < right)
//         {
//             if (str[left] != str[right])
//                 return false;
//
//             left++;
//             right--;
//         }
//
//         return true;
//     }
// }
public record class Student(string surname, string Name, int Age, int averageMark)
{
    public void GetFullName()
    {
        Console.WriteLine($"{Name} is {surname}");
    }

    public bool IsExcellent()
    {
        if (averageMark >= 10)
        {
            Console.WriteLine("Excellent");
            return true;
        }
        else
        return false;


    }
}

class Program
{
    static void Main(string[] args)
    {
        // string s1="hello";
        // Console.WriteLine(s1.GetVowels());
        // Console.WriteLine(s1.IsPalindrome());
        //

       

        

    }
}