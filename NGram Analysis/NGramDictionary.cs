using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGram_Analysis
{

    public class NGramDictionary
    {
        private readonly NGramExtractor extractor;

        private readonly IDictionary<NGram, int> nGrams;

        public NGramDictionary(NGramExtractor extractor)
        {
            this.extractor = extractor;
            nGrams = new Dictionary<NGram, int>();
        }

        public void AddSequence(IEnumerable<string> tokens)
        {
            IDictionary<NGram, int> newNGrams = extractor.ExtractAsDictionary(tokens);
            nGrams.Merge(newNGrams);
        }

        public List<KeyValuePair<NGram, int>> ToList()
        {
            return nGrams.ToList();
        }
    }

    internal static class Extensions
    {
        public static void Merge(this IDictionary<NGram, int> first, IEnumerable<KeyValuePair<NGram, int>> second)
        {
            foreach (var nGram in second)
            {
                if (first.ContainsKey(nGram.Key))
                    first[nGram.Key] += nGram.Value;
                else
                    first.Add(nGram);
            }
        }
    }
}
