
using System;
using System.IO;
using System.Text.Json;

namespace Hw_16_01_26


    
    {
        class Magazine
        {
            public string Title { get; set; }
            public string Publisher { get; set; }
            public string ReleaseDate { get; set; }
            public int Pages { get; set; }
        }

        class Program
        {
            static void Main()
            {
                string path = "magazine.json";

                Magazine mag = new Magazine();

                Console.Write("назва журналу: ");
                mag.Title = Console.ReadLine();

                Console.Write("назва видавництва: ");
                mag.Publisher = Console.ReadLine();

                Console.Write("дата випуску: ");
                mag.ReleaseDate = Console.ReadLine();

                Console.Write("кількість сторінок: ");
                mag.Pages = int.Parse(Console.ReadLine());

                Console.WriteLine("\n інформація про журнал");
                Console.WriteLine("назва: " + mag.Title);
                Console.WriteLine("видавництво: " + mag.Publisher);
                Console.WriteLine("дата випуску: " + mag.ReleaseDate);
                Console.WriteLine("сторінок: " + mag.Pages);

                string json = JsonSerializer.Serialize(mag);

                File.WriteAllText(path, json);
                Console.WriteLine("\nзбережено у файл: " + path);

                string jsonFromFile = File.ReadAllText(path);

                Magazine mag2 = JsonSerializer.Deserialize<Magazine>(jsonFromFile);

                Console.WriteLine("\n журнал після завантаження з файлу");
                Console.WriteLine("назва: " + mag2.Title);
                Console.WriteLine("видавництво: " + mag2.Publisher);
                Console.WriteLine("дата випуску: " + mag2.ReleaseDate);
                Console.WriteLine("сторінок: " + mag2.Pages);
            }
        }
    }
