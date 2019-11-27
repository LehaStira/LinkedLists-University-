using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleAlgorithmsApp
{
    class Program
    {
        static string Action(string s)
        {
            char begin = s[s.Length - 4];
            Console.WriteLine(begin);
            s = s.Remove(s.IndexOf(begin), 3);
            return s;
        }
        static bool CheckForLength(string s)
        {
            if (s.Length <= 4)
            {
                return true;
            }
            else
            {
               
                return false;
            }
        }
        static void Main(string[] args)
        {
            string s = "";
            List<String> slova = new List<string>();
            List<String> changeSl = new List<string>(); // новый, измененный список
            using (StreamReader sr = new StreamReader("1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    string[] words = s.Split(' ', '.');
                    foreach (string word in words)                // чтение из файла
                    {
                        // Console.WriteLine(word);
                        slova.Add(word);
                    }
                }
                sr.Close();
            }

            Console.WriteLine("Прочитали из файла:");


            foreach (var item in slova)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

            // выводим элементы
            foreach (var item in slova)
            {
                if (CheckForLength(item) == true)         //////////////////////////////здесь применять функцию    
                {
                    slova.Remove(item);  // удаляем элемент
                }
            }
            
            Console.WriteLine("After deleting:");
            Console.WriteLine();
            foreach (var item in changeSl)
            {
                Console.WriteLine(item);
            }

            foreach (var item in slova)
            {
               changeSl.Add(Action(item));
            }
            Console.WriteLine("After changes:");
            Console.WriteLine();
            foreach (var item in changeSl)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
}