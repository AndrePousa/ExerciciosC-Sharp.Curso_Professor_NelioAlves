using System;
using System.IO;

namespace Bloco_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Arquivo não encontrado " + e.Message);
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
