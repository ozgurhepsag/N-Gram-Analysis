using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NGram_Analysis
{
    class FileOperations
    {
        //private static string SOURCE_DIR = "C:/Users/ozgur/source/repos/ConsoleApp1/Novel-Samples";
        private string SOURCE_DIR;
        int Unigram = 1;
        int Bigram = 2;
        int Trigram = 3;

        private NGramDictionary unigram;
        private NGramDictionary bigram;
        private NGramDictionary trigram;

        public FileOperations(string path)
        {
            SOURCE_DIR = path;

            unigram = new NGramDictionary(new NGramExtractor(Unigram));
            bigram = new NGramDictionary(new NGramExtractor(Bigram));
            trigram = new NGramDictionary(new NGramExtractor(Trigram));
            FillDictionaries();
        }

        private void FillDictionaries()
        {
            ReadFiles(unigram);
            ReadFiles(bigram);
            ReadFiles(trigram);
        }

        private void ReadFiles(NGramDictionary dict)
        {
            var txtFiles = Directory.EnumerateFiles(SOURCE_DIR, "*.txt");
            foreach (var item in txtFiles)
            {
                string fileContext = File.ReadAllText(item, Encoding.GetEncoding("ISO-8859-9"));
                fileContext = CleanText(fileContext);
                fileContext = fileContext.ToLower(new CultureInfo("tr-TR", false));
                dict.AddSequence(fileContext.Split(null).ToList());
            }
        }

        public List<KeyValuePair<NGram, int>> SortNGram(NGramDictionary dict)
        {
            List<KeyValuePair<NGram, int>> sortedList = dict.ToList();
            sortedList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            return sortedList;
        }

        private string CleanText(string text)
        {
            text = Regex.Replace(text, "[\"',.*^%#=+;:/?!()\\-]+", ""); // first replace delimiters
            text = Regex.Replace(text, "\\s+", " "); // then replace empty spaces
            return text;
        }

        public NGramDictionary GetUnigram()
        {
            return unigram;
        }

        public NGramDictionary GetBigram()
        {
            return bigram;
        }

        public NGramDictionary GetTrigram()
        {
            return trigram;
        }

    }
}
