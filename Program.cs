using System;
using System.Collections.Generic;
using System.Linq;

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
            List<string> unformattedElements = pTable.Keys.ToList();
            List<string> elements = unformattedElements.ConvertAll(ele => ele.ToUpper());
            Stack<string> result = new Stack<string>();
            if (SpelledWithPElements(word.ToUpper(), elements, result))
            {
                Console.WriteLine($"Your word {word} can be spelled with the following Periodic Elements:");
                PrintResults(result);
                return true;
            }
            else {
                Console.WriteLine($"Sorry! Your word '{word}' cannot be spelled using Periodic Elements.");
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
            var arr = results.ToArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                string formattedEle = "";
                if (arr[i].Length > 1) formattedEle = arr[i][0].ToString() + arr[i].Substring(1).ToLower();
                else formattedEle = arr[i].ToUpper();
                Console.WriteLine($"{formattedEle} - {pTable[formattedEle]}");
            }
        }

        public static Dictionary<string, string> pTable = new Dictionary<string, string>
        {
            {"H", "Hydrogen"},
            {"He", "Helium"},
            {"Li", "Lithium"},
            {"Be", "Beryllium"},
            {"B", "Boron"},
            {"C", "Carbon"},
            {"N", "Nitrogen"},
            {"O", "Oxygen"},
            {"F", "Fluorine"},
            {"Ne", "Neon"},
            {"Na", "Sodium"},
            {"Mg", "Magnesium"},
            {"Al", "Aluminum"},
            {"Si", "Silicon"},
            {"P", "Phosphorus"},
            {"S", "Sulfur"},
            {"Cl", "Chlorine"},
            {"Ar", "Argon"},
            {"K", "Potassium"},
            {"Ca", "Calcium"},
            {"Sc", "Scandium"},
            {"Ti", "Titanium"},
            {"V", "Vanadium"},
            {"Cr", "Chromium"},
            {"Mn", "Manganese"},
            {"Fe", "Iron"},
            {"Co", "Cobalt"},
            {"Ni", "Nickel"},
            {"Cu", "Copper"},
            {"Zn", "Zinc"},
            {"Ga", "Gallium"},
            {"Ge", "Germanium"},
            {"As", "Arsenic"},
            {"Se", "Selenium"},
            {"Br", "Bromine"},
            {"Kr", "Krypton"},
            {"Rb", "Rubidium"},
            {"Sr", "Strontium"},
            {"Y", "Yttrium"},
            {"Zr", "Zirconium"},
            {"Nb", "Niobium"},
            {"Mo", "Molybdenum"},
            {"Tc", "Technetium"},
            {"Ru", "Ruthenium"},
            {"Rh", "Rhodium"},
            {"Pd", "Palladium"},
            {"Ag", "Silver"},
            {"Cd", "Cadmium"},
            {"In", "Indium"},
            {"Sn", "Tin"},
            {"Sb", "Antimony"},
            {"Te", "Tellurium"},
            {"I", "Iodine"},
            {"Xe", "Xenon"},
            {"Cs", "Cesium"},
            {"Ba", "Barium"},
            {"La", "Lanthanum"},
            {"Ce", "Cerium"},
            {"Pr", "Praseodymium"},
            {"Nd", "Neodymium"},
            {"Pm", "Promethium"},
            {"Sm", "Samarium"},
            {"Eu", "Europium"},
            {"Gd", "Gadolinium"},
            {"Tb", "Terbium"},
            {"Dy", "Dysprosium"},
            {"Ho", "Holmium"},
            {"Er", "Erbium"},
            {"Tm", "Thulium"},
            {"Yb", "Ytterbium"},
            {"Lu", "Lutetium"},
            {"Hf", "Hafnium"},
            {"Ta", "Tantalum"},
            {"W", "Tungsten"},
            {"Re", "Rhenium"},
            {"Os", "Osmium"},
            {"Ir", "Iridium"},
            {"Pt", "Platinum"},
            {"Au", "Gold"},
            {"Hg", "Mercury"},
            {"Tl", "Thallium"},
            {"Pb", "Lead"},
            {"Bi", "Bismuth"},
            {"Po", "Polonium"},
            {"At", "Astatine"},
            {"Rn", "Radon"},
            {"Fr", "Francium"},
            {"Ra", "Radium"},
            {"Ac", "Actinium"},
            {"Th", "Thorium"},
            {"Pa", "Protactinium"},
            {"U", "Uranium"},
            {"Np", "Neptunium"},
            {"Pu", "Plutonium"},
            {"Am", "Americium"},
            {"Cm", "Curium"},
            {"Bk", "Berkelium"},
            {"Cf", "Californium"},
            {"Es", "Einsteinium"},
            {"Fm", "Fermium"},
            {"Md", "Mendelevium"},
            {"No", "Nobelium"},
            {"Lr", "Lawrencium"},
            {"Rf", "Rutherfordium"},
            {"Db", "Dubnium"},
            {"Sg", "Seaborgium"},
            {"Bh", "Bohrium"},
            {"Hs", "Hassium"},
            {"Mt", "Meitnerium"},
            {"Ds", "Darmstadtium"},
            {"Rg", "Roentgenium"},
            {"Cn", "Copernicium"},
            {"Nh", "Nihonium"},
            {"Fl", "Flerovium"},
            {"Mc", "Moscovium"},
            {"Lv", "Livermorium"},
            {"Ts", "Tennessine"},
            {"Og", "Oganesson"}
        };
    }
}
