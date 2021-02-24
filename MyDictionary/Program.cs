using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary1 = new Dictionary<int,string>();
            dictionary1.Add(1, "deneme");           

            foreach(var keyValue in dictionary1)
            {
                Console.WriteLine("Key: {0}, Value: {1}", keyValue.Key, keyValue.Value);
            }
            Console.WriteLine("~~~~ My Dictionary~~~~");
            var mydictionary = new MyDictionary<int, string>();
            mydictionary.Add(2, "Deneme2");
            mydictionary.Get();
            

        }
    }
}
