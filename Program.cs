using System;
using System.IO;
using System.Linq;

namespace node_telegram_wallpaper_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputlocation = @"/home/ghalib/images.js";
            string list = @"/home/ghalib/file.txt";
            string text;
            StreamReader fs = new StreamReader(list);
           
            while ((text = fs.ReadLine()) != null)
            {
                Console.WriteLine(text);
                File.AppendAllText(outputlocation, "file: '" + text + "',\n");

                File.AppendAllText(outputlocation, "description: '"+text.Substring(0, (text.Length-4))+"' \n");
                File.AppendAllText(outputlocation, "},\n{\n");
            }
            }
        }
       
}
