using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace Lab4
{
    public partial class Form1 : Form
    {
       
        private List<TWord> DictCont = null;
        private List<TWordExam> DictContExam = null;

        private string FileBin = "dictionary.bin";
        private string FileXml = "dictionary.xml";

        private int QuestionCount = 0;
        private int ExamEngWordCounter = 0;
        private bool ExamStarted = false;

        private bool ExamRusWordFocus = false;
        private bool WasExamined = false;

        private WordType AddWordType;

        public static char symRight = '\u2713';
        public static char symWrong = '\u2717';
        public static char symNone = '\u25ef';
        public static char symArrow = '\u2192';

        public Form1()
        {
            InitializeComponent();

            rbNoun.Checked = true;
            AddWordType = WordType.Noun;
            

            DictCont = new List<TWord>();

            
            TWord w1 = new TWord("evgen", new List<string> { "евгений", "евген" }, WordType.Noun);
            TWord w2 = new TWord("will", new List<string> { "будет" }, WordType.Verb);
            TWord w3 = new TWord("pass", new List<string> { "сдавать", "пропускать" }, WordType.Verb);
            TWord w4 = new TWord("exam", new List<string> { "экзамен" }, WordType.Noun);
            TWord w5 = new TWord("on", new List<string> { "по", "в", "на" }, WordType.NA);
            TWord w6 = new TWord("csharp", new List<string> { "си шарп", "сишарп", "с#" }, WordType.Noun);
            TWord w7 = new TWord("excellent", new List<string> { "отлично" }, WordType.NA);
            TWord w8 = new TWord("rapid", new List<string> { "быстрый", "крутой", "скоростной" }, WordType.Adjective);

            DictCont.Add(w1);
            DictCont.Add(w2);
            DictCont.Add(w3);
            DictCont.Add(w4);
            DictCont.Add(w5);
            DictCont.Add(w6);
            DictCont.Add(w7);
            DictCont.Add(w8);

            
            UpdateDictionary();
            UpdateExamWordRange();


            // handlers declarations

            btnAddWord.Click += BtnAdd_Click;
            btnDeleteWord.Click += BtnDeleteWord_Click;
            btnDelDict.Click += BtnDelDict_Click;
            btnResetProgress.Click += BtnResetProgress_Click;

            btnSaveBin.Click += BtnSaveBin_Click;
            btnLoadBin.Click += BtnLoadBin_Click;
            btnSaveXml.Click += BtnSaveXml_Click;
            btnLoadXml.Click += BtnLoadXml_Click;

            btnExamStart.Click += BtnExamStart_Click;
            btnExamContinue.Click += BtnExamContinue_Click;
            
            tbExamRusWord.GotFocus += (o, e) => { ExamRusWordFocus = true; };
            tbExamRusWord.LostFocus += (o, e) => { ExamRusWordFocus = false; };

            rbNoun.CheckedChanged += (o, e) => { AddWordType = WordType.Noun; };
            rbAdj.CheckedChanged += (o, e) => { AddWordType = WordType.Adjective; };
            rbVerb.CheckedChanged += (o, e) => { AddWordType = WordType.Verb; };
            rbNA.CheckedChanged += (o, e) => { AddWordType = WordType.NA; };

            tbEngWordDelete.Enter += (o, e) => { lbTitleDeleteWord.Text = "Delete word from dictionary"; };
            tbEngWord.Enter += (o, e) => { lbTitleAddWord.Text = "Add new word into dictionary"; };
            tbRusWords.Enter += (o, e) => { lbTitleAddWord.Text = "Add new word into dictionary"; };

            trExamWordsRange.ValueChanged += TrExamWordsRange_ValueChanged;

        }

        private void BtnResetProgress_Click(object sender, EventArgs e)
        {
            if (DictCont == null)
            {
                UpdateFileInfo("Dictionary is empty");
                return;
            }

            for (int i = 0; i < DictCont.Count; i++)
            {
                DictCont[i].WordResult = Result.None;
            }

            UpdateFileInfo("Progress reseted");
            UpdateDictionary();
        }

        private void TrExamWordsRange_ValueChanged(object sender, EventArgs e)
        {
            
            int cur = trExamWordsRange.Value;
            QuestionCount = cur;
            lbExamWordsCount.Text = "Exam words : " + QuestionCount;
            
        }

        private void BtnDeleteWord_Click(object sender, EventArgs e)
        {
            string delEngWord = tbEngWordDelete.Text.Trim();
            if (delEngWord.Equals(""))
            {
                lbTitleDeleteWord.Text = "Delete word from dictionary : fill word";
                return;
            }

            bool Deleted = false;

            for (int i = 0; i < DictCont.Count; i++)
            {
                if (delEngWord.Equals(DictCont[i].EngWord))
                {
                    DictCont.RemoveAt(i);
                    Deleted = true;
                    break;
                }
            }

            tbEngWordDelete.Text = "";
            if (Deleted)
            {
                lbTitleDeleteWord.Text = "Delete word from dictionary : word deleted";
                UpdateDictionary();
            }
            else
            {
                lbTitleDeleteWord.Text = "Delete word from dictionary : no such word";
            }

        }

        private void BtnExamContinue_Click(object sender, EventArgs e)
        {
            ExamContinue();
            
        }

        private void ExamContinue()
        {
            if (!ExamStarted)
            {
                lbExamInfo.Text = "Info : Press 'Start'";
            }
            else
            {
                string examRusWord = tbExamRusWord.Text.ToLower().Trim();

                if (examRusWord.Equals(""))
                {
                    lbExamInfo.Text = "Info : fill answer";
                    tbExamRusWord.Text = "";
                    tbExamRusWord.Focus();
                    return;
                }
                if (ExamEngWordCounter < DictContExam.Count)
                {
                    DictContExam[ExamEngWordCounter - 1].ExamRusWord = examRusWord;

                    lbExamEngWord.Text = DictContExam[ExamEngWordCounter].Word.EngWord;
                    tbExamRusWord.Text = "";
                    ExamEngWordCounter++;
                    lbExamProgress.Text = ExamEngWordCounter + " of " + DictContExam.Count + " words";
                }
                else if (ExamEngWordCounter == DictContExam.Count)
                {
                    DictContExam[ExamEngWordCounter - 1].ExamRusWord = examRusWord;
                    lbExamEngWord.Text = "";
                    tbExamRusWord.Text = "";

                    ExamFinished();
                }
                tbExamRusWord.Focus();
            }
        }

        private void BtnExamStart_Click(object sender, EventArgs e)
        {
            if (DictCont == null)
            {
                lbExamInfo.Text = "Info : dictionary is empty";
                return;
            }

            ExamEngWordCounter = 0;
            CreateExam();
            
            lbExamEngWord.Text = DictContExam[ExamEngWordCounter].Word.EngWord;
            ExamEngWordCounter++;
            tbExamRusWord.Text = "";
            lbExamProgress.Text = ExamEngWordCounter + " of " + QuestionCount + " words";
            lbExamInfo.Text = "Info : exam started";
            ExamStarted = true;

            tbExamResults.Text = "";
            tbDictionary.Text = "Exam started. Don't cheat!";
            if (WasExamined)
            {
                tbExamResults.Text = "Exam started. Don't cheat!";
            }

            tbExamRusWord.Focus();
        }

        private void BtnLoadXml_Click(object sender, EventArgs e)
        {
            try
            {
                var stream = new FileStream(FileXml, FileMode.Open);
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<TWord>));
                DictCont = (List<TWord>)xmlSer.Deserialize(stream);
                stream.Close();

                UpdateFileInfo("Loaded from file dictionary.xml");
                UpdateDictionary();
            }
            catch (FileNotFoundException)
            {
                UpdateFileInfo("Cannot find file dictionary.xml");
            }
        }

        private void BtnSaveXml_Click(object sender, EventArgs e)
        {
            if (DictCont == null)
            {
                UpdateFileInfo("Dictionary is empty. Nothing to save");
                return;
            }
            var stream = new FileStream(FileXml, FileMode.Create);
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<TWord>));
            xmlSer.Serialize(stream, DictCont);
            stream.Close();

            UpdateFileInfo("Saved to file dictionary.xml");
        }

        private void BtnLoadBin_Click(object sender, EventArgs e)
        {
            try
            {
                var stream = new FileStream(FileBin, FileMode.Open);
                IFormatter fmt = new BinaryFormatter();
                DictCont = (List<TWord>)fmt.Deserialize(stream);
                stream.Close();

                UpdateFileInfo("Loaded from file dictionary.bin");
                UpdateDictionary();
            }
            catch (FileNotFoundException)
            {
                UpdateFileInfo("Cannot find file dictionary.bin");
            }
            
        }

        private void BtnSaveBin_Click(object sender, EventArgs e)
        {
            if (DictCont == null)
            {
                UpdateFileInfo("Dictionary is empty. Nothing to save");
                return;
            }
            var stream = new FileStream(FileBin, FileMode.Create);
            IFormatter fmt = new BinaryFormatter();
            fmt.Serialize(stream, DictCont);
            stream.Close();

            UpdateFileInfo("Saved to file dictionary.bin");

        }

        private void BtnDelDict_Click(object sender, EventArgs e)
        {
            DictCont = null;
            UpdateFileInfo("Dictionary deleted");
            UpdateDictionary();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string engW = tbEngWord.Text.ToLower().Trim();
            string rusW = tbRusWords.Text.ToLower().Trim();

            if (engW.Equals("") || rusW.Equals(""))
            {
                lbTitleAddWord.Text = "Add new word into dictionary : fill words";
                return;
            }

            char[] separators = { '\n', ',' , '.'};
            string[] rusWordsArr = rusW.Split(separators);
            for (int i = 0; i < rusWordsArr.Length; i++)
            {
                rusWordsArr[i] = rusWordsArr[i].Trim();
            }

            List<string> newRusWords = new List<string>();
            for (int i = 0; i < rusWordsArr.Length; i++)
            {
                if (!rusWordsArr[i].Equals(""))
                {
                    newRusWords.Add(rusWordsArr[i]);
                }
            }
            

            TWord newTWord = new TWord(engW, newRusWords, AddWordType);

            tbEngWord.Text = "";
            tbRusWords.Text = "";
            if (DictCont == null)
            {
                DictCont = new List<TWord>();
            }
            DictCont.Add(newTWord);
            lbTitleAddWord.Text = "Add new word into dictionary : word added";


            UpdateDictionary();
            

        }


        // my methods

        private void PrintDictionary(StringBuilder dictBuf)
        {
            tbDictionary.Text = dictBuf.ToString();
            UpdateStatWords();
            UpdateExamWordRange();
            UpdateAvgWordLength();
        }

        private void UpdateFileInfo(string text)
        {
            lbFileInfo.Text = "Info : " + text;
        }

        private void CreateExam()
        {
            DictContExam = new List<TWordExam>();

            
            List<int> WordsNone = new List<int>();
            for (int i = 0; i < DictCont.Count; i++)
            {
                if (DictCont[i].WordResult == Result.None)
                {
                    WordsNone.Add(i);
                    Console.WriteLine("None " + i);
                }
            }

            List<int> WordsWrong = new List<int>();
            for (int i = 0; i < DictCont.Count; i++)
            {
                if (DictCont[i].WordResult == Result.Wrong)
                {
                    WordsWrong.Add(i);
                    Console.WriteLine("Wrong " + i);
                }
            }

            List<int> WordsRight = new List<int>();
            for (int i = 0; i < DictCont.Count; i++)
            {
                if (DictCont[i].WordResult == Result.Right)
                {
                    WordsRight.Add(i);
                    Console.WriteLine("Right " + i);
                }
            }

            Console.WriteLine();

            List<int> DictListExam = new List<int>();
            bool DictListFilled = false;
            Random rand = new Random();

            int WordsNoneCounter = 0;
            while (!DictListFilled && WordsNoneCounter < WordsNone.Count)
            {
                int newWord = rand.Next(0, WordsNone.Count);
                bool res = DictListExam.Contains(WordsNone[newWord]);
                if (!res)
                {
                    DictListExam.Add(WordsNone[newWord]);
                    WordsNoneCounter++;
                }
                if (DictListExam.Count == QuestionCount) DictListFilled = true;
            }

            int WordsWrongCounter = 0;
            while (!DictListFilled && WordsWrongCounter < WordsWrong.Count)
            {
                int newWord = rand.Next(0, WordsWrong.Count);
                bool res = DictListExam.Contains(WordsWrong[newWord]);
                if (!res)
                {
                    DictListExam.Add(WordsWrong[newWord]);
                    WordsWrongCounter++;
                }
                if (DictListExam.Count == QuestionCount) DictListFilled = true;
            }

            int WordsRightCounter = 0;
            while (!DictListFilled && WordsRightCounter < WordsRight.Count)
            {
                int newWord = rand.Next(0, WordsRight.Count);
                bool res = DictListExam.Contains(WordsRight[newWord]);
                if (!res)
                {
                    DictListExam.Add(WordsRight[newWord]);
                    WordsRightCounter++;
                }
                if (DictListExam.Count == QuestionCount) DictListFilled = true;
            }

            // final fill
            
            for (int i = 0; i < DictListExam.Count; i++)
            {
                TWordExam newTWordExam = new TWordExam(DictCont[DictListExam[i]]);
                DictContExam.Add(newTWordExam);
            }



        }

        private void ExamFinished()
        {
            
            int rightAnswers = CheckAnswers();
            int grade = rightAnswers * 100 / DictContExam.Count;
            lbExamInfo.Text = "Info : exam finished. Result : " + grade + "% ( " + rightAnswers + " / " +
               +DictContExam.Count + " )";

            lbStatRightAns.Text = "Right answers : " + rightAnswers;
            lbStatWrongAns.Text = "Wrong answers : " + (DictContExam.Count - rightAnswers);
            lbStatGrade.Text = "Grade : " + grade +"%";

            StringBuilder ExamResult = new StringBuilder(500);
            

            for (int i = 0; i < DictContExam.Count; i++)
            {
                
                if (DictContExam[i].CheckAnswer())
                {
                    ExamResult.Append(symRight);
                    DictContExam[i].Word.WordResult = Result.Right;
                }
                else
                {
                    ExamResult.Append(symWrong);
                    DictContExam[i].Word.WordResult = Result.Wrong;
                }
                ExamResult.Append(" ");
                ExamResult.Append(DictContExam[i].Word.EngWord);
                ExamResult.Append(" " + char.ToString(symArrow) + " ");
                ExamResult.Append(DictContExam[i].ExamRusWord);
                ExamResult.AppendLine();
            }

            tbExamResults.Text = ExamResult.ToString();
            WasExamined = true;

            DictContExam = null;
            ExamEngWordCounter = 0;
            ExamStarted = false;

            UpdateDictionary();
        }

        private int CheckAnswers()
        {
            int rightAnswers = 0;

            for (int i = 0; i < DictContExam.Count; i++)
            {
                if (DictContExam[i].CheckAnswer())
                {
                    rightAnswers++;
                }
            }

            return rightAnswers;
        }

        private void UpdateStatWords()
        {
            int words, nouns, adjs, verbs, na;
            words = nouns = adjs = verbs = na = 0;

            if (DictCont != null)
            {
                words = DictCont.Count;

                for (int i = 0; i < DictCont.Count; i++)
                {
                    if (DictCont[i].EngWordType == WordType.Noun) nouns++;
                    else if (DictCont[i].EngWordType == WordType.Adjective) adjs++;
                    else if (DictCont[i].EngWordType == WordType.Verb) verbs++;
                    else na++;
                }

            }
           
            lbStatWords.Text = "Words : " + words;
            lbStatNoun.Text = "Nouns : " + nouns;
            lbStatAdjective.Text = "Adjectives : " + adjs;
            lbStatVerb.Text = "Verbs : " + verbs;
            lbStatNA.Text = "N/A : " + na;


        }

        private void UpdateDictionary()
        {
            if (DictCont == null)
            {
                PrintDictionary(new StringBuilder("Dictionary is empty"));
                return;
            }

            StringBuilder DictBuf = new StringBuilder(1000);
            for (int i = 0; i < DictCont.Count; i++)
            {
                DictBuf.Append(DictCont[i].ToString());
                DictBuf.AppendLine();
            }

            PrintDictionary(DictBuf);
            

            DictBuf = null;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool isHandled = true;


            switch (keyData)
            {

                case Keys.Enter:
                    if (ExamRusWordFocus == true)
                    {
                        ExamContinue();
                        return isHandled;
                    }

                    break;

                default:
                    break;
            }

            return false;
        }

        private void UpdateExamWordRange()
        {
            int min, max, cur;
            if (DictCont == null)
            {
                min = max = cur = 0;
            }
            else
            {
                min = 1;
                max = DictCont.Count;
                cur = max < 5 ? max : 5;
            }

            lbExamWordsCount.Text = "Exam words : " + cur;

            trExamWordsRange.Minimum = min;
            trExamWordsRange.Maximum = max;
            trExamWordsRange.Value = cur;


            QuestionCount = cur;
        }

        private void UpdateAvgWordLength()
        {
            float avgEng, avgRus;
            string avgEngStr = "";
            string avgRusStr = "";

            if (DictCont == null)
            {
                avgEngStr = "0,0";
                avgRusStr = "0,0";
            }
            else
            {
                int sumEng = 0;
                int counterEng = DictCont.Count;
                int sumRus = 0;
                int counterRus = 0;

                for (int i = 0; i < DictCont.Count; i++)
                {

                    sumEng += DictCont[i].EngWord.Length;
                    for (int j = 0; j < DictCont[i].RusWords.Count; j++)
                    {
                        sumRus += DictCont[i].RusWords[j].Length;
                        counterRus++;
                    }
                }

                avgEng = (float)sumEng / counterEng;
                avgRus = (float)sumRus / counterRus;

                avgEngStr = String.Format("{0:0.0}", avgEng);
                avgRusStr = String.Format("{0:0.0}", avgRus);
            }

            lbAvgEngWord.Text = "AVG eng word length : " + avgEngStr;
            lbAvgRusWord.Text = "AVG rus word length : " + avgRusStr;

        }
        
    }
}
