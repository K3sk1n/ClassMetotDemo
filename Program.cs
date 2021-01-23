using System;

namespace MyDictionaryList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<int, string> myDictionary = new MyDictionaryList<int, string>();
            myDictionary.Add(1, "Taha");
            myDictionary.Add(2, "Engin");
            myDictionary.Add(3, "Ahmet");


            myDictionary.GetAll();
        }
    }
}
