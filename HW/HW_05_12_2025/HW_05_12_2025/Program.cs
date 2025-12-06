using System.Drawing;

namespace HW_05_12_2025;

class Program
{
    static void Rectangle()
    {
         // task first 
                
                Console.WriteLine("enter length");
                int x=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter char");
                char y=Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < x; i++)
                {
                    for (int j=0; j<x; j++)
                        {
                        Console.Write(y+" ");
                        }
                    Console.WriteLine();
                }
    }
            // second task
            static bool Palindrome()
    {
        Console.WriteLine("enter palindrome");
        int w= Convert.ToInt32(Console.ReadLine());
        int w1 = w;
        int rev = 0;
        
        while (w>0)
        {
            int t = w % 10;
            rev = (rev * 10) + t;
            w /= 10;
            
        }
        if (rev == w1)
        {
            Console.WriteLine("it is a palindrome");
            return true;
        }
        else  {
            Console.WriteLine("it is not a palindrome");
            return false;
        }
                // third task
                static void Filtermas(int[] arr1,int[] arr2)
                {
                    int counter = 0;
                    for (int i=0; i<arr1.Length; i++)
                        {
                            if (arr1[i] != arr2[i])
                            {
                                counter++;
                            }
                        }
                    
                    int[] arr=new int[counter];
                    int index=0;
                    
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i] != arr2[i])
                        {
                            arr[index] = arr1[i];
                            index++;
                        }

                        
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }
                    
                }

        
    }

    static void Main(string[] args)
    {
        // Rectangle();
        // Palindrome();
        int[] arrA = { 1, 2, 6, -1, 88, 7, 6 };
        int[] arrB = { 6, 88, 7 };
        Filtermas(arrA, arrB);
    }

    }
