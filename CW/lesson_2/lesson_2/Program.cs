namespace Less3_array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint size = 5;
            int[] arr = { 5, 3, 4, 5, 6 };
            int[] arr2 = new int[size];

            //int n = 12;
            //Console.WriteLine(n.CompareTo(10)); 

            //ASC - за зростанням
            //DESC - за спаданням
            //Array.Sort(arr, (a, b) =>b.CompareTo(a)); 
            //Array.Reverse(arr);
            //Console.WriteLine(Array.IndexOf(arr, 3));
            //Console.WriteLine(Array.LastIndexOf(arr,5));
            //Console.WriteLine(Array.Find(arr, el => el %2==0));
            //int[] result = Array.FindAll(arr, el=>el>3);
            //foreach(int el in result)
            //{
            //    Console.WriteLine(el);
            //}
            //Console.Write("\n\n");
            //foreach(var el in arr)
            //{
            //    Console.Write($"{el} ");
            //}
            //Console.WriteLine(Array.Exists(arr, el => el <20));
            //int[] new_arr = new int[arr2.Length];
            //Array.Copy(arr, new_arr, arr.Length;
            //Array.Clear(arr, 2,2);
            //Array.Clear(arr);
            //foreach (int el in arr)
            //{
            //    Console.WriteLine(el);
            //}
            //Array.ForEach(arr, el => Console.WriteLine(el*2));
            //arr.Sum();
            //arr.Average();
            //arr.Min();
            //arr.Max(); 

         
            Array.Resize(ref arr, 3);
            Array.ForEach(arr, el => Console.WriteLine(el));

            //int[] arr3 = arr; 
        }
    }
}