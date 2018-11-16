using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 MainForm)
        {
            this.mainForm = MainForm;

            InitializeComponent();

            // Size and color
            lPointWidth.Text = "Point size       " + mainForm.getPointWidth();
            tbPointWidth.Value = mainForm.getPointWidth();

            lLineWidth.Text = "Line width     " + mainForm.getLineWidth();
            tbLineWidth.Value = mainForm.getLineWidth();

            lRealPointColor.BackColor = mainForm.getPointColor();
            colorDialogPoint.Color = mainForm.getPointColor();

            lRealLineColor.BackColor = mainForm.getLineColor();
            colorDialogLine.Color = mainForm.getLineColor();

            lRealFillColor.BackColor = mainForm.getFillColor();
            colorDialogFill.Color = mainForm.getFillColor();

            if (MainForm.getSquarePoint())
            {
                rbSquarePoint.Checked = true;
            }
            else
            {
                rbRoundPoint.Checked = true;
            }


            //Speed
            lInitMoveX.Text = "Speed X           " + mainForm.getInitMoveX();
            tbInitMoveX.Minimum = Form1.INIT_STEP_X_MIN;
            tbInitMoveX.Maximum = Form1.INIT_STEP_X_MAX;
            tbInitMoveX.Value = mainForm.getInitMoveX();

            lInitMoveY.Text = "Speed Y           " + mainForm.getInitMoveY();
            tbInitMoveY.Minimum = Form1.INIT_STEP_Y_MIN;
            tbInitMoveY.Maximum = Form1.INIT_STEP_Y_MAX;
            tbInitMoveY.Value = mainForm.getInitMoveY();

            lInitMoveSpeed.Text = "General           " + mainForm.getInitMoveSpeed();
            tbInitMoveSpeed.Minimum = (int)(Form1.INIT_SPEED_MIN * 2);
            tbInitMoveSpeed.Maximum = (int)(Form1.INIT_SPEED_MAX * 2);
            tbInitMoveSpeed.Value = mainForm.getInitMoveSpeed();

            chbRandMoveMode.Checked = mainForm.getModeMovePointsRandom();

            // handlers

            #region Width
            tbPointWidth.ValueChanged += (o, e) =>
            {
                lPointWidth.Text = "Point size       " + tbPointWidth.Value;
                mainForm.setPointWidth(tbPointWidth.Value);
                mainForm.Refresh();
            };

            tbLineWidth.ValueChanged += (o, e) =>
            {
                lLineWidth.Text = "Line width     " + tbLineWidth.Value;
                mainForm.setLineWidth(tbLineWidth.Value);
                mainForm.Refresh();
            };
            #endregion

            #region Color
            btnPointColor.Click += (o, e) =>
            {
                if (colorDialogPoint.ShowDialog() == DialogResult.OK)
                {
                    lRealPointColor.BackColor = colorDialogPoint.Color;
                    mainForm.setPointColor(colorDialogPoint.Color);
                    mainForm.Refresh();
                }
            };

            btnLineColor.Click += (o, e) =>
            {
                if (colorDialogLine.ShowDialog() == DialogResult.OK)
                {
                    lRealLineColor.BackColor = colorDialogLine.Color;
                    mainForm.setLineColor(colorDialogLine.Color);
                    mainForm.Refresh();
                }
            };

            btnFillColor.Click += (o, e) =>
            {
                if (colorDialogFill.ShowDialog() == DialogResult.OK)
                {
                    lRealFillColor.BackColor = colorDialogFill.Color;
                    mainForm.setFillColor(colorDialogFill.Color);
                    mainForm.Refresh();
                }
            };
            #endregion

            #region Speed
            tbInitMoveX.ValueChanged += (o, e) =>
            {
                lInitMoveX.Text = "Speed X           " + tbInitMoveX.Value;
                MainForm.setInitMoveX(tbInitMoveX.Value);
            };

            tbInitMoveY.ValueChanged += (o, e) =>
            {
                lInitMoveY.Text = "Speed Y           " + tbInitMoveY.Value;
                MainForm.setInitMoveY(tbInitMoveY.Value);
            };

            tbInitMoveSpeed.ValueChanged += (o, e) =>
            {
                lInitMoveSpeed.Text = "General           " + tbInitMoveSpeed.Value;
                MainForm.setInitMoveSpeed(tbInitMoveSpeed.Value);
            };
            #endregion

            chbRandMoveMode.Click += (o, e) =>
            {
                if (chbRandMoveMode.Checked)
                {
                    mainForm.setModeMovePointsRandom(true);
                }
                else
                {
                    mainForm.setModeMovePointsRandom(false);
                }
                
            };

            rbSquarePoint.CheckedChanged += (o, e) => 
            {
                if (rbSquarePoint.Checked)
                {
                    mainForm.setSquarePoint(true);
                }
                else
                {
                    mainForm.setSquarePoint(false);
                }
                mainForm.Refresh();
            };

            rbRoundPoint.CheckedChanged += (o, e) =>
            {
                if (rbRoundPoint.Checked)
                {
                    mainForm.setSquarePoint(false);
                }
                else
                {
                    mainForm.setSquarePoint(true);
                }
                mainForm.Refresh();
            };

        }

       
    }
}
