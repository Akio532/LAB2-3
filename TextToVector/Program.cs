using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text1 = new Text("../../text1.txt");
            Text text2 = new Text("../../text2.txt");
            Console.WriteLine(Text.Cos(text1, text2));
        }
    }
}
