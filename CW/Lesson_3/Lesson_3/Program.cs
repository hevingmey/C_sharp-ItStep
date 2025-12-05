namespace Less3_array_string
{
    internal class Program
    {
        static void Print2DArray(int[,] arr2D)
        {
            for (uint i = 0; i < arr2D.GetLength(0); i++)
            {
                for (uint j = 0; j < arr2D.GetLength(1); j++)
                {
                    Console.Write($"{arr2D[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            // uint size = 5;
            // int[] arr = { 5, 3, 4, 5, 6 };
            // int[] arr2 = new int[size];

            //int n = 12;
            //Console.WriteLine(n.CompareTo(10)); 

            // -------------------- СОРТУВАННЯ ---------------------

          //  Array.Sort(arr);                        
// Сортує масив за зростанням (ASC — від меншого до більшого)

          //  Array.Sort(arr, (a, b) => b.CompareTo(a));  
// Сортує масив за спаданням (DESC — від більшого до меншого)

          //  Array.Reverse(arr);                       
// Розвертає масив (останній → перший)


// -------------------- ПОШУК --------------------------

          //  Array.IndexOf(arr, 3);                    
// Повертає індекс першого входження числа 3 (або -1)

          //  Array.LastIndexOf(arr, 5);                
// Повертає індекс останнього входження числа 5

           // Array.Find(arr, el => el % 2 == 0);       
// Знаходить перший елемент, що відповідає умові (тут: перший парний)

           // Array.FindAll(arr, el => el > 3);         
// Повертає всі елементи, що > 3 (новий масив)

           // Array.Exists(arr, el => el < 20);         
// Повертає true, якщо є хоч один елемент, що < 20


// -------------------- КОПІЮВАННЯ ----------------------

           // int[] new_arr = new int[arr.Length];
           // Array.Copy(arr, new_arr, arr.Length);     
// Копіює весь масив arr у new_arr


// -------------------- ОЧИЩЕННЯ ------------------------

           // Array.Clear(arr, 2, 2);                   
// Очищає (ставить 0) 2 елементи, починаючи з індекса 2

           // Array.Clear(arr, 0, arr.Length);          
// Очищає весь масив (всі елементи стають 0)


// -------------------- ОБРОБКА ЕЛЕМЕНТІВ ----------------

           // Array.ForEach(arr, el => Console.WriteLine(el * 2));
// Виконує дію для кожного елемента (тут: множення на 2)


// -------------------- СТАТИСТИКА МАСИВА (LINQ) --------

            // arr.Sum();                                
// Сума елементів масиву

            // arr.Average();                            
// Середнє значення (double)

            // arr.Min();                                
// Мінімальний елемент

            // arr.Max();                                
// Максимальний елемент


         
            // Array.Resize(ref arr, 3);
            // Array.ForEach(arr, el => Console.WriteLine(el));

            //int[] arr3 = arr; 
            
            
            // int[] arr = {3, 2, 5, 9,8};
            // Console.WriteLine("enter number");
            // int x =Convert.ToInt32(Console.ReadLine());
            // int n = Array.IndexOf(arr, x);
            // if (n != -1)
            // {
            //     int finder = Array.IndexOf(arr, x);
            //     Console.WriteLine("index: " + finder);
            // }
            // else
            // {
            //     Console.WriteLine("index not found");
            // }
            //
            // double[] arr = { 4.0, 6.0, 8.0, 7.0, 2.0, 1.0 };
            //
            //
            // double sum=arr.Sum();
            // double max=arr.Max();
            // double min=arr.Min();
            // double avarage=arr.Average();
            // Console.WriteLine(sum);
            // Console.WriteLine(max);
            // Console.WriteLine(min);
            // Console.WriteLine(Math.Round(avarage,2));
            //
            
            // двовимірний масив 
            
            int[,] arr2D = new int[3, 4];
            Random rand = new Random();
            for(uint i = 0;i<arr2D.GetLength(0);i++)
            {
                for(uint j = 0;j<arr2D.GetLength(1);j++)
                {
                    arr2D[i, j] = rand.Next(-10, 10);
                    Console.Write($"{arr2D[i,j]} ");
                }
                Console.WriteLine();
            }
            int[] arr = arr2D.Cast<int>().ToArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            int k = 0;
            for (uint i = 0; i < arr2D.GetLength(0); i++)
            {
                for (uint j = 0; j < arr2D.GetLength(1); j++)
                {
                    arr2D[i, j] = arr[k++];
                    Console.Write($"{arr2D[i, j]} ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            
            
            //Рядки
            String str1 = new String("Hello");
            String str2 = new String('*', 5);
            string str3 = "Hello"; //рядки immutable
            string str4 = "Hello ";
            str4 += "World";

            Console.WriteLine(str4.Length);


            }
        }
    }
