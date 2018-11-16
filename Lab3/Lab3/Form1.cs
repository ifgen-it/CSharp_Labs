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
    public partial class Form1 : Form
    {
        private Form1 form;
        private Form2 optionsForm;
        

        private PointF[] arPoints;
        private Direct[] moveDir;

        private int pointWidth = 14;
        private int lineWidth = 2;
        private int dragPointCapture = 14;
        private Color pointColor = Color.Fuchsia;
        private Color lineColor = Color.Blue;
        private Color fillColor = Color.FromArgb(255, 110, 34, 126);
        private bool squarePoint = true;

        private float deltaDragX;
        private float deltaDragY;

        private bool modeAddPoints = false;
        private bool modeDragPoint = false;
        private int draggingPoint;
        private bool modeMovePoints = false;
        

        private int leftMargin;
        private int rightMargin;
        private int topMargin;
        private int bottomMargin;

        private PointF mousePos;

        private string drawMode;

        private Timer moveTimer;


        private int moveInitStepX = 4;
        private int moveInitStepY = 4;
        private float moveInitSpeed = 0.5f;
        public const int INIT_STEP_X_MIN = -5;
        public const int INIT_STEP_X_MAX = 5;
        public const int INIT_STEP_Y_MIN = -5;
        public const int INIT_STEP_Y_MAX = 5;
        public const float INIT_SPEED_MIN = 0.5f;
        public const float INIT_SPEED_MAX = 10f;
        private bool modeMoveInitPointsRandom = false;

        private bool singleRandom = false;

        private float moveSpeedDelta = 0.5f;
        private float moveDxDelta = 2;
        private float moveDyDelta = 2;

        private int pointsCount;

        public Form1()
        {
            moveTimer = new Timer();
            moveTimer.Interval = 30;
            moveTimer.Tick += MoveTimer_Tick;
           
            arPoints = null;

            leftMargin = 200;
            rightMargin = 16;
            topMargin = 0;
            bottomMargin = 38;

            pointsCount = 0;

            drawMode = "drawPoints";
            form = this;

            InitializeComponent();

            // tool tips
            #region toolTips
            ToolTip tBtnTest = new ToolTip();
            tBtnTest.SetToolTip(btnTest, "Test - add many points in ON mode");

            ToolTip tBtnPoints = new ToolTip();
            tBtnPoints.SetToolTip(btnPoints, "ON/OFF - Use right mouse button. Delete point - middle MB. Move point - left MB in OFF mode");

            ToolTip tBtnMovePoints = new ToolTip();
            tBtnMovePoints.SetToolTip(btnMovePoints, "SPACE");

            ToolTip tBtnClear = new ToolTip();
            tBtnClear.SetToolTip(btnClear, "ESC");

            ToolTip tBtnSpeedUp = new ToolTip();
            tBtnSpeedUp.SetToolTip(btnSpeedUp, "NUM+");

            ToolTip tBtnSpeedDown = new ToolTip();
            tBtnSpeedDown.SetToolTip(btnSpeedDown, "NUM-");

            ToolTip tBtnLeft = new ToolTip();
            tBtnLeft.SetToolTip(btnLeft, "Arrow LEFT");

            ToolTip tBtnRight = new ToolTip();
            tBtnRight.SetToolTip(btnRight, "Arrow RIGHT");

            ToolTip tBtnUp = new ToolTip();
            tBtnUp.SetToolTip(btnUp, "Arrow UP");

            ToolTip tBtnDown = new ToolTip();
            tBtnDown.SetToolTip(btnDown, "Arrow DOWN");

            #endregion


            // handlers

            KeyPreview = true;
            KeyDown += Form1_KeyDown;

            

            Paint += Form1_Paint;

            MouseClick += Form1_MouseClick;
            MouseMove += Form1_MouseMove;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;


            btnSpeedUp.Click += BtnSpeedUp_Click;
            btnSpeedDown.Click += BtnSpeedDown_Click;
            btnAllRandom.Click += BtnAllRandom_Click;

            
            btnPoints.Click += BtnPoints_Click;

            
            btnTest.Click += (o, e) =>
            {
                if (modeAddPoints)
                {
                    setManyPoints();
                }
            };
            
            btnPolygone.Click += BtnPolygone_Click;
            btnOnlyPoints.Click += BtnOnlyPoints_Click;

            btnClear.Click += BtnMovePoints_Click;  // for stop moving
            btnClear.Click += BtnClear_Click;


            btnClosedCurve.Click += BtnClosedCurve_Click;
            btnBeziers.Click += BtnBeizers_Click;
            btnFilledCurve.Click += BtnFilledCurve_Click;
            btnMovePoints.Click += BtnMovePoints_Click;
            btnOptions.Click += BtnOptions_Click;

            btnLeft.Click += BtnLeft_Click;
            btnRight.Click += BtnRight_Click;
            btnUp.Click += BtnUp_Click;
            btnDown.Click += BtnDown_Click;

            chbSingleRandom.Checked = false;

            chbSingleRandom.Click += (o, e) =>
            {
                if (chbSingleRandom.Checked)
                {
                    singleRandom = true;
                }
                else
                {
                    singleRandom = false;
                }

            };
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            if (modeMovePoints)
            {
                updateMoveDir(0, 0, moveDyDelta);
                cout("Speed DOWN");
            }
            else
            {
                if (MoveStaticPoints(0, moveDyDelta))
                {
                    cout("Move to the DOWN");
                    Refresh();
                }
                else
                    cout("Moving stopped");
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            if (modeMovePoints)
            {
                updateMoveDir(0, 0, -moveDyDelta);
                cout("Speed UP");
            }
            else
            {
                if (MoveStaticPoints(0, -moveDyDelta))
                {
                    cout("Move to the UP");
                    Refresh();
                }
                else
                    cout("Moving stopped");
            }
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (modeMovePoints)
            {
                updateMoveDir(0, moveDxDelta, 0);
                cout("Speed RIGHT");
            }
            else
            {
                if (MoveStaticPoints(moveDxDelta, 0))
                {
                    cout("Move to the RIGHT");
                    Refresh();
                }
                else
                    cout("Moving stopped");
            }
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (modeMovePoints)
            {
                updateMoveDir(0, -moveDxDelta, 0);
                cout("Speed LEFT");
            }
            else
            {
                if (MoveStaticPoints(-moveDxDelta, 0))
                {
                    cout("Move to the LEFT");
                    Refresh();
                }
                else
                    cout("Moving stopped");
            }
        }

        private void BtnAllRandom_Click(object sender, EventArgs e)
        {
            if (modeMovePoints)
            {
                if (singleRandom)
                {
                    setRealRandomSpeedToAll();
                    cout("Speed random single");
                }
                else
                {
                    setRandomSpeedToAll();
                    cout("Speed random together");
                }
                
            }
            else
            {
                cout("Enable Move points!");
            }
        }

        private void BtnSpeedDown_Click(object sender, EventArgs e)
        {
            if (modeMovePoints)
            {
                updateMoveDir(-1, 0, 0);
                cout("Speed--");
            }
            else
            {
                cout("Enable Move points!");
            }
        }

        private void BtnSpeedUp_Click(object sender, EventArgs e)
        {
            if (modeMovePoints)
            {
                updateMoveDir(1, 0, 0);
                cout("Speed++");
            }
            else
            {
                cout("Enable Move points!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    //need Stop moving and then Clear

                    // Stop moving
                    if (modeMovePoints == true)
                    {
                        modeMovePoints = false;
                        btnMovePoints.Text = "Move points: OFF";
                        cout("Move points: OFF");
                        moveTimer.Stop();
                    }

                    // Clear
                    arPoints = null;
                    moveDir = null;
                    setPointsCount(-pointsCount);
                    cout("Cleared");
                    Refresh();

                    e.Handled = true;
                    break;

                case Keys.Add:
                    //need increase speed moving
                    if (modeMovePoints)
                    {
                        updateMoveDir(1, 0, 0);
                        cout("Speed++");
                    }
                    e.Handled = true;
                    break;

                case Keys.Subtract:
                    //need reduce speed moving
                    if (modeMovePoints)
                    {
                        updateMoveDir(-1, 0, 0);
                        cout("Speed--");
                    }
                    e.Handled = true;
                    break;


                default:
                    break;
            }
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MovePoints();
            Refresh();
        }

        

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            modeDragPoint = false;
            draggingPoint = -1;
            Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!modeAddPoints && e.Button == MouseButtons.Left && arPoints != null)
            {
                Point downPoint = e.Location;

                for (int i = 0; i < arPoints.Length; i++)
                {
                    if (IsOnPoint(downPoint,arPoints[i]))
                    {
                        draggingPoint = i;
                        modeDragPoint = true;
                        break;
                    }
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (modeAddPoints && e.Button == MouseButtons.Left)
            {
                PointF p1 = e.Location;
                
                float realX = p1.X;
                float realY = p1.Y;

                //checking for out of margin zone
                if (realX < leftMargin + pointWidth / 2) realX = leftMargin + pointWidth / 2;
                else if (realX > form.Width - rightMargin - pointWidth / 2) realX = form.Width - rightMargin - pointWidth / 2;

                if (realY < topMargin + pointWidth / 2) realY = topMargin + pointWidth / 2;
                else if (realY > form.Height - bottomMargin - pointWidth / 2) realY = form.Height - bottomMargin - pointWidth / 2;

                PointF realP1 = new PointF(realX, realY);
                cout(realP1.ToString() + " added");

                setPointsCount(1);

                if (arPoints == null)
                {
                    arPoints = new PointF[] {realP1 };

                    // create helper array for directions of points
                    if (modeMoveInitPointsRandom)
                    {
                        float InitSpeed = 0;
                        int InitX = 0;
                        int InitY = 0;
                        getRealRandomSpeed(new Random(), ref InitSpeed, ref InitX, ref InitY);

                        moveDir = new Direct[] { new Direct(InitSpeed, InitX, InitY) };
                    }
                    else
                    {
                        moveDir = new Direct[] { new Direct(moveInitSpeed, moveInitStepX, moveInitStepY) };
                    }

                    moveDir = new Direct[] { new Direct(moveInitSpeed, moveInitStepX, moveInitStepY) };

                }
                else
                {
                    PointF[] newArPoints = new PointF[arPoints.Length + 1];
                    newArPoints[arPoints.Length] = realP1;

                    for (int i = 0; i < arPoints.Length; i++)
                    {
                        newArPoints[i] = arPoints[i];
                    }
                    arPoints = newArPoints;

                    // update helper array for directions of points
                    Direct[] newMoveDir = new Direct[moveDir.Length + 1];

                    if (modeMoveInitPointsRandom)
                    {
                        float InitSpeed = 0;
                        int InitX = 0;
                        int InitY = 0;
                        getRealRandomSpeed(new Random(), ref InitSpeed, ref InitX, ref InitY);

                        newMoveDir[moveDir.Length] = new Direct(InitSpeed, InitX, InitY);
                    }
                    else
                    {
                        newMoveDir[moveDir.Length] = new Direct(moveInitSpeed, moveInitStepX, moveInitStepY);
                    }

                    // copying old values
                    for (int i = 0; i < moveDir.Length; i++)
                    {
                        newMoveDir[i] = moveDir[i];
                    }
                    moveDir = newMoveDir;

                }


                Refresh();
            }

            if (e.Button == MouseButtons.Right)
            {
                // ON/OFF modeAddPoints / dragPoints
                if (modeAddPoints == false)
                {
                    modeAddPoints = true;
                    btnPoints.Text = "Add points: ON";
                    cout("Add points: ON");
                    cout("Drag points: OFF");
                }
                else
                {
                    modeAddPoints = false;
                    btnPoints.Text = "Add points: OFF";
                    cout("Add points: OFF");
                    cout("Drag points: ON");
                }
            }

            if (e.Button == MouseButtons.Middle && arPoints != null)
            {
                PointF delPoint = e.Location;

                for (int i = 0; i < arPoints.Length; i++)
                {
                    if (IsOnPoint(delPoint, arPoints[i]))
                    {
                        PointF deletedPoint = new PointF(arPoints[i].X, arPoints[i].Y);

                        cout(deletedPoint.ToString() + " deleted");
                        deletePointFromArPoints(i);
                        setPointsCount(-1);

                        Refresh();
                        
                        break;
                    }
                }

            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
            lMousePosition.Text = mousePos.ToString();

            if (modeDragPoint)
            {
                float newPointX = mousePos.X + deltaDragX;
                float newPointY = mousePos.Y + deltaDragY;

                if (newPointX - pointWidth/2 >= leftMargin && newPointX + pointWidth/2 <= form.Width-rightMargin &&
                    newPointY - pointWidth/2 >= topMargin && newPointY + pointWidth/2 <= form.Height-bottomMargin)
                {
                    arPoints[draggingPoint] = new PointF(newPointX, newPointY);
                    Refresh();
                }
            }
        }




        private void BtnMovePoints_Click(object sender, EventArgs e)
        {
            if (modeMovePoints == false)
            {
                if (sender.Equals(btnMovePoints))
                {

                    if (arPoints == null)
                    {
                        cout("First add points!");
                        return;
                    }

                    modeMovePoints = true;
                    btnMovePoints.Text = "Move points: ON";
                    cout("Move points: ON");

                    moveTimer.Start();
                }
            }
            else
            {
                modeMovePoints = false;
                btnMovePoints.Text = "Move points: OFF";
                cout("Move points: OFF");

                moveTimer.Stop();
            }
        }

        private void BtnFilledCurve_Click(object sender, EventArgs e)
        {

            SetBtnFilledCurveOn();
            Refresh();
            
        }

        private void BtnBeizers_Click(object sender, EventArgs e)
        {

            SetBtnBezierOn();
            Refresh();
        }

        private void BtnClosedCurve_Click(object sender, EventArgs e)
        {

            SetBtnClosedCurveOn();
            Refresh();
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            
            arPoints = null;
            moveDir = null;

            setPointsCount(-pointsCount);
            cout("Cleared");
            Refresh();
        }

        private void BtnOnlyPoints_Click(object sender, EventArgs e)
        {
            SetBtnOnlyPointsOn();
            Refresh();
        }

        private void BtnPolygone_Click(object sender, EventArgs e)
        {
            SetBtnPolygoneOn();    
            Refresh();
        }

        private void BtnPoints_Click(object sender, EventArgs e)
        {
            if (modeAddPoints == false)
            {
                modeAddPoints = true;
                btnPoints.Text = "Add points: ON";
                cout("Add points: ON");
                cout("Drag points: OFF");
            }
            else
            {
                modeAddPoints = false;
                btnPoints.Text = "Add points: OFF";
                cout("Add points: OFF");
                cout("Drag points: ON");
            }
            
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            if (optionsForm == null)
            {
                optionsForm = new Form2(this);
                optionsForm.Show();
            }
            else
            {
                optionsForm.Activate();
            }

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            Brush fillBrush = new SolidBrush(fillColor);
            Pen linePen = new Pen(lineColor, lineWidth);

            switch (drawMode)
            {
                case "drawPolygone":
                    if (arPoints == null || arPoints.Length < 2)
                    {
                        break;
                    }
                    g.DrawPolygon(linePen, arPoints);
                    break;
                    
                case "drawClosedCurve":
                    if (arPoints == null || arPoints.Length < 3)
                    {
                        break;
                    }
                    g.DrawClosedCurve(linePen, arPoints);
                    break;

                case "drawFilledCurve":
                    if (arPoints == null)
                    {
                        break;
                    }
                    g.FillClosedCurve( fillBrush, arPoints);
                    break;

                case "drawBezierCurve":
                    if (arPoints == null) break;
                    int N = arPoints.Length;
                    if (N < 4)
                    {
                        break;
                    }
                    if ((N - 4) % 3 == 0)
                    {
                        g.DrawBeziers(linePen, arPoints);
                    }
                    else
                    {
                        // get size of new temp array of points
                        int newSize = ((N - 1) / 3) * 3 + 1;
                        PointF[] tempArPoints = new PointF[newSize];

                        for (int i = 0; i < tempArPoints.Length; i++)
                        {
                            tempArPoints[i] = new PointF(arPoints[i].X, arPoints[i].Y);
                        }

                        g.DrawBeziers(linePen, tempArPoints);

                    }
                    break;

                case "drawPoints":
                    if (arPoints == null)
                    {
                        break;
                    }
                    break;

                default:
                    cout("something wrong");
                    break;
            }


            // drawPoints
            if (arPoints != null)
            {
                Brush pointBrush = new SolidBrush(pointColor);

                for (int i = 0; i < arPoints.Length; i++)
                {
                    Point pt1 = new Point((int)(arPoints[i].X - pointWidth / 2), (int)(arPoints[i].Y - pointWidth / 2));
                    Rectangle r1 = new Rectangle(pt1, new Size(pointWidth, pointWidth));
                    if (modeDragPoint)
                    {
                        if (i == draggingPoint)
                        {
                            if (squarePoint)
                            {
                                g.FillRectangle(Brushes.LawnGreen, r1);
                            }
                            else
                            {
                                g.FillEllipse(Brushes.LawnGreen, r1);
                            }
                            
                        }
                        else
                        {
                            if (squarePoint)
                            {
                                g.FillRectangle(pointBrush, r1);
                            }
                            else
                            {
                                g.FillEllipse(pointBrush, r1);
                            }
                            
                        }
                    }
                    else
                    {
                        if (squarePoint)
                        {
                            g.FillRectangle(pointBrush, r1);
                        }
                        else
                        {
                            g.FillEllipse(pointBrush, r1);
                        }
                    }
                    
                }
            }

        }

        public void ShowMessage(string message)
        {
            string caption = "Attention";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        public void cout(string message)
        {
            tbStatusBar.AppendText(message + "\n"); 
        }

        public bool IsOnPoint(PointF downPoint, PointF p)
        {
            deltaDragX = p.X - downPoint.X;
            deltaDragY = p.Y - downPoint.Y;

            if (Math.Abs(deltaDragX) <= dragPointCapture / 2 &&
                Math.Abs(deltaDragY) <= dragPointCapture / 2)
            {
                return true;
            }
            else
                return false;
            
        }

        public void SetAllBtnOff()
        {
            btnOnlyPoints.Text = "Only points: OFF";
            btnPolygone.Text = "Polygone curve: OFF";
            btnClosedCurve.Text = "Closed curve: OFF";
            btnBeziers.Text = "Bezier curve: OFF";
            btnFilledCurve.Text = "Filled curve: OFF";
        }

        public void SetBtnFilledCurveOn()
        {
            drawMode = "drawFilledCurve";
            SetAllBtnOff();
            btnFilledCurve.Text = "Filled curve: ON";
            cout("Filled curve: ON");
        }

        public void SetBtnBezierOn()
        {
            drawMode = "drawBezierCurve";
            SetAllBtnOff();
            btnBeziers.Text = "Bezier curve: ON";
            cout("Bezier curve: ON");
        }

        public void SetBtnClosedCurveOn()
        {
            drawMode = "drawClosedCurve";
            SetAllBtnOff();
            btnClosedCurve.Text = "Closed curve: ON";
            cout("Closed curve: ON");
        }

        public void SetBtnOnlyPointsOn()
        {
            drawMode = "drawPoints";
            SetAllBtnOff();
            btnOnlyPoints.Text = "Only points: ON";
            cout("Only points: ON");
        }

        public void SetBtnPolygoneOn()
        {
            drawMode = "drawPolygone";
            SetAllBtnOff();
            btnPolygone.Text = "Polygone curve: ON";
            cout("Polygone curve: ON");
        }



        public void MovePoints()
        {
            if (arPoints == null)
            {
                cout("Error!");
                return;
            }


            for (int i = 0; i < arPoints.Length; i++)
            {
                // calculate actual borders
                int leftBorder = leftMargin + pointWidth / 2;
                int rightBorder = form.Width - rightMargin - pointWidth / 2;
                int topBorder = topMargin + pointWidth / 2;
                int bottomBorder = form.Height - bottomMargin - pointWidth / 2;

                float x = arPoints[i].X;
                float y = arPoints[i].Y;

                // move x
                x += moveDir[i].DX * moveDir[i].Speed;
                
                if (x > rightBorder)
                {
                    moveDir[i].DX = - Math.Abs(moveDir[i].DX);
                    if (moveDir[i].DX == 0) moveDir[i].DX = INIT_STEP_X_MIN;
                    arPoints[i] = new PointF(rightBorder, y);
                }
                else if (x < leftBorder)
                {
                    moveDir[i].DX = Math.Abs(moveDir[i].DX);
                    if (moveDir[i].DX == 0) moveDir[i].DX = INIT_STEP_X_MAX;
                    arPoints[i] = new PointF(leftBorder, y);
                }
                else
                {
                    arPoints[i] = new PointF(x, y);
                }

                // move y
                y += moveDir[i].DY * moveDir[i].Speed;
                if (y > bottomBorder)
                {
                    moveDir[i].DY = - Math.Abs(moveDir[i].DY);
                    if (moveDir[i].DY == 0) moveDir[i].DY = INIT_STEP_Y_MIN;
                    arPoints[i] = new PointF(x, bottomBorder);
                    
                }
                else if (y < topBorder)
                {
                    moveDir[i].DY = Math.Abs(moveDir[i].DY);
                    if (moveDir[i].DY == 0) moveDir[i].DY = INIT_STEP_Y_MAX;
                    arPoints[i] = new PointF(x, topBorder);
                }
                else
                {
                    arPoints[i] = new PointF(x, y);
                }

            }
        }
        
        public bool MoveStaticPoints(float moveDx, float moveDy)
        {
            //checking for could be any point out of bounds drawBox

            // calculate actual borders
            int leftBorder = leftMargin + pointWidth / 2;
            int rightBorder = form.Width - rightMargin - pointWidth / 2;
            int topBorder = topMargin + pointWidth / 2;
            int bottomBorder = form.Height - bottomMargin - pointWidth / 2;

            for (int i = 0; i < arPoints.Length; i++)
            {
                float x = arPoints[i].X + moveDx;
                float y = arPoints[i].Y + moveDy;
                if (x > rightBorder || x < leftBorder)
                {
                    return false;
                }
                if (y > bottomBorder || y < topBorder)
                {
                    return false;
                }
            }

            // all right, will move points

            for (int i = 0; i < arPoints.Length; i++)
            {
                float x = arPoints[i].X + moveDx;
                float y = arPoints[i].Y + moveDy;
                arPoints[i] = new PointF(x, y);
            }

            return true;
        }

        public void deletePointFromArPoints(int delInd)
        {
            if (arPoints == null || moveDir == null)
            {
                cout("Error");
                return;
            }

            //delete point from arPoints
            PointF[] newArPoints = new PointF[arPoints.Length - 1];

            for (int i = 0; i < delInd; i++)
            {
                newArPoints[i] = arPoints[i];
            }
            for (int i = delInd; i < newArPoints.Length; i++)
            {
                newArPoints[i] = arPoints[i + 1];
            }

            arPoints = newArPoints;
            if (arPoints.Length == 0) arPoints = null;

            //delete point from moveDir
            Direct[] newMoveDir = new Direct[moveDir.Length - 1];

            for (int i = 0; i < delInd; i++)
            {
                newMoveDir[i] = moveDir[i];
            }
            for (int i = delInd; i < newMoveDir.Length; i++)
            {
                newMoveDir[i] = moveDir[i + 1];
            }

            moveDir = newMoveDir;
            if (moveDir.Length == 0)
            {
                moveDir = null;
                if (modeMovePoints)
                {
                    modeMovePoints = false;
                    btnMovePoints.Text = "Move points: OFF";
                    cout("Move points: OFF");
                    moveTimer.Stop();
                }
            }
        }

        public void setPointsCount(int addCount)
        {
            pointsCount += addCount;
            lPointsCount.Text = "[ " + pointsCount.ToString() + " ]";
        }
       
        public void updateMoveDir(int coeffMoveSpeed, float moveDX, float moveDY)
        {

            for (int i = 0; i < moveDir.Length; i++)
            {
                
                moveDir[i].Speed += coeffMoveSpeed * moveSpeedDelta;
                moveDir[i].DX += moveDX;
                moveDir[i].DY += moveDY;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool isHandled = true;

            if (arPoints == null)
            {
                return isHandled;
            }

            switch (keyData)
            {

                case Keys.Space:
                    if (modeMovePoints == false)
                    {
                        if (arPoints == null)
                        {
                            cout("First add points!");
                            break;
                        }

                        modeMovePoints = true;
                        btnMovePoints.Text = "Move points: ON";
                        cout("Move points: ON");

                        moveTimer.Start();
                    }
                    else
                    {
                        modeMovePoints = false;
                        btnMovePoints.Text = "Move points: OFF";
                        cout("Move points: OFF");

                        moveTimer.Stop();
                    }

                    break;

                case Keys.Left:
                    if (modeMovePoints)
                    {
                        updateMoveDir(0, -moveDxDelta, 0);
                        cout("Speed LEFT");
                    }
                    else
                    {
                        if (MoveStaticPoints(-moveDxDelta, 0))
                        {
                            cout("Move to the LEFT");
                            Refresh();
                        }
                        else
                            cout("Moving stopped");
                    }
                    break;

                case Keys.Up:
                    if (modeMovePoints)
                    {
                        updateMoveDir(0, 0, -moveDyDelta);
                        cout("Speed UP");
                    }
                    else
                    {
                        if (MoveStaticPoints(0, -moveDyDelta))
                        {
                            cout("Move to the UP");
                            Refresh();
                        }
                        else
                            cout("Moving stopped");
                    }
                    break;

                case Keys.Right:
                    if (modeMovePoints)
                    {
                        updateMoveDir(0, moveDxDelta, 0);
                        cout("Speed RIGHT");
                    }
                    else
                    {
                        if (MoveStaticPoints(moveDxDelta, 0))
                        {
                            cout("Move to the RIGHT");
                            Refresh();
                        }
                        else
                            cout("Moving stopped");
                    }
                    break;

                case Keys.Down:
                    if (modeMovePoints)
                    {
                        updateMoveDir(0, 0, moveDyDelta);
                        cout("Speed DOWN");
                    }
                    else
                    {
                        if (MoveStaticPoints(0, moveDyDelta))
                        {
                            cout("Move to the DOWN");
                            Refresh();
                        }
                        else
                            cout("Moving stopped");
                    }
                    break;

                default:
                    isHandled = false;
                    break;
            }

            return isHandled;
        }

        public void acceptDisposeOptionsForm()
        {
            optionsForm = null;
        }

        public void setPointWidth(int PointW)
        {
            pointWidth = PointW;
            if (pointWidth < 10)
            {
                dragPointCapture = 10;
            }
            else
            {
                dragPointCapture = pointWidth;
            }
        }
        public int getPointWidth()
        {
            return pointWidth;
        }

        public void setLineWidth(int LineW)
        {
            lineWidth = LineW;
        }
        public int getLineWidth()
        {
            return lineWidth;
        }

        public void setPointColor(Color PointC)
        {
            pointColor = PointC;
        }
        public Color getPointColor()
        {
            return pointColor;
        }

        public void setLineColor(Color LineC)
        {
            lineColor = LineC;
        }
        public Color getLineColor()
        {
            return lineColor;
        }

        public void setFillColor(Color FillC)
        {
            fillColor = FillC;
        }
        public Color getFillColor()
        {
            return fillColor;
        }

        public void setInitMoveX(int InitX)
        {
            moveInitStepX = InitX;
        }
        public int getInitMoveX()
        {
            return moveInitStepX;
        }

        public void setInitMoveY(int InitY)
        {
            moveInitStepY = InitY;
        }
        public int getInitMoveY()
        {
            return moveInitStepY;
        }

        public void setInitMoveSpeed(int InitS)
        {
            moveInitSpeed = (float)InitS / 2;
        }
        public int getInitMoveSpeed()
        {
            return (int)(moveInitSpeed * 2);
        }


        private void getRealRandomSpeed(Random rand, ref float InitSpeed, ref int InitX, ref int InitY)
        {
            InitX = rand.Next(INIT_STEP_X_MIN, INIT_STEP_X_MAX + 1);
            InitY = rand.Next(INIT_STEP_Y_MIN, INIT_STEP_Y_MAX + 1);
            InitSpeed = (float)(rand.Next((int)(INIT_SPEED_MIN * 2 + 1), (int)(INIT_SPEED_MAX * 2 + 1))) / 2;
        }

        public void setModeMovePointsRandom(bool Mode)
        {
            modeMoveInitPointsRandom = Mode;
        }
        public bool getModeMovePointsRandom()
        {
            return modeMoveInitPointsRandom;
        }

        public void setSquarePoint(bool Mode)
        {
            squarePoint = Mode;
        }
        public bool getSquarePoint()
        {
            return squarePoint;
        }


        public void setRandomSpeedToAll()
        {
            if (moveDir != null)
            {
                Random rand = new Random();
                int InitX = rand.Next(INIT_STEP_X_MIN, INIT_STEP_X_MAX + 1);
                int InitY = rand.Next(INIT_STEP_Y_MIN, INIT_STEP_Y_MAX + 1);
                float InitSpeed = (float)(rand.Next((int)(INIT_SPEED_MIN * 2 + 1), (int)(INIT_SPEED_MAX * 2 + 1))) / 2;

                for (int i = 0; i < moveDir.Length; i++)
                { 
                    moveDir[i] = new Direct(InitSpeed, InitX, InitY);
                }
            }
        }

        public void setRealRandomSpeedToAll()
        {
            if (moveDir != null)
            {
                Random rand = new Random();

                for (int i = 0; i < moveDir.Length; i++)
                {
                    float InitSpeed = 0;
                    int InitX = 0;
                    int InitY = 0;
                    getRealRandomSpeed(rand, ref InitSpeed, ref InitX, ref InitY);

                    moveDir[i] = new Direct(InitSpeed, InitX, InitY);
                }
            }
        }

        public void setManyPoints()
        {
            arPoints = null;
            moveDir = null;

            setPointsCount(-pointsCount);

            // calculate actual borders
            int leftBorder = leftMargin;
            int rightBorder = form.Width - rightMargin - pointWidth / 2;
            int topBorder = topMargin;
            int bottomBorder = form.Height - bottomMargin - pointWidth / 2;

            //calculate rows and columns
            int Delta = 10;
            if (pointWidth >= 6)
            {
                Delta = pointWidth * 2;
            }
            

            int cols = (rightBorder - leftBorder) / Delta;
            int rows = (bottomBorder - topBorder) / Delta;

            cout((cols * rows).ToString() + " points added");
            setPointsCount(cols * rows);

            arPoints = new PointF[cols * rows];
            moveDir = new Direct[cols * rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arPoints[i * cols + j] = new PointF(leftBorder + Delta * (j + 1),
                        topBorder + Delta * (i + 1));

                    moveDir[i * cols + j] = new Direct(moveInitSpeed, moveInitStepX, moveInitStepY);
                }
            }

            Refresh();

        }

       
    }
}
