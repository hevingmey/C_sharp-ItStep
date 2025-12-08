using System.Drawing;
using System.Net.ServerSentEvents;

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
            // static bool Palindrome()
            // {
            //     Console.WriteLine("enter palindrome");
            //     int w = Convert.ToInt32(Console.ReadLine());
            //     int w1 = w;
            //     int rev = 0;
            //
            //     while (w > 0)
            //     {
            //         int t = w % 10;
            //         rev = (rev * 10) + t;
            //         w /= 10;
            //
            //     }
            //
            //     if (rev == w1)
            //     {
            //         Console.WriteLine("it is a palindrome");
            //         return true;
            //     }
            //     else
            //     {
            //         Console.WriteLine("it is not a palindrome");
            //         return false;
            //     }

                // third task
                static void Filtermas(int[] arr1, int[] arr2)
                {
                    int counter = arr1.Length;
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            if (arr1[i] == arr2[j])

                            {
                                counter--;
                                break;
                            }
                        }

                    }
                    int[] arr=new int[counter];
                    int index=0;
                    for (int w = 0; w < arr1.Length; w++)
                    {
                        bool found = false;
                        for (int r = 0; r < arr2.Length; r++)
                        {
                            if (arr1[w] == arr2[r])
                            {
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            arr[index] = arr1[w];
                          index++;
                        }
                    }





                    Console.WriteLine("RESULT:");
                    for (int k = 0; k < arr.Length; k++)
                    {
                        Console.Write(arr[k]+" ");
                    }

                    //     
                    //     
                    //     for (int i = 0; i < arr1.Length; i++)
                    //     {
                    //         if (arr1[i] != arr2[i])
                    //         {
                    //             arr[index] = arr1[i];
                    //             index++;
                    //         }
                    //
                    //         
                    //     }
                    //
                    //     for (int i = 0; i < arr.Length; i++)
                    //     {
                    //         Console.WriteLine(arr[i]);
                    //     }
                    //     
                    // }



                }

                static void Main(string[] args)
                {
                    // Rectangle();
                    // Palindrome();
                    int[] arrA = { 1,3,5,2,23,12,43};
                    int[] arrB = { 1,7,3,1,5 };
                    Filtermas(arrA, arrB);
                }

            }
