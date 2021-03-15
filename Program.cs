using System;
using System.Collections.Generic;

namespace Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            SpelledWithPElements("canine");
            Console.WriteLine();
            SpelledWithPElements("procrastinate");
            Console.WriteLine();
            SpelledWithPElements("computer");
        }

        static bool SpelledWithPElements(string word)
        {
            List<string> unformattedElements = new List<string>
            {
                "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru", "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "Te", "I", "Xe", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Tl", "Pb", "Bi", "Po", "At", "Rn", "Fr", "Ra", "Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No", "Lr", "Rf", "Db", "Sg", "Bh", "Hs", "Mt", "Ds", "Rg", "Cn", "Nh", "Fl", "Mc", "Lv", "Ts", "Og"
            };
            List<string> elements = unformattedElements.ConvertAll(ele => ele.ToUpper());
            Stack<string> result = new Stack<string>();
            if (SpelledWithPElements(word.ToUpper(), elements, result))
            {
                Console.WriteLine($"Your word {word} can be spelled with the following Periodic Elements:");
                PrintResults(result);
                return true;
            }
            else {
                Console.WriteLine($"Sorry! your word '{word}' cannot be spelled using Periodic Elements");
                return false;
            };
        }

        static bool SpelledWithPElements(string word, List<string> elements, Stack<string> results)
        {
            if (word == "")
            {
                return true;
            }
            if (elements.Contains(word.Substring(0,2)))
            {
                results.Push(word.Substring(0, 2));
                if (SpelledWithPElements(word.Substring(2), elements, results)) return true;
                results.Pop();
            }
            if (elements.Contains(word.Substring(0,1)))
            {
                results.Push(word.Substring(0, 1));
                if (SpelledWithPElements(word.Substring(1), elements, results)) return true;
            }
            return false;
            
        }
        static void PrintResults(Stack<string> results)
        {
            string spelling = "";
            foreach (string ele in results)
            {
                string formattedEle = ele.Length > 1 ? ele[0].ToString() + ele.Substring(1).ToLower() : ele;
                spelling = formattedEle + spelling;
            }
            Console.WriteLine(spelling);

        }
    }


}
