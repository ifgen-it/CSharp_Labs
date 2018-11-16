namespace Lab3
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
            this.btnPoints = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnClosedCurve = new System.Windows.Forms.Button();
            this.btnPolygone = new System.Windows.Forms.Button();
            this.btnBeziers = new System.Windows.Forms.Button();
            this.btnFilledCurve = new System.Windows.Forms.Button();
            this.btnMovePoints = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbStatusBar = new System.Windows.Forms.TextBox();
            this.btnOnlyPoints = new System.Windows.Forms.Button();
            this.lMousePosition = new System.Windows.Forms.Label();
            this.lPointsCount = new System.Windows.Forms.Label();
            this.btnSpeedDown = new System.Windows.Forms.Button();
            this.btnSpeedUp = new System.Windows.Forms.Button();
            this.btnAllRandom = new System.Windows.Forms.Button();
            this.chbSingleRandom = new System.Windows.Forms.CheckBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPoints
            // 
            this.btnPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoints.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoints.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPoints.Location = new System.Drawing.Point(48, 12);
            this.btnPoints.Name = "btnPoints";
            this.btnPoints.Size = new System.Drawing.Size(144, 30);
            this.btnPoints.TabIndex = 0;
            this.btnPoints.Text = "Add points: OFF";
            this.btnPoints.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOptions.Location = new System.Drawing.Point(12, 440);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(180, 30);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnClosedCurve
            // 
            this.btnClosedCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosedCurve.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosedCurve.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnClosedCurve.Location = new System.Drawing.Point(12, 134);
            this.btnClosedCurve.Name = "btnClosedCurve";
            this.btnClosedCurve.Size = new System.Drawing.Size(180, 30);
            this.btnClosedCurve.TabIndex = 2;
            this.btnClosedCurve.Text = "Closed curve: OFF";
            this.btnClosedCurve.UseVisualStyleBackColor = true;
            // 
            // btnPolygone
            // 
            this.btnPolygone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPolygone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolygone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPolygone.Location = new System.Drawing.Point(12, 98);
            this.btnPolygone.Name = "btnPolygone";
            this.btnPolygone.Size = new System.Drawing.Size(180, 30);
            this.btnPolygone.TabIndex = 3;
            this.btnPolygone.Text = "Polygone curve: OFF";
            this.btnPolygone.UseVisualStyleBackColor = true;
            // 
            // btnBeziers
            // 
            this.btnBeziers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeziers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeziers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnBeziers.Location = new System.Drawing.Point(12, 170);
            this.btnBeziers.Name = "btnBeziers";
            this.btnBeziers.Size = new System.Drawing.Size(180, 30);
            this.btnBeziers.TabIndex = 4;
            this.btnBeziers.Text = "Bezier curve: OFF";
            this.btnBeziers.UseVisualStyleBackColor = true;
            // 
            // btnFilledCurve
            // 
            this.btnFilledCurve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilledCurve.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilledCurve.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFilledCurve.Location = new System.Drawing.Point(12, 206);
            this.btnFilledCurve.Name = "btnFilledCurve";
            this.btnFilledCurve.Size = new System.Drawing.Size(180, 30);
            this.btnFilledCurve.TabIndex = 5;
            this.btnFilledCurve.Text = "Filled curve: OFF";
            this.btnFilledCurve.UseVisualStyleBackColor = true;
            // 
            // btnMovePoints
            // 
            this.btnMovePoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovePoints.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovePoints.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnMovePoints.Location = new System.Drawing.Point(12, 258);
            this.btnMovePoints.Name = "btnMovePoints";
            this.btnMovePoints.Size = new System.Drawing.Size(180, 30);
            this.btnMovePoints.TabIndex = 6;
            this.btnMovePoints.Text = "Move points: OFF";
            this.btnMovePoints.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(12, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tbStatusBar
            // 
            this.tbStatusBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbStatusBar.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbStatusBar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbStatusBar.Location = new System.Drawing.Point(12, 550);
            this.tbStatusBar.MaximumSize = new System.Drawing.Size(180, 300);
            this.tbStatusBar.Multiline = true;
            this.tbStatusBar.Name = "tbStatusBar";
            this.tbStatusBar.ReadOnly = true;
            this.tbStatusBar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbStatusBar.Size = new System.Drawing.Size(180, 100);
            this.tbStatusBar.TabIndex = 9;
            // 
            // btnOnlyPoints
            // 
            this.btnOnlyPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnlyPoints.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlyPoints.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOnlyPoints.Location = new System.Drawing.Point(12, 62);
            this.btnOnlyPoints.Name = "btnOnlyPoints";
            this.btnOnlyPoints.Size = new System.Drawing.Size(180, 30);
            this.btnOnlyPoints.TabIndex = 10;
            this.btnOnlyPoints.Text = "Only points: ON";
            this.btnOnlyPoints.UseVisualStyleBackColor = true;
            // 
            // lMousePosition
            // 
            this.lMousePosition.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMousePosition.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lMousePosition.Location = new System.Drawing.Point(77, 517);
            this.lMousePosition.Name = "lMousePosition";
            this.lMousePosition.Size = new System.Drawing.Size(115, 23);
            this.lMousePosition.TabIndex = 11;
            this.lMousePosition.Text = "Mouse";
            this.lMousePosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lPointsCount
            // 
            this.lPointsCount.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPointsCount.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lPointsCount.Location = new System.Drawing.Point(12, 517);
            this.lPointsCount.Name = "lPointsCount";
            this.lPointsCount.Size = new System.Drawing.Size(59, 23);
            this.lPointsCount.TabIndex = 12;
            this.lPointsCount.Text = "[ 0 ]";
            this.lPointsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSpeedDown
            // 
            this.btnSpeedDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeedDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedDown.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSpeedDown.Location = new System.Drawing.Point(152, 386);
            this.btnSpeedDown.Name = "btnSpeedDown";
            this.btnSpeedDown.Size = new System.Drawing.Size(40, 30);
            this.btnSpeedDown.TabIndex = 13;
            this.btnSpeedDown.Text = "-";
            this.btnSpeedDown.UseVisualStyleBackColor = true;
            // 
            // btnSpeedUp
            // 
            this.btnSpeedUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpeedUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeedUp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSpeedUp.Location = new System.Drawing.Point(152, 350);
            this.btnSpeedUp.Name = "btnSpeedUp";
            this.btnSpeedUp.Size = new System.Drawing.Size(40, 30);
            this.btnSpeedUp.TabIndex = 14;
            this.btnSpeedUp.Text = "+";
            this.btnSpeedUp.UseVisualStyleBackColor = true;
            // 
            // btnAllRandom
            // 
            this.btnAllRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllRandom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllRandom.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAllRandom.Location = new System.Drawing.Point(112, 294);
            this.btnAllRandom.Name = "btnAllRandom";
            this.btnAllRandom.Size = new System.Drawing.Size(80, 30);
            this.btnAllRandom.TabIndex = 15;
            this.btnAllRandom.Text = "Random";
            this.btnAllRandom.UseVisualStyleBackColor = true;
            // 
            // chbSingleRandom
            // 
            this.chbSingleRandom.AutoSize = true;
            this.chbSingleRandom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbSingleRandom.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbSingleRandom.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chbSingleRandom.Location = new System.Drawing.Point(27, 298);
            this.chbSingleRandom.Name = "chbSingleRandom";
            this.chbSingleRandom.Size = new System.Drawing.Size(70, 23);
            this.chbSingleRandom.TabIndex = 17;
            this.chbSingleRandom.Text = "Single";
            this.chbSingleRandom.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLeft.Location = new System.Drawing.Point(12, 386);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 30);
            this.btnLeft.TabIndex = 19;
            this.btnLeft.Text = "L";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDown.Location = new System.Drawing.Point(58, 386);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 30);
            this.btnDown.TabIndex = 20;
            this.btnDown.Text = "D";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnRight.Location = new System.Drawing.Point(104, 386);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 30);
            this.btnRight.TabIndex = 21;
            this.btnRight.Text = "R";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnUp.Location = new System.Drawing.Point(58, 350);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 30);
            this.btnUp.TabIndex = 22;
            this.btnUp.Text = "U";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTest.Location = new System.Drawing.Point(12, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(30, 30);
            this.btnTest.TabIndex = 23;
            this.btnTest.Text = "T";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(734, 662);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnSpeedUp);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnSpeedDown);
            this.Controls.Add(this.lPointsCount);
            this.Controls.Add(this.btnAllRandom);
            this.Controls.Add(this.chbSingleRandom);
            this.Controls.Add(this.lMousePosition);
            this.Controls.Add(this.btnOnlyPoints);
            this.Controls.Add(this.tbStatusBar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMovePoints);
            this.Controls.Add(this.btnFilledCurve);
            this.Controls.Add(this.btnBeziers);
            this.Controls.Add(this.btnPolygone);
            this.Controls.Add(this.btnClosedCurve);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnPoints);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            // this.MaximumSize = new System.Drawing.Size(6000, 3000);
            this.MaximumSize = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
            this.MinimumSize = new System.Drawing.Size(400, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoints;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnClosedCurve;
        private System.Windows.Forms.Button btnPolygone;
        private System.Windows.Forms.Button btnBeziers;
        private System.Windows.Forms.Button btnFilledCurve;
        private System.Windows.Forms.Button btnMovePoints;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbStatusBar;
        private System.Windows.Forms.Button btnOnlyPoints;
        private System.Windows.Forms.Label lMousePosition;
        private System.Windows.Forms.Label lPointsCount;
        private System.Windows.Forms.Button btnSpeedDown;
        private System.Windows.Forms.Button btnSpeedUp;
        private System.Windows.Forms.Button btnAllRandom;
        private System.Windows.Forms.CheckBox chbSingleRandom;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnTest;
    }
}

