namespace Lab3
{
    partial class Form2
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
            mainForm.acceptDisposeOptionsForm();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lPointWidth = new System.Windows.Forms.Label();
            this.tbPointWidth = new System.Windows.Forms.TrackBar();
            this.lLineWidth = new System.Windows.Forms.Label();
            this.tbLineWidth = new System.Windows.Forms.TrackBar();
            this.lPointColor = new System.Windows.Forms.Label();
            this.colorDialogPoint = new System.Windows.Forms.ColorDialog();
            this.btnPointColor = new System.Windows.Forms.Button();
            this.lRealPointColor = new System.Windows.Forms.Label();
            this.lRealLineColor = new System.Windows.Forms.Label();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.lLineColor = new System.Windows.Forms.Label();
            this.lRealFillColor = new System.Windows.Forms.Label();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.lFillColor = new System.Windows.Forms.Label();
            this.colorDialogLine = new System.Windows.Forms.ColorDialog();
            this.colorDialogFill = new System.Windows.Forms.ColorDialog();
            this.chbRandMoveMode = new System.Windows.Forms.CheckBox();
            this.tbInitMoveX = new System.Windows.Forms.TrackBar();
            this.lInitMoveX = new System.Windows.Forms.Label();
            this.tbInitMoveY = new System.Windows.Forms.TrackBar();
            this.lInitMoveY = new System.Windows.Forms.Label();
            this.tbInitMoveSpeed = new System.Windows.Forms.TrackBar();
            this.lInitMoveSpeed = new System.Windows.Forms.Label();
            this.gbSizeColor = new System.Windows.Forms.GroupBox();
            this.gbInitialMoveSpeed = new System.Windows.Forms.GroupBox();
            this.rbSquarePoint = new System.Windows.Forms.RadioButton();
            this.rbRoundPoint = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbPointWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInitMoveX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInitMoveY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInitMoveSpeed)).BeginInit();
            this.gbSizeColor.SuspendLayout();
            this.gbInitialMoveSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // lPointWidth
            // 
            this.lPointWidth.AutoSize = true;
            this.lPointWidth.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPointWidth.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lPointWidth.Location = new System.Drawing.Point(13, 38);
            this.lPointWidth.Name = "lPointWidth";
            this.lPointWidth.Size = new System.Drawing.Size(113, 19);
            this.lPointWidth.TabIndex = 0;
            this.lPointWidth.Text = "Point size       50";
            // 
            // tbPointWidth
            // 
            this.tbPointWidth.LargeChange = 4;
            this.tbPointWidth.Location = new System.Drawing.Point(128, 38);
            this.tbPointWidth.Maximum = 50;
            this.tbPointWidth.Name = "tbPointWidth";
            this.tbPointWidth.Size = new System.Drawing.Size(420, 45);
            this.tbPointWidth.TabIndex = 1;
            // 
            // lLineWidth
            // 
            this.lLineWidth.AutoSize = true;
            this.lLineWidth.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLineWidth.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lLineWidth.Location = new System.Drawing.Point(13, 81);
            this.lLineWidth.Name = "lLineWidth";
            this.lLineWidth.Size = new System.Drawing.Size(114, 19);
            this.lLineWidth.TabIndex = 2;
            this.lLineWidth.Text = "Line width     50";
            // 
            // tbLineWidth
            // 
            this.tbLineWidth.LargeChange = 4;
            this.tbLineWidth.Location = new System.Drawing.Point(128, 81);
            this.tbLineWidth.Maximum = 50;
            this.tbLineWidth.Minimum = 1;
            this.tbLineWidth.Name = "tbLineWidth";
            this.tbLineWidth.Size = new System.Drawing.Size(420, 45);
            this.tbLineWidth.TabIndex = 3;
            this.tbLineWidth.Value = 1;
            // 
            // lPointColor
            // 
            this.lPointColor.AutoSize = true;
            this.lPointColor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPointColor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lPointColor.Location = new System.Drawing.Point(13, 133);
            this.lPointColor.Name = "lPointColor";
            this.lPointColor.Size = new System.Drawing.Size(84, 19);
            this.lPointColor.TabIndex = 4;
            this.lPointColor.Text = "Point color";
            // 
            // btnPointColor
            // 
            this.btnPointColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPointColor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPointColor.Location = new System.Drawing.Point(136, 130);
            this.btnPointColor.Name = "btnPointColor";
            this.btnPointColor.Size = new System.Drawing.Size(90, 26);
            this.btnPointColor.TabIndex = 5;
            this.btnPointColor.Text = "Change";
            this.btnPointColor.UseVisualStyleBackColor = true;
            // 
            // lRealPointColor
            // 
            this.lRealPointColor.AutoSize = true;
            this.lRealPointColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lRealPointColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lRealPointColor.Location = new System.Drawing.Point(103, 133);
            this.lRealPointColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.lRealPointColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.lRealPointColor.Name = "lRealPointColor";
            this.lRealPointColor.Size = new System.Drawing.Size(20, 20);
            this.lRealPointColor.TabIndex = 6;
            // 
            // lRealLineColor
            // 
            this.lRealLineColor.AutoSize = true;
            this.lRealLineColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lRealLineColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lRealLineColor.Location = new System.Drawing.Point(103, 169);
            this.lRealLineColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.lRealLineColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.lRealLineColor.Name = "lRealLineColor";
            this.lRealLineColor.Size = new System.Drawing.Size(20, 20);
            this.lRealLineColor.TabIndex = 9;
            // 
            // btnLineColor
            // 
            this.btnLineColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLineColor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLineColor.Location = new System.Drawing.Point(136, 166);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(90, 26);
            this.btnLineColor.TabIndex = 8;
            this.btnLineColor.Text = "Change";
            this.btnLineColor.UseVisualStyleBackColor = true;
            // 
            // lLineColor
            // 
            this.lLineColor.AutoSize = true;
            this.lLineColor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLineColor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lLineColor.Location = new System.Drawing.Point(13, 169);
            this.lLineColor.Name = "lLineColor";
            this.lLineColor.Size = new System.Drawing.Size(76, 19);
            this.lLineColor.TabIndex = 7;
            this.lLineColor.Text = "Line color";
            // 
            // lRealFillColor
            // 
            this.lRealFillColor.AutoSize = true;
            this.lRealFillColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lRealFillColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lRealFillColor.Location = new System.Drawing.Point(103, 205);
            this.lRealFillColor.MaximumSize = new System.Drawing.Size(20, 20);
            this.lRealFillColor.MinimumSize = new System.Drawing.Size(20, 20);
            this.lRealFillColor.Name = "lRealFillColor";
            this.lRealFillColor.Size = new System.Drawing.Size(20, 20);
            this.lRealFillColor.TabIndex = 12;
            // 
            // btnFillColor
            // 
            this.btnFillColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillColor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnFillColor.Location = new System.Drawing.Point(136, 202);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(90, 26);
            this.btnFillColor.TabIndex = 11;
            this.btnFillColor.Text = "Change";
            this.btnFillColor.UseVisualStyleBackColor = true;
            // 
            // lFillColor
            // 
            this.lFillColor.AutoSize = true;
            this.lFillColor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFillColor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lFillColor.Location = new System.Drawing.Point(13, 205);
            this.lFillColor.Name = "lFillColor";
            this.lFillColor.Size = new System.Drawing.Size(67, 19);
            this.lFillColor.TabIndex = 10;
            this.lFillColor.Text = "Fill color";
            // 
            // chbRandMoveMode
            // 
            this.chbRandMoveMode.AutoSize = true;
            this.chbRandMoveMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbRandMoveMode.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbRandMoveMode.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chbRandMoveMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbRandMoveMode.Location = new System.Drawing.Point(13, 174);
            this.chbRandMoveMode.Name = "chbRandMoveMode";
            this.chbRandMoveMode.Size = new System.Drawing.Size(130, 23);
            this.chbRandMoveMode.TabIndex = 14;
            this.chbRandMoveMode.Text = "Random speed";
            this.chbRandMoveMode.UseVisualStyleBackColor = true;
            // 
            // tbInitMoveX
            // 
            this.tbInitMoveX.LargeChange = 1;
            this.tbInitMoveX.Location = new System.Drawing.Point(128, 37);
            this.tbInitMoveX.Maximum = 5;
            this.tbInitMoveX.Minimum = -5;
            this.tbInitMoveX.Name = "tbInitMoveX";
            this.tbInitMoveX.Size = new System.Drawing.Size(420, 45);
            this.tbInitMoveX.TabIndex = 16;
            this.tbInitMoveX.Value = -5;
            // 
            // lInitMoveX
            // 
            this.lInitMoveX.AutoSize = true;
            this.lInitMoveX.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lInitMoveX.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lInitMoveX.Location = new System.Drawing.Point(13, 37);
            this.lInitMoveX.Name = "lInitMoveX";
            this.lInitMoveX.Size = new System.Drawing.Size(104, 19);
            this.lInitMoveX.TabIndex = 15;
            this.lInitMoveX.Text = "Speed X           5";
            // 
            // tbInitMoveY
            // 
            this.tbInitMoveY.LargeChange = 1;
            this.tbInitMoveY.Location = new System.Drawing.Point(128, 80);
            this.tbInitMoveY.Maximum = 5;
            this.tbInitMoveY.Minimum = -5;
            this.tbInitMoveY.Name = "tbInitMoveY";
            this.tbInitMoveY.Size = new System.Drawing.Size(420, 45);
            this.tbInitMoveY.TabIndex = 18;
            this.tbInitMoveY.Value = -5;
            // 
            // lInitMoveY
            // 
            this.lInitMoveY.AutoSize = true;
            this.lInitMoveY.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lInitMoveY.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lInitMoveY.Location = new System.Drawing.Point(13, 80);
            this.lInitMoveY.Name = "lInitMoveY";
            this.lInitMoveY.Size = new System.Drawing.Size(104, 19);
            this.lInitMoveY.TabIndex = 17;
            this.lInitMoveY.Text = "Speed Y           5";
            // 
            // tbInitMoveSpeed
            // 
            this.tbInitMoveSpeed.LargeChange = 2;
            this.tbInitMoveSpeed.Location = new System.Drawing.Point(128, 123);
            this.tbInitMoveSpeed.Maximum = 20;
            this.tbInitMoveSpeed.Minimum = 1;
            this.tbInitMoveSpeed.Name = "tbInitMoveSpeed";
            this.tbInitMoveSpeed.Size = new System.Drawing.Size(420, 45);
            this.tbInitMoveSpeed.TabIndex = 20;
            this.tbInitMoveSpeed.Value = 1;
            // 
            // lInitMoveSpeed
            // 
            this.lInitMoveSpeed.AutoSize = true;
            this.lInitMoveSpeed.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lInitMoveSpeed.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lInitMoveSpeed.Location = new System.Drawing.Point(13, 123);
            this.lInitMoveSpeed.Name = "lInitMoveSpeed";
            this.lInitMoveSpeed.Size = new System.Drawing.Size(103, 19);
            this.lInitMoveSpeed.TabIndex = 19;
            this.lInitMoveSpeed.Text = "General           5";
            // 
            // gbSizeColor
            // 
            this.gbSizeColor.Controls.Add(this.rbRoundPoint);
            this.gbSizeColor.Controls.Add(this.rbSquarePoint);
            this.gbSizeColor.Controls.Add(this.tbPointWidth);
            this.gbSizeColor.Controls.Add(this.lPointWidth);
            this.gbSizeColor.Controls.Add(this.lLineWidth);
            this.gbSizeColor.Controls.Add(this.tbLineWidth);
            this.gbSizeColor.Controls.Add(this.lPointColor);
            this.gbSizeColor.Controls.Add(this.btnPointColor);
            this.gbSizeColor.Controls.Add(this.lRealPointColor);
            this.gbSizeColor.Controls.Add(this.lLineColor);
            this.gbSizeColor.Controls.Add(this.lRealFillColor);
            this.gbSizeColor.Controls.Add(this.btnLineColor);
            this.gbSizeColor.Controls.Add(this.btnFillColor);
            this.gbSizeColor.Controls.Add(this.lRealLineColor);
            this.gbSizeColor.Controls.Add(this.lFillColor);
            this.gbSizeColor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSizeColor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gbSizeColor.Location = new System.Drawing.Point(12, 14);
            this.gbSizeColor.Name = "gbSizeColor";
            this.gbSizeColor.Size = new System.Drawing.Size(560, 243);
            this.gbSizeColor.TabIndex = 21;
            this.gbSizeColor.TabStop = false;
            this.gbSizeColor.Text = "Size and color";
            // 
            // gbInitialMoveSpeed
            // 
            this.gbInitialMoveSpeed.Controls.Add(this.tbInitMoveSpeed);
            this.gbInitialMoveSpeed.Controls.Add(this.lInitMoveX);
            this.gbInitialMoveSpeed.Controls.Add(this.chbRandMoveMode);
            this.gbInitialMoveSpeed.Controls.Add(this.lInitMoveSpeed);
            this.gbInitialMoveSpeed.Controls.Add(this.tbInitMoveX);
            this.gbInitialMoveSpeed.Controls.Add(this.tbInitMoveY);
            this.gbInitialMoveSpeed.Controls.Add(this.lInitMoveY);
            this.gbInitialMoveSpeed.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbInitialMoveSpeed.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.gbInitialMoveSpeed.Location = new System.Drawing.Point(12, 273);
            this.gbInitialMoveSpeed.Name = "gbInitialMoveSpeed";
            this.gbInitialMoveSpeed.Size = new System.Drawing.Size(560, 214);
            this.gbInitialMoveSpeed.TabIndex = 22;
            this.gbInitialMoveSpeed.TabStop = false;
            this.gbInitialMoveSpeed.Text = "Initial point move speed";
            // 
            // rbSquarePoint
            // 
            this.rbSquarePoint.AutoSize = true;
            this.rbSquarePoint.Location = new System.Drawing.Point(265, 131);
            this.rbSquarePoint.Name = "rbSquarePoint";
            this.rbSquarePoint.Size = new System.Drawing.Size(115, 23);
            this.rbSquarePoint.TabIndex = 13;
            this.rbSquarePoint.TabStop = true;
            this.rbSquarePoint.Text = "Square point";
            this.rbSquarePoint.UseVisualStyleBackColor = true;
            // 
            // rbRoundPoint
            // 
            this.rbRoundPoint.AutoSize = true;
            this.rbRoundPoint.Location = new System.Drawing.Point(407, 131);
            this.rbRoundPoint.Name = "rbRoundPoint";
            this.rbRoundPoint.Size = new System.Drawing.Size(113, 23);
            this.rbRoundPoint.TabIndex = 14;
            this.rbRoundPoint.TabStop = true;
            this.rbRoundPoint.Text = "Round point";
            this.rbRoundPoint.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 502);
            this.Controls.Add(this.gbInitialMoveSpeed);
            this.Controls.Add(this.gbSizeColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(750, 0);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.tbPointWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInitMoveX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInitMoveY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInitMoveSpeed)).EndInit();
            this.gbSizeColor.ResumeLayout(false);
            this.gbSizeColor.PerformLayout();
            this.gbInitialMoveSpeed.ResumeLayout(false);
            this.gbInitialMoveSpeed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lPointWidth;
        private System.Windows.Forms.TrackBar tbPointWidth;
        private System.Windows.Forms.Label lLineWidth;
        private System.Windows.Forms.TrackBar tbLineWidth;
        private System.Windows.Forms.Label lPointColor;
        private System.Windows.Forms.ColorDialog colorDialogPoint;
        private System.Windows.Forms.Button btnPointColor;
        private System.Windows.Forms.Label lRealPointColor;
        private System.Windows.Forms.Label lRealLineColor;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.Label lLineColor;
        private System.Windows.Forms.Label lRealFillColor;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Label lFillColor;
        private System.Windows.Forms.ColorDialog colorDialogLine;
        private System.Windows.Forms.ColorDialog colorDialogFill;
        private System.Windows.Forms.CheckBox chbRandMoveMode;
        private System.Windows.Forms.TrackBar tbInitMoveX;
        private System.Windows.Forms.Label lInitMoveX;
        private System.Windows.Forms.TrackBar tbInitMoveY;
        private System.Windows.Forms.Label lInitMoveY;
        private System.Windows.Forms.TrackBar tbInitMoveSpeed;
        private System.Windows.Forms.Label lInitMoveSpeed;
        private System.Windows.Forms.GroupBox gbSizeColor;
        private System.Windows.Forms.GroupBox gbInitialMoveSpeed;
        private System.Windows.Forms.RadioButton rbRoundPoint;
        private System.Windows.Forms.RadioButton rbSquarePoint;
    }
}