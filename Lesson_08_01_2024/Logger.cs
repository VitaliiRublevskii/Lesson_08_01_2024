using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lesson_08_01_2024
{
    
    public class Logger : IDisposable
    {
        public Logger() {}

        string path;
        public void Start (string path) 
        {
             this.path = path;
            
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Created Logger  " + DateTime.Now.ToLongTimeString());
                File.AppendAllText(path, DateTime.Now.ToLongTimeString() + "\n");
                Thread.Sleep(1000);
            }
            
        
        }

        public void Dispose()
        {
            Console.WriteLine(  "File & Loggers  delete");
            File.Delete(path);
            GC.Collect();

        }

    }
}
