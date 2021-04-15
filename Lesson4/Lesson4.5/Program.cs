using System;

namespace Lesson4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = " Предложение один    Теперь предложение два    Предложение три";
            Console.WriteLine(Sentence(str1));
            Console.ReadLine();
        }

        static string Sentence(string sentence)
        {
            string str1 = string.Empty;
            for (int i = 0; i < sentence.Length; i++)
            {
                string tempSentence = string.Empty;
                if (sentence[i] != ' ' && sentence[i].ToString() == sentence[i].ToString().ToUpper())
                {
                    tempSentence += sentence[i];
                    i++;
                    while (i < sentence.Length && (sentence[i] == ' ' || sentence[i].ToString() != sentence[i].ToString().ToUpper()))
                    {
                        tempSentence += sentence[i];
                        i++;
                    }
                    i--;
                    str1 += tempSentence.TrimEnd() + ". ";
                }
            }
            return str1;
        }
    }
}
