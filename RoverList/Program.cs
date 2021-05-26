using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            list.Add("Hello");
            list.Add("World");
            list.Add("Sixteen");
            list.Add("Dog");
            list.Add("Bird");
            list.Add("Cat");
            list.Add("Apple");
            list.Add("Orange");
            list.Add("Blue");
            list.Add("Green");
            list.Add("Banana");
            list.Add("Water");
            list.Add("This");
            list.Add("is");
            list.Add("a");
            list.Add("word.");

            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("Enter a word to add to the list. Input done if you have finished.");
                String input = Console.ReadLine();
                if (input != "done")
                {
                    list.Add(input);
                }
                else
                {
                    finished = true;
                }
            }
            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            finished = false;
            while (!finished)
            {
                Console.WriteLine("Enter a word to add to the front of the list. Input done if you have finished.");
                String input = Console.ReadLine();
                if (input != "done")
                {
                    list.Add(input, 0);
                }
                else
                {
                    finished = true;
                }
            }
            // TODO:  Print out the list
            list.ListNodes();
            // TODO:  Remove every word with an odd length
            
            for (int i = 0; i < list.GetCount(); i++)
            {
                if (list.GetNode(i).Data.Length % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
            // TODO:  Print out the list
            list.ListNodes();

            // TODO:  Clear the list
            list.Clear();
            // TODO:  Print out the list
            list.ListNodes();



        }
    }
}
