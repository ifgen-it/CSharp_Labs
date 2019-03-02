namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDictionary = new System.Windows.Forms.TabPage();
            this.tbDictionary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabWord = new System.Windows.Forms.TabPage();
            this.rbAdj = new System.Windows.Forms.RadioButton();
            this.rbNA = new System.Windows.Forms.RadioButton();
            this.rbVerb = new System.Windows.Forms.RadioButton();
            this.rbNoun = new System.Windows.Forms.RadioButton();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.tbRusWords = new System.Windows.Forms.TextBox();
            this.tbEngWordDelete = new System.Windows.Forms.TextBox();
            this.tbEngWord = new System.Windows.Forms.TextBox();
            this.lbTitleDeleteWord = new System.Windows.Forms.Label();
            this.lbTitleAddWord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabExam = new System.Windows.Forms.TabPage();
            this.trExamWordsRange = new System.Windows.Forms.TrackBar();
            this.tbExamRusWord = new System.Windows.Forms.TextBox();
            this.btnExamContinue = new System.Windows.Forms.Button();
            this.btnExamStart = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lbExamEngWord = new System.Windows.Forms.Label();
            this.lbExamInfo = new System.Windows.Forms.Label();
            this.lbExamProgress = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbExamWordsCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.tbExamResults = new System.Windows.Forms.TextBox();
            this.lbStatGrade = new System.Windows.Forms.Label();
            this.lbStatWrongAns = new System.Windows.Forms.Label();
            this.lbStatRightAns = new System.Windows.Forms.Label();
            this.lbAvgRusWord = new System.Windows.Forms.Label();
            this.lbAvgEngWord = new System.Windows.Forms.Label();
            this.lbStatNA = new System.Windows.Forms.Label();
            this.lbStatVerb = new System.Windows.Forms.Label();
            this.lbStatAdjective = new System.Windows.Forms.Label();
            this.lbStatNoun = new System.Windows.Forms.Label();
            this.lbStatWords = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabFile = new System.Windows.Forms.TabPage();
            this.lbFileInfo = new System.Windows.Forms.Label();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnLoadBin = new System.Windows.Forms.Button();
            this.btnResetProgress = new System.Windows.Forms.Button();
            this.btnDelDict = new System.Windows.Forms.Button();
            this.btnSaveBin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDictionary.SuspendLayout();
            this.tabWord.SuspendLayout();
            this.tabExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trExamWordsRange)).BeginInit();
            this.tabStatistics.SuspendLayout();
            this.tabFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDictionary);
            this.tabControl1.Controls.Add(this.tabWord);
            this.tabControl1.Controls.Add(this.tabExam);
            this.tabControl1.Controls.Add(this.tabStatistics);
            this.tabControl1.Controls.Add(this.tabFile);
            this.tabControl1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDictionary
            // 
            this.tabDictionary.Controls.Add(this.tbDictionary);
            this.tabDictionary.Controls.Add(this.label6);
            this.tabDictionary.Location = new System.Drawing.Point(4, 27);
            this.tabDictionary.Name = "tabDictionary";
            this.tabDictionary.Size = new System.Drawing.Size(542, 329);
            this.tabDictionary.TabIndex = 5;
            this.tabDictionary.Text = "Dictionary";
            this.tabDictionary.UseVisualStyleBackColor = true;
            // 
            // tbDictionary
            // 
            this.tbDictionary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDictionary.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDictionary.Location = new System.Drawing.Point(26, 62);
            this.tbDictionary.Multiline = true;
            this.tbDictionary.Name = "tbDictionary";
            this.tbDictionary.ReadOnly = true;
            this.tbDictionary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDictionary.Size = new System.Drawing.Size(493, 244);
            this.tbDictionary.TabIndex = 3;
            this.tbDictionary.Text = "net -> сеть";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "English words and its russian translations";
            // 
            // tabWord
            // 
            this.tabWord.Controls.Add(this.rbAdj);
            this.tabWord.Controls.Add(this.rbNA);
            this.tabWord.Controls.Add(this.rbVerb);
            this.tabWord.Controls.Add(this.rbNoun);
            this.tabWord.Controls.Add(this.btnDeleteWord);
            this.tabWord.Controls.Add(this.btnAddWord);
            this.tabWord.Controls.Add(this.tbRusWords);
            this.tabWord.Controls.Add(this.tbEngWordDelete);
            this.tabWord.Controls.Add(this.tbEngWord);
            this.tabWord.Controls.Add(this.lbTitleDeleteWord);
            this.tabWord.Controls.Add(this.lbTitleAddWord);
            this.tabWord.Controls.Add(this.label4);
            this.tabWord.Controls.Add(this.label12);
            this.tabWord.Controls.Add(this.label3);
            this.tabWord.Controls.Add(this.label1);
            this.tabWord.Location = new System.Drawing.Point(4, 27);
            this.tabWord.Name = "tabWord";
            this.tabWord.Size = new System.Drawing.Size(542, 329);
            this.tabWord.TabIndex = 3;
            this.tabWord.Text = "Word";
            this.tabWord.UseVisualStyleBackColor = true;
            // 
            // rbAdj
            // 
            this.rbAdj.AutoSize = true;
            this.rbAdj.Location = new System.Drawing.Point(472, 91);
            this.rbAdj.Name = "rbAdj";
            this.rbAdj.Size = new System.Drawing.Size(53, 22);
            this.rbAdj.TabIndex = 3;
            this.rbAdj.TabStop = true;
            this.rbAdj.Text = "Adj";
            this.rbAdj.UseVisualStyleBackColor = true;
            // 
            // rbNA
            // 
            this.rbNA.AutoSize = true;
            this.rbNA.Location = new System.Drawing.Point(472, 131);
            this.rbNA.Name = "rbNA";
            this.rbNA.Size = new System.Drawing.Size(50, 22);
            this.rbNA.TabIndex = 5;
            this.rbNA.TabStop = true;
            this.rbNA.Text = "N/A";
            this.rbNA.UseVisualStyleBackColor = true;
            // 
            // rbVerb
            // 
            this.rbVerb.AutoSize = true;
            this.rbVerb.Location = new System.Drawing.Point(385, 131);
            this.rbVerb.Name = "rbVerb";
            this.rbVerb.Size = new System.Drawing.Size(64, 22);
            this.rbVerb.TabIndex = 4;
            this.rbVerb.TabStop = true;
            this.rbVerb.Text = "Verb";
            this.rbVerb.UseVisualStyleBackColor = true;
            // 
            // rbNoun
            // 
            this.rbNoun.AutoSize = true;
            this.rbNoun.Location = new System.Drawing.Point(383, 91);
            this.rbNoun.Name = "rbNoun";
            this.rbNoun.Size = new System.Drawing.Size(66, 22);
            this.rbNoun.TabIndex = 2;
            this.rbNoun.TabStop = true;
            this.rbNoun.Text = "Noun";
            this.rbNoun.UseVisualStyleBackColor = true;
            // 
            // btnDeleteWord
            // 
            this.btnDeleteWord.Location = new System.Drawing.Point(388, 280);
            this.btnDeleteWord.Name = "btnDeleteWord";
            this.btnDeleteWord.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteWord.TabIndex = 9;
            this.btnDeleteWord.Text = "Delete";
            this.btnDeleteWord.UseVisualStyleBackColor = true;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(385, 178);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(137, 23);
            this.btnAddWord.TabIndex = 7;
            this.btnAddWord.Text = "Add";
            this.btnAddWord.UseVisualStyleBackColor = true;
            // 
            // tbRusWords
            // 
            this.tbRusWords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRusWords.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRusWords.ForeColor = System.Drawing.Color.MediumBlue;
            this.tbRusWords.Location = new System.Drawing.Point(94, 131);
            this.tbRusWords.Multiline = true;
            this.tbRusWords.Name = "tbRusWords";
            this.tbRusWords.Size = new System.Drawing.Size(266, 70);
            this.tbRusWords.TabIndex = 6;
            this.tbRusWords.Text = "сеть, сетка, ,\r\nпаутина";
            // 
            // tbEngWordDelete
            // 
            this.tbEngWordDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbEngWordDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEngWordDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEngWordDelete.Location = new System.Drawing.Point(94, 278);
            this.tbEngWordDelete.Name = "tbEngWordDelete";
            this.tbEngWordDelete.Size = new System.Drawing.Size(266, 26);
            this.tbEngWordDelete.TabIndex = 8;
            this.tbEngWordDelete.Text = "net";
            // 
            // tbEngWord
            // 
            this.tbEngWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbEngWord.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEngWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbEngWord.Location = new System.Drawing.Point(94, 90);
            this.tbEngWord.Name = "tbEngWord";
            this.tbEngWord.Size = new System.Drawing.Size(266, 26);
            this.tbEngWord.TabIndex = 1;
            this.tbEngWord.Text = "net";
            // 
            // lbTitleDeleteWord
            // 
            this.lbTitleDeleteWord.AutoSize = true;
            this.lbTitleDeleteWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitleDeleteWord.Location = new System.Drawing.Point(19, 236);
            this.lbTitleDeleteWord.Name = "lbTitleDeleteWord";
            this.lbTitleDeleteWord.Size = new System.Drawing.Size(244, 18);
            this.lbTitleDeleteWord.TabIndex = 1;
            this.lbTitleDeleteWord.Text = "Delete word from dictionary";
            // 
            // lbTitleAddWord
            // 
            this.lbTitleAddWord.AutoSize = true;
            this.lbTitleAddWord.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbTitleAddWord.Location = new System.Drawing.Point(19, 19);
            this.lbTitleAddWord.Name = "lbTitleAddWord";
            this.lbTitleAddWord.Size = new System.Drawing.Size(249, 18);
            this.lbTitleAddWord.TabIndex = 1;
            this.lbTitleAddWord.Text = "Add new word into dictionary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Use comma or Enter to separate russian words ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "English";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Russian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "English";
            // 
            // tabExam
            // 
            this.tabExam.Controls.Add(this.trExamWordsRange);
            this.tabExam.Controls.Add(this.tbExamRusWord);
            this.tabExam.Controls.Add(this.btnExamContinue);
            this.tabExam.Controls.Add(this.btnExamStart);
            this.tabExam.Controls.Add(this.label18);
            this.tabExam.Controls.Add(this.lbExamEngWord);
            this.tabExam.Controls.Add(this.lbExamInfo);
            this.tabExam.Controls.Add(this.lbExamProgress);
            this.tabExam.Controls.Add(this.label17);
            this.tabExam.Controls.Add(this.label16);
            this.tabExam.Controls.Add(this.lbExamWordsCount);
            this.tabExam.Controls.Add(this.label13);
            this.tabExam.Location = new System.Drawing.Point(4, 27);
            this.tabExam.Name = "tabExam";
            this.tabExam.Padding = new System.Windows.Forms.Padding(3);
            this.tabExam.Size = new System.Drawing.Size(542, 329);
            this.tabExam.TabIndex = 1;
            this.tabExam.Text = "Exam";
            this.tabExam.UseVisualStyleBackColor = true;
            // 
            // trExamWordsRange
            // 
            this.trExamWordsRange.BackColor = System.Drawing.SystemColors.Window;
            this.trExamWordsRange.LargeChange = 1;
            this.trExamWordsRange.Location = new System.Drawing.Point(168, 71);
            this.trExamWordsRange.Minimum = 1;
            this.trExamWordsRange.Name = "trExamWordsRange";
            this.trExamWordsRange.Size = new System.Drawing.Size(206, 45);
            this.trExamWordsRange.TabIndex = 1;
            this.trExamWordsRange.Value = 5;
            // 
            // tbExamRusWord
            // 
            this.tbExamRusWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbExamRusWord.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExamRusWord.ForeColor = System.Drawing.Color.MediumBlue;
            this.tbExamRusWord.Location = new System.Drawing.Point(119, 202);
            this.tbExamRusWord.Name = "tbExamRusWord";
            this.tbExamRusWord.Size = new System.Drawing.Size(255, 26);
            this.tbExamRusWord.TabIndex = 3;
            this.tbExamRusWord.Text = "сеть";
            // 
            // btnExamContinue
            // 
            this.btnExamContinue.Location = new System.Drawing.Point(401, 204);
            this.btnExamContinue.Name = "btnExamContinue";
            this.btnExamContinue.Size = new System.Drawing.Size(117, 23);
            this.btnExamContinue.TabIndex = 4;
            this.btnExamContinue.Text = "Continue";
            this.btnExamContinue.UseVisualStyleBackColor = true;
            // 
            // btnExamStart
            // 
            this.btnExamStart.Location = new System.Drawing.Point(401, 71);
            this.btnExamStart.Name = "btnExamStart";
            this.btnExamStart.Size = new System.Drawing.Size(117, 23);
            this.btnExamStart.TabIndex = 2;
            this.btnExamStart.Text = "Start";
            this.btnExamStart.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Russian";
            // 
            // lbExamEngWord
            // 
            this.lbExamEngWord.AutoSize = true;
            this.lbExamEngWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbExamEngWord.Location = new System.Drawing.Point(116, 165);
            this.lbExamEngWord.Name = "lbExamEngWord";
            this.lbExamEngWord.Size = new System.Drawing.Size(36, 18);
            this.lbExamEngWord.TabIndex = 0;
            this.lbExamEngWord.Text = "net";
            // 
            // lbExamInfo
            // 
            this.lbExamInfo.AutoSize = true;
            this.lbExamInfo.Location = new System.Drawing.Point(25, 288);
            this.lbExamInfo.Name = "lbExamInfo";
            this.lbExamInfo.Size = new System.Drawing.Size(51, 18);
            this.lbExamInfo.TabIndex = 0;
            this.lbExamInfo.Text = "Info :";
            // 
            // lbExamProgress
            // 
            this.lbExamProgress.AutoSize = true;
            this.lbExamProgress.Location = new System.Drawing.Point(25, 257);
            this.lbExamProgress.Name = "lbExamProgress";
            this.lbExamProgress.Size = new System.Drawing.Size(106, 18);
            this.lbExamProgress.TabIndex = 0;
            this.lbExamProgress.Text = "0 of 0 words";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 165);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "English";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(381, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "Type translation and press Enter or Continue";
            // 
            // lbExamWordsCount
            // 
            this.lbExamWordsCount.AutoSize = true;
            this.lbExamWordsCount.Location = new System.Drawing.Point(25, 73);
            this.lbExamWordsCount.Name = "lbExamWordsCount";
            this.lbExamWordsCount.Size = new System.Drawing.Size(123, 18);
            this.lbExamWordsCount.TabIndex = 0;
            this.lbExamWordsCount.Text = "Exam words : 0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.MediumBlue;
            this.label13.Location = new System.Drawing.Point(25, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Checking knowledge";
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.tbExamResults);
            this.tabStatistics.Controls.Add(this.lbStatGrade);
            this.tabStatistics.Controls.Add(this.lbStatWrongAns);
            this.tabStatistics.Controls.Add(this.lbStatRightAns);
            this.tabStatistics.Controls.Add(this.lbAvgRusWord);
            this.tabStatistics.Controls.Add(this.lbAvgEngWord);
            this.tabStatistics.Controls.Add(this.lbStatNA);
            this.tabStatistics.Controls.Add(this.lbStatVerb);
            this.tabStatistics.Controls.Add(this.lbStatAdjective);
            this.tabStatistics.Controls.Add(this.lbStatNoun);
            this.tabStatistics.Controls.Add(this.lbStatWords);
            this.tabStatistics.Controls.Add(this.label11);
            this.tabStatistics.Controls.Add(this.label9);
            this.tabStatistics.Location = new System.Drawing.Point(4, 27);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Size = new System.Drawing.Size(542, 329);
            this.tabStatistics.TabIndex = 2;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // tbExamResults
            // 
            this.tbExamResults.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExamResults.Location = new System.Drawing.Point(254, 170);
            this.tbExamResults.Multiline = true;
            this.tbExamResults.Name = "tbExamResults";
            this.tbExamResults.ReadOnly = true;
            this.tbExamResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbExamResults.Size = new System.Drawing.Size(267, 139);
            this.tbExamResults.TabIndex = 1;
            // 
            // lbStatGrade
            // 
            this.lbStatGrade.AutoSize = true;
            this.lbStatGrade.Location = new System.Drawing.Point(251, 64);
            this.lbStatGrade.Name = "lbStatGrade";
            this.lbStatGrade.Size = new System.Drawing.Size(88, 18);
            this.lbStatGrade.TabIndex = 0;
            this.lbStatGrade.Text = "Grade : 0%";
            // 
            // lbStatWrongAns
            // 
            this.lbStatWrongAns.AutoSize = true;
            this.lbStatWrongAns.Location = new System.Drawing.Point(251, 136);
            this.lbStatWrongAns.Name = "lbStatWrongAns";
            this.lbStatWrongAns.Size = new System.Drawing.Size(151, 18);
            this.lbStatWrongAns.TabIndex = 0;
            this.lbStatWrongAns.Text = "Wrong answers : 0";
            // 
            // lbStatRightAns
            // 
            this.lbStatRightAns.AutoSize = true;
            this.lbStatRightAns.Location = new System.Drawing.Point(251, 106);
            this.lbStatRightAns.Name = "lbStatRightAns";
            this.lbStatRightAns.Size = new System.Drawing.Size(145, 18);
            this.lbStatRightAns.TabIndex = 0;
            this.lbStatRightAns.Text = "Right answers : 0";
            // 
            // lbAvgRusWord
            // 
            this.lbAvgRusWord.AutoSize = true;
            this.lbAvgRusWord.Location = new System.Drawing.Point(23, 278);
            this.lbAvgRusWord.Name = "lbAvgRusWord";
            this.lbAvgRusWord.Size = new System.Drawing.Size(209, 18);
            this.lbAvgRusWord.TabIndex = 0;
            this.lbAvgRusWord.Text = "AVG rus word length : 0,0";
            // 
            // lbAvgEngWord
            // 
            this.lbAvgEngWord.AutoSize = true;
            this.lbAvgEngWord.Location = new System.Drawing.Point(23, 248);
            this.lbAvgEngWord.Name = "lbAvgEngWord";
            this.lbAvgEngWord.Size = new System.Drawing.Size(209, 18);
            this.lbAvgEngWord.TabIndex = 0;
            this.lbAvgEngWord.Text = "AVG eng word length : 0,0";
            // 
            // lbStatNA
            // 
            this.lbStatNA.AutoSize = true;
            this.lbStatNA.Location = new System.Drawing.Point(23, 197);
            this.lbStatNA.Name = "lbStatNA";
            this.lbStatNA.Size = new System.Drawing.Size(54, 18);
            this.lbStatNA.TabIndex = 0;
            this.lbStatNA.Text = "N/A : 0";
            // 
            // lbStatVerb
            // 
            this.lbStatVerb.AutoSize = true;
            this.lbStatVerb.Location = new System.Drawing.Point(23, 167);
            this.lbStatVerb.Name = "lbStatVerb";
            this.lbStatVerb.Size = new System.Drawing.Size(76, 18);
            this.lbStatVerb.TabIndex = 0;
            this.lbStatVerb.Text = "Verbs : 0";
            // 
            // lbStatAdjective
            // 
            this.lbStatAdjective.AutoSize = true;
            this.lbStatAdjective.Location = new System.Drawing.Point(23, 136);
            this.lbStatAdjective.Name = "lbStatAdjective";
            this.lbStatAdjective.Size = new System.Drawing.Size(116, 18);
            this.lbStatAdjective.TabIndex = 0;
            this.lbStatAdjective.Text = "Adjectives : 0";
            // 
            // lbStatNoun
            // 
            this.lbStatNoun.AutoSize = true;
            this.lbStatNoun.Location = new System.Drawing.Point(23, 106);
            this.lbStatNoun.Name = "lbStatNoun";
            this.lbStatNoun.Size = new System.Drawing.Size(78, 18);
            this.lbStatNoun.TabIndex = 0;
            this.lbStatNoun.Text = "Nouns : 0";
            // 
            // lbStatWords
            // 
            this.lbStatWords.AutoSize = true;
            this.lbStatWords.Location = new System.Drawing.Point(23, 64);
            this.lbStatWords.Name = "lbStatWords";
            this.lbStatWords.Size = new System.Drawing.Size(80, 18);
            this.lbStatWords.TabIndex = 0;
            this.lbStatWords.Text = "Words : 0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.MediumBlue;
            this.label11.Location = new System.Drawing.Point(251, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Exam summary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(23, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Dictionary summary";
            // 
            // tabFile
            // 
            this.tabFile.Controls.Add(this.lbFileInfo);
            this.tabFile.Controls.Add(this.btnLoadXml);
            this.tabFile.Controls.Add(this.btnSaveXml);
            this.tabFile.Controls.Add(this.btnLoadBin);
            this.tabFile.Controls.Add(this.btnResetProgress);
            this.tabFile.Controls.Add(this.btnDelDict);
            this.tabFile.Controls.Add(this.btnSaveBin);
            this.tabFile.Controls.Add(this.label2);
            this.tabFile.Controls.Add(this.label8);
            this.tabFile.Controls.Add(this.label21);
            this.tabFile.Controls.Add(this.label7);
            this.tabFile.Location = new System.Drawing.Point(4, 27);
            this.tabFile.Name = "tabFile";
            this.tabFile.Size = new System.Drawing.Size(542, 329);
            this.tabFile.TabIndex = 4;
            this.tabFile.Text = "File";
            this.tabFile.UseVisualStyleBackColor = true;
            // 
            // lbFileInfo
            // 
            this.lbFileInfo.AutoSize = true;
            this.lbFileInfo.Location = new System.Drawing.Point(26, 281);
            this.lbFileInfo.Name = "lbFileInfo";
            this.lbFileInfo.Size = new System.Drawing.Size(51, 18);
            this.lbFileInfo.TabIndex = 2;
            this.lbFileInfo.Text = "Info :";
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnLoadXml.Location = new System.Drawing.Point(135, 188);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(93, 23);
            this.btnLoadXml.TabIndex = 4;
            this.btnLoadXml.Text = "XML";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSaveXml.Location = new System.Drawing.Point(135, 66);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(93, 23);
            this.btnSaveXml.TabIndex = 2;
            this.btnSaveXml.Text = "XML";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            // 
            // btnLoadBin
            // 
            this.btnLoadBin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadBin.Location = new System.Drawing.Point(26, 188);
            this.btnLoadBin.Name = "btnLoadBin";
            this.btnLoadBin.Size = new System.Drawing.Size(93, 23);
            this.btnLoadBin.TabIndex = 3;
            this.btnLoadBin.Text = "Bin";
            this.btnLoadBin.UseVisualStyleBackColor = true;
            // 
            // btnResetProgress
            // 
            this.btnResetProgress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnResetProgress.Location = new System.Drawing.Point(304, 66);
            this.btnResetProgress.Name = "btnResetProgress";
            this.btnResetProgress.Size = new System.Drawing.Size(93, 23);
            this.btnResetProgress.TabIndex = 5;
            this.btnResetProgress.Text = "Reset";
            this.btnResetProgress.UseVisualStyleBackColor = true;
            // 
            // btnDelDict
            // 
            this.btnDelDict.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnDelDict.Location = new System.Drawing.Point(304, 188);
            this.btnDelDict.Name = "btnDelDict";
            this.btnDelDict.Size = new System.Drawing.Size(93, 23);
            this.btnDelDict.TabIndex = 6;
            this.btnDelDict.Text = "Delete";
            this.btnDelDict.UseVisualStyleBackColor = true;
            // 
            // btnSaveBin
            // 
            this.btnSaveBin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveBin.Location = new System.Drawing.Point(26, 66);
            this.btnSaveBin.Name = "btnSaveBin";
            this.btnSaveBin.Size = new System.Drawing.Size(93, 23);
            this.btnSaveBin.TabIndex = 1;
            this.btnSaveBin.Text = "Bin";
            this.btnSaveBin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Progress";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Load dictionary from file";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(406, 192);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 18);
            this.label21.TabIndex = 0;
            this.label21.Text = "Dictionary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Save dictionary to file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "English -> Russian dictionary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(574, 436);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(590, 474);
            this.MinimumSize = new System.Drawing.Size(590, 474);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "En->Ru dictionary";
            this.tabControl1.ResumeLayout(false);
            this.tabDictionary.ResumeLayout(false);
            this.tabDictionary.PerformLayout();
            this.tabWord.ResumeLayout(false);
            this.tabWord.PerformLayout();
            this.tabExam.ResumeLayout(false);
            this.tabExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trExamWordsRange)).EndInit();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            this.tabFile.ResumeLayout(false);
            this.tabFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExam;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TabPage tabWord;
        private System.Windows.Forms.TextBox tbRusWords;
        private System.Windows.Forms.TextBox tbEngWord;
        private System.Windows.Forms.Label lbTitleAddWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabFile;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabDictionary;
        private System.Windows.Forms.TextBox tbDictionary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExamStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbStatGrade;
        private System.Windows.Forms.Label lbStatWrongAns;
        private System.Windows.Forms.Label lbStatRightAns;
        private System.Windows.Forms.Label lbStatWords;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnLoadBin;
        private System.Windows.Forms.Button btnSaveBin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbExamRusWord;
        private System.Windows.Forms.Button btnExamContinue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbExamEngWord;
        private System.Windows.Forms.Label lbExamProgress;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDelDict;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbFileInfo;
        private System.Windows.Forms.Label lbExamInfo;
        private System.Windows.Forms.RadioButton rbAdj;
        private System.Windows.Forms.RadioButton rbVerb;
        private System.Windows.Forms.RadioButton rbNoun;
        private System.Windows.Forms.RadioButton rbNA;
        private System.Windows.Forms.Label lbStatNA;
        private System.Windows.Forms.Label lbStatVerb;
        private System.Windows.Forms.Label lbStatAdjective;
        private System.Windows.Forms.Label lbStatNoun;
        private System.Windows.Forms.TextBox tbExamResults;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.TextBox tbEngWordDelete;
        private System.Windows.Forms.Label lbTitleDeleteWord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trExamWordsRange;
        private System.Windows.Forms.Label lbExamWordsCount;
        private System.Windows.Forms.Button btnResetProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAvgRusWord;
        private System.Windows.Forms.Label lbAvgEngWord;
    }
}

