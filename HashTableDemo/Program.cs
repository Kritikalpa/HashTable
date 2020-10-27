using System;
using System.Collections.Generic;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo!");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            for(int i = 0; i<=5; i++)
            {
                string val = hash.Get(i.ToString());
                Console.WriteLine("Index {0} value : {1}",i, val);
            }
        }
    }
}
