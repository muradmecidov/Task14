using ConsoleApp11.Models;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CList<string> list = new CList<string>();
            list.Add("MURAD");
            list.Add("ALI");
            list.Add("ELSAD");
            list.Add("ORXAN");
            list.Add("ILIKIN");


            list.Remove("ILIKIN");
            Console.WriteLine(list.Count());
            Console.WriteLine(list.Contains("ALI"));
           
            //list.Remove("ILIKIN");
            //list.Clear();

        }
    }
}