using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class TWordExam
    {
        public string ExamRusWord;
        public TWord Word;

        public TWordExam()
        {
            ExamRusWord = null;
            Word = null;
        }

        public TWordExam(TWord tWord)
        {
            ExamRusWord = null;
            Word = tWord;
        }

        public bool CheckAnswer()
        {
           
            if (ExamRusWord == null)
            {
                return false;
            }
            for (int i = 0; i < Word.RusWords.Count; i++)
            {
                if (ExamRusWord.Equals(Word.RusWords[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
