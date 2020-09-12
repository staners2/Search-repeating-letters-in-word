using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchWords
{
    class Program
    {
        #region Version1.0 // Выводит 1 слово
        /*static void Main(string[] args)
        {
            
            Console.WriteLine("Введите предложение: ");
            string sInputUser = Console.ReadLine();

            char[] chDelimiter = { ',', '.', '?', '!', '+', '-', ' '};
            string[] WordsList = sInputUser.Split(chDelimiter, StringSplitOptions.RemoveEmptyEntries);

            int iWordsLength = WordsList.Length;
            int iMaxCount = 0;
            string sWordMaxRepeatingLetters = "";

            for (int i = 0; i < iWordsLength; i++)
            {   
                foreach (char ch in WordsList[i])
                {
                    int Count = 0;
                    for (int j = 0; j < WordsList[i].Length; j++)
                    {
                        if (ch == WordsList[i][j])
                        {
                            Count++;
                        }
                    }
                    if (iMaxCount <= Count-1)
                    {
                        iMaxCount = Count-1;
                        sWordMaxRepeatingLetters = WordsList[i];
                    }
                }
            }

            Console.WriteLine(sWordMaxRepeatingLetters);

            Console.ReadKey();

        }*/

        #endregion

        #region Version2.0 // Выводит 1 слово / С использованием методов
        /*        static void Main(string[] args)
                {
                    List<string> ListWords = new List<string> { };

                    Console.WriteLine("Введите предложение: ");
                    string sInputUser = Console.ReadLine();
                    h_ParserWords(sInputUser, ListWords);
                    string Word = h_SearchWordsWidthMaxLetters(ListWords);
                    if (Word == "")
                    {
                        Word = "Такого слова нет";
                    }
                    Console.WriteLine($"Слово(a) с максимальным повторением букв = {Word}");

                    Console.ReadKey();
                }
                private static List<string> h_ParserWords(string sInputUser, List<string> Words)
                {
                    string sWord = "";
                    for (int i = 0; i < sInputUser.Length; i++)
                    {
                        if (h_IsDelimiter(sInputUser[i]))
                        {
                            Words.Add(sWord);
                            sWord = "";
                            //Console.WriteLine($"Добавленное слово: {sWord}");
                        } 
                        else
                        {
                            sWord = sWord + $"{sInputUser[i]}";
                        }
                        if (i == sInputUser.Length-1)
                        {
                            Words.Add(sWord);
                            //Console.WriteLine($"Предел / Добавленное слово: {sWord}");
                        }

                    }
                 return (Words); 
                }

                private static Boolean h_IsDelimiter(char ch)
                {
                    if (!Char.IsLetter(ch))
                    {
                        return true;
                    }
                    else
                        return false;
                }

                private static string h_SearchWordsWidthMaxLetters(List<string> Words)
                {
                    int iWordsLength = Words.Count;
                    //Console.WriteLine($"Кол-во слов: {iWordsLength}");
                    string WordWidthMaxRepeatingLetters = "";
                    int iMaxCount = 0;
                    //Console.WriteLine($"Все слова: {Words}");

                    for (int i = 0; i < iWordsLength; i++) // Перебор слов
                    {
                        int Count = 0;
                        //Console.WriteLine($"Слово = {Words[i]}");
                        for (int j = 0; j < Words[i].Length; j++) // Перебор букв в слове
                        {
                            for(int k = 0; k < Words[i].Length; k++)
                            {
                                if ((Words[i][j] == Words[i][k]) && (k != j))
                                {
                                    Count++;
                                   // Console.WriteLine($"Буквы: {Words[i][j]} = {Words[i][k]} // COUNT = {Count}");
                                }
                            }
                        }
                        if (iMaxCount <= Count)
                        {
                            iMaxCount = Count;
                            WordWidthMaxRepeatingLetters = Words[i];
                        }
                    }
                    return (WordWidthMaxRepeatingLetters);
                }
        */
        #endregion

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
