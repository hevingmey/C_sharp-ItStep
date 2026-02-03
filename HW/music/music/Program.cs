using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace D_D_project
{
    class Program
    {
        static volatile bool _loop;
        static Process? _p;

        static void Main()
        {
            string file = Path.Combine(AppContext.BaseDirectory, "medieval-horizons-squire-470880 (online-audio-converter.com).wav");
            PlayLoop(file);

            Console.WriteLine("Playing... Enter = stop");
            Console.ReadLine();

            Stop();
        }

        static void PlayLoop(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("No file: " + path);
                return;
            }

            _loop = true;

            ThreadPool.QueueUserWorkItem(_ =>
            {
                while (_loop)
                {
                    _p = Process.Start(new ProcessStartInfo("afplay", $"\"{path}\"")
                    {
                        UseShellExecute = false,
                        CreateNoWindow = true
                    });

                    _p?.WaitForExit();
                }
            });
        }

        static void Stop()
        {
            _loop = false;
            try { if (_p is { HasExited: false }) _p.Kill(); } catch { }
        }
    }
}