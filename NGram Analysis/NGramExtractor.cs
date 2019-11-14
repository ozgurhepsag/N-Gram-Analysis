using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGram_Analysis
{
    public class NGramExtractor
    {
        private readonly int nGramSize;

        public NGramExtractor(int nGramSize)
        {
            this.nGramSize = nGramSize;
        }

        public IDictionary<NGram, int> ExtractAsDictionary(IEnumerable<string> tokens)
        {
            var dictionary = new Dictionary<NGram, int>();
            IList<NGram> nGrams = ExtractAsList(tokens);

            foreach (NGram nGram in nGrams)
            {
                if (dictionary.ContainsKey(nGram))
                    dictionary[nGram]++;
                else
                    dictionary.Add(nGram, 1);
            }

            return dictionary;
        }

        public IList<NGram> ExtractAsList(IEnumerable<string> tokens)
        {
            var nGrams = new List<NGram>();
            List<string> tokenList = tokens.ToList();

            for (int i = 0; i <= tokens.Count() - nGramSize; i++)
                nGrams.Add(GetNGram(tokenList, i));

            return nGrams;
        }

        private NGram GetNGram(IList<string> tokens, int index)
        {
            var nGramsList = new List<string>();

            for (int i = 0; i < nGramSize; i++)
                nGramsList.Add(tokens[index + i]);

            NGram nGram = new NGram(nGramsList);
            return nGram;
        }

    }
}
