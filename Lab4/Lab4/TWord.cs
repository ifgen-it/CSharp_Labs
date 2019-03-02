using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab4
{
    public enum WordType
    {
        NA = 0,
        Noun = 1,
        Adjective = 2,
        Verb =3
    }

    public enum Result
    {
        None = 0,
        Right = 1,
        Wrong = 2
    }

    [Serializable]
    public class TWord
    {
        private static string[] WordTypeArray = { "N\\A ", "Noun", "Adj ", "Verb" };

        [XmlAttribute("English")]
        public string EngWord;

        [XmlAttribute("Type")]
        public WordType EngWordType;

        public List<string> RusWords;

        [XmlAttribute("Result")]
        public Result WordResult;

        public TWord()
        {
            EngWord = null;
            RusWords = null;
            EngWordType = WordType.NA;
            WordResult = Result.None;
        }

        public TWord(string engW, List<string> rusW, WordType engWordType)
        {
            EngWord = engW;
            EngWordType = engWordType;
            RusWords = rusW.ToList<string>();
            WordResult = Result.None;
        }

        public override string ToString()
        {
            string rusWords = "";
            for (int i = 0; i < RusWords.Count; i++)
            {
                rusWords += RusWords[i];
                if (i < RusWords.Count - 1)
                {
                    rusWords += ", ";
                }
            }

            string res = WordTypeArray[(int)EngWordType] + " ";
            if (WordResult == Result.Right)
            {
                res += Form1.symRight;
            }
            else if (WordResult == Result.Wrong)
            {
                res += Form1.symWrong;
            }
            else
            {
                res += Form1.symNone;
            }

            res += " " + EngWord + " " + char.ToString(Form1.symArrow) + " " + rusWords;

            return res;
        }

    }
}
