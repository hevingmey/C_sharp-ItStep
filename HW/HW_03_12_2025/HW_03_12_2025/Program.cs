using System.Diagnostics.Tracing;

namespace HW_03_12_2025;

class Program
{
    static void Main(string[] args)
    {
        //task forth
        int counter = 0;
        int[] arr;
        int[] numbers = { 1,  5, 88, 7, 81, 9 };
        int[] numbers2 = {  5, 6, 7, 8, 9 };
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; i + 1 < numbers2.Length; j++)

            {
                if (numbers[i] == numbers2[j])
                {
                    counter++;
                }
            }
                    
        }

        int[] result = new int[counter];

        for (int i = 0; i < counter; i++)
        {
            result[i] = numbers2[i];
        }

        // task six

        // Console.WriteLine("enter text");
        // string text= Console.ReadLine();
        // Console.WriteLine(text);
        // string[] words = text.Split(' ');
        // int counter=words.Length;
        // Console.WriteLine("words count: " + counter);

        // seventh task

        // Console.WriteLine("enter text");
        //  string text= Console.ReadLine();
        //  string rev= new string(text.Reverse().ToArray());
        //  Console.WriteLine(rev);

        // eighth task

        // Console.WriteLine("enter world");
        // string sentence = Console.ReadLine();
        // int couunter = 0;
        // for (int i=0;i<sentence.Length;i++)
        //     {
        //         if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' ||
        //             sentence[i] == 'u' || sentence[i] == 'y')
        //         {
        //             couunter++;
        //         }
        //     }
        // Console.WriteLine(couunter);

        // ninth task

        // Console.WriteLine("enter sentens");
        // string sentens = Console.ReadLine();
        //  string[] words = sentens.Split(' ');
        //  for (int i = 0; i < words.Length; i++)
        //  {
        //      for (int j = i+1; j < words.Length; j++)
        //      {
        //          if (words[i].Equals(words[j]))
        //          {
        //              Console.WriteLine(words[i]+"="+words[j]);
        //          }
        //      }
        //      






    }
}