using System;
using System.Collections.Generic;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vocab = new List<string>()
            {
                "MTAO", "OF", "TEC", "MXD", "T", "O", "AF", "AE", "A",
                "TAZ", "MTBXAE", "ABCDE", "TAEC", "MTOZE", "MITXFAEC", "MTAFC", "MTSFOC", "MTZABC",
                "MTAFOC", "MITXFFEC", "XAEC", "MTAFEC", "F", "MTBXAEC", "ZAEC", "MFECFEC", "TAX",
                "MTXAFEC", "TAFEC", "MXAFECI", "TAE", "ITXAFC", "MTAFOCC", "MITXAFEOC", "D", "MXITABFEC",
                "AC", "MTAFOC", "MD", "MTXABCD", "OA", "MITXAFEC", "OFMIT", "TED", "MTAEC",
                "MITXFAEE", "TAF", "TAC", "AEOC", "TA", "MITXAFC", "ITXAFEC", "MITXAFE", "MITAFEC"
            };
            ShrinkableWords("MITXAFEC", vocab);
            
        }
        static bool ShrinkableWords(string word, List<string> vocab)
        {
            Stack<string> result = new Stack<string>();
            if (ShrinkableWords(word, vocab, 0, result)) {
                PrintResult(result);
                return true;
            } else return false;
        }

        static bool ShrinkableWords(string word, List<string> vocab, int index, Stack<string> result)
        {
            if (word == "") return true;
            if (!vocab.Contains(word))
            {
                return false;
            }            
            for (int i = 0; i < word.Length; i++)
            {
                string nextWord = word.Remove(i, 1);
                result.Push(word + $" -> will remove {word[i]} next");
                if (ShrinkableWords(nextWord, vocab, 0, result)) 
                {
                    return true;
                } 
                else result.Pop();
            }
            return false;
        }

        static void PrintResult(Stack<string> result)
        {
            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }
    }


}
