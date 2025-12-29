using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1;
delegate bool Char1(char c);
delegate  int Char2();

class Sentens
{
    private string sentence;

    public Sentens(string sentence)
    {
        this.sentence = sentence;
    }
    public string Filter(Char1 ch)
         {
             List<char> result = new List<char>();
             foreach (char n in sentence)
             if (ch(n))
                 result.Add(n);
             return new string(result.ToArray());
         }

    public bool IsVowels(char c)
    {
        
      
             c = char.ToLower(c);

             return c == 'a' ||
                    c == 'e' ||
                    c == 'i' ||
                    c == 'o' ||
                    c == 'u' ||
                    c == 'y';
        
    }

    public bool IsConsonants(char c)
    {
       
        
            c = char.ToLower(c);
            return c == 'q' || c == 'x' || c == 'z' || c == 'w' || c == 'r' || c == 's' || c == 't' || c == 'n' ||
                   c == 'p' || c == 'd' || c == 'b' || c == 'm';
           
    }

    public int CountVowels()
    {
        string vowels = Filter(IsVowels);
        return vowels.Length;
    }

    public int CountConsonants()
    {
        string consonants = Filter(IsConsonants);
        return consonants.Length;
    }
    public int Length()
    {
        return sentence.Length;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter sentence");
        string text = Console.ReadLine();
        Sentens s = new Sentens(text);

        Char2 delVower = s.CountVowels;
        Char2 delCons = s.CountConsonants;
        Char2 delLenght = s.Length;
        Console.WriteLine("кількість голосних "+delVower());
        Console.WriteLine("кількість приголосних "+delCons());
        Console.WriteLine("довжина рядка "+delLenght());
    }
    
}




// delegate bool Number(int n);
// class MyArray
// {
//         private int[] array;
//         private Random random=new Random();
//         public MyArray(int size)
//         {
//             array = new int[size];
//         }
//
//         public void FullArray()
//         {
//             for (int i = 0; i < array.Length; i++)
//             {
//                 array[i] = random.Next(1,104);
//             }
//         }
//
//         public int[] Filter(Number num)
//         {
//             List<int> result = new List<int>();
//             foreach (int n in array)
//             if (num(n))
//                 result.Add(n);
//             return result.ToArray();
//         }
//         public bool IsEven(int n)=>n%2==0;
//         public bool IsOdd(int n)=>n%2!=0;
//         public bool IsPrime(int n)
//         {
//             if (n <= 2) return false;
//             for (int i = 2; i * i <= n; i++)
//             
//                 if (n % i == 0)
//                     return false;
//                 return true;
//             
//         }
//
//         public bool IsFibonacci(int n)
//         {
//             if (n < 0) return false;
//
//             bool IsSquare(int x)
//             {
//                 int w=(int) Math.Sqrt(x);
//                 return w*w==x;
//             }
//             return IsSquare(5*n*n+4) || IsSquare(5* n*n-4);
//         }
//
//        public void Print(string text, int[] array)
//         {
//             Console.WriteLine(text+" ");
//             foreach (var x in array)
//                 Console.WriteLine(x+" ");
//             Console.WriteLine();
//         }
//         
// }
// class Program
// {
//     static void Main(string[] args)
//     {
        // Console.WriteLine("Hello, World!");
        // MyArray myArray = new MyArray(20);
        // myArray.FullArray();
        // var even = myArray.Filter(myArray.IsEven);
        // var odd = myArray.Filter(myArray.IsOdd);
        // var prime = myArray.Filter(myArray.IsPrime);
        // var fibonacci = myArray.Filter(myArray.IsFibonacci);
        //
        // myArray.Print("парні", even);
        // myArray.Print("не парні", odd);
        // myArray.Print("прості", prime);
        // myArray.Print("фібоначі",fibonacci);
        
//     }
// }