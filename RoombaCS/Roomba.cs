using System;
using System.IO;
using System.Text;

namespace RoombaCS
{
    public class Roomba 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
      
            string read = File.ReadAllText(@"Input.txt", Encoding.UTF8);
            Console.WriteLine(read);

        }
    }
}
