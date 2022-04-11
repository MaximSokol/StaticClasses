using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    
    class Book
    {
       public class Notes
        {
            string text = " ";

            public string Text
            {
                get
                {
                    return text;
                }
                set
                {
                    if(value != " ")
                    {
                        text = "Kiss my ass Russian pig!\n";
                    }
                    this.text += value;
                }
            }
        }

        public void FindNext(string str)
        {
            Console.WriteLine($"The string which was found:\t{str}");
        }
    }

    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book book = new Book();
            book.FindNext(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book.Notes note = new Book.Notes();
            note.Text = "Hello from Ukraines' solders!";
            note.Text = " ";

            Console.WriteLine(note.Text);
            Console.WriteLine();

            int[] arr = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            arr.SortUp();

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
