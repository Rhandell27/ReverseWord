using System;

namespace ReverseWord
{
    class Word
    {
        string newWord = "";
        public string ReverseWord(string words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                var n = words.Length - 1;
                var temp = n - i;
                newWord += words[temp];
                
            }
            return newWord;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var word = new Word();
            Console.WriteLine("Type a word: ");
            var newWord = Console.ReadLine();
            Console.WriteLine("Your new Reverse Word: \"{0}\"", word.ReverseWord(newWord));
            Console.Read();

        }
    }
}
