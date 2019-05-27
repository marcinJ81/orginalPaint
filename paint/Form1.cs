using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace paint
{
    public partial class Form1 : Form
    {
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private Pen myPen;
        private Point startXY = new Point(0, 0);
        private bool elipseUse = false;
        private bool penUse = false;
        private bool brushUse = false;
        private bool isDrawning = false;
        private bool rectangleUse = false;
        private bool filElipseUse = false;
        private bool filRectangle = false;
        private bool eraseUse = false;
        Bitmap obrazek2;
        Bitmap old;
        private float angle = 0.0f;
        private Bitmap buffer;
        int heightR = 0, widthR = 0;
        Point pStart, pEnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeTools();
        }
        void initializeTools()
        {
            float widthBrush = int.Parse(nudTRackBar.Text);
            myBrush = new SolidBrush(colorPanel.BackColor);
            myGraphics = canvasPanel.CreateGraphics();
            myPen = new Pen(colorPanel.BackColor,widthBrush);
            old = new Bitmap(canvasPanel.Height,canvasPanel.Width);
            
           
        }
        private void colorPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawning = true;
            pStart = new Point(e.X, e.Y);
            //canvasPanel.Invalidate();
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            pEnd = new Point(e.X, e.Y);
            if (penUse)
            {
                myPen = new Pen(colorPanel.BackColor, (int)nudTRackBar.Value); 
                myGraphics.DrawLine(myPen, pStart, pEnd);
            }
            //gdy koniec mniejszy od poczatku???
            if (rectangleUse)
            {
                myPen = new Pen(colorPanel.BackColor, (int)nudTRackBar.Value);
                myGraphics.DrawRectangle(myPen, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
            }
            if (elipseUse)
            {
                myPen = new Pen(colorPanel.BackColor, (int)nudTRackBar.Value);
                myGraphics.DrawEllipse(myPen, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
            }
            if (filElipseUse)
            {
                myBrush = new SolidBrush(colorPanel.BackColor);
                myGraphics.FillEllipse(myBrush, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
            }
            if (filRectangle)
            {
                 myBrush = new SolidBrush(colorPanel.BackColor);
                myGraphics.FillRectangle( myBrush, pStart.X, pStart.Y, (pEnd.X - pStart.X), (pEnd.Y - pStart.Y));
            }
            isDrawning = false;
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawning == true)
            {
                if (brushUse)
                {
                    myGraphics.FillEllipse(myBrush, e.X, e.Y, (int)nudTRackBar.Value, (int)nudTRackBar.Value);
                }
                if (eraseUse)
                {
                    myBrush = new SolidBrush(Color.White);
                    myGraphics.FillEllipse(myBrush, e.X, e.Y, (int)nudTRackBar.Value, (int)nudTRackBar.Value);
                }
            }
        }
        private void colorPanel_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog1.Color;
                myBrush.Color = colorPanel.BackColor;
                myPen.Color = colorPanel.BackColor;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            rectangleUse = true;
            penUse = false;
            brushUse = false;
            elipseUse = false;
            filElipseUse = false;
            eraseUse = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            penUse = true;
            rectangleUse = false;
            brushUse = false;
            elipseUse = false;
            filElipseUse = false;
            eraseUse = false;
            filRectangle = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            brushUse = true;
            penUse = false;
            rectangleUse = false;
            elipseUse = false;
            filElipseUse = false;
            eraseUse = false;
            filRectangle = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filElipseUse = false;
            rectangleUse = false;
            brushUse = false;
            penUse = false;
            elipseUse = true;
            eraseUse = false;
            filRectangle = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            nudTRackBar.Text = trackBar1.Value.ToString();
        }

        private void nudTRackBar_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)nudTRackBar.Value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eraseUse = false;
            rectangleUse = false;
            brushUse = false;
            penUse = false;
            elipseUse = false;
            filElipseUse = true;
            filRectangle = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rectangleUse = false;
            brushUse = false;
            penUse = false;
            elipseUse = false;
            filElipseUse = false;
            eraseUse = true;
            filRectangle = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            filRectangle = true;
            rectangleUse = false;
            brushUse = false;
            penUse = false;
            elipseUse = false;
            filElipseUse = false;
            eraseUse = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            canvasPanel.BackColor = Color.White;
            myGraphics.Clear(Color.White);
        }
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            Image obrazek;
           
           o.Filter = "bitmapy |*.bmp";
           o.FilterIndex = 1;
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                obrazek = (Image)Image.FromFile(o.FileName).Clone();
                obrazek2 = new Bitmap(obrazek, canvasPanel.Width, canvasPanel.Height);
                canvasPanel.BackgroundImage = obrazek2;
                myGraphics.DrawImage(obrazek2, startXY);               
            }
        }

        private void canvasPanel_SizeChanged(object sender, EventArgs e)
        {

            
            
        }
        

        private void RotateImage(Panel pb, Image img, float angle)
        {
            if (img == null || pb.BackgroundImage == null)
                return;

            Image oldImage = pb.BackgroundImage;
            pb.BackgroundImage = Utilities.RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        private void canvasPanel_Resize(object sender, EventArgs e)
        {
          
                Bitmap newBuffer = new Bitmap(canvasPanel.Width, canvasPanel.Height);
                canvasPanel.DrawToBitmap(newBuffer, new Rectangle(0, 0, canvasPanel.Width, canvasPanel.Height));
               // if (buffer != null)
                myGraphics = Graphics.FromImage(newBuffer);
                myGraphics.DrawImageUnscaled(newBuffer, startXY);
                myGraphics = canvasPanel.CreateGraphics();
                
        }
        /// <summary>
        /// cofnij
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            Graphics gr1 = canvasPanel.CreateGraphics();
            Bitmap bmp1 = new Bitmap(canvasPanel.Width, canvasPanel.Height);
            canvasPanel.DrawToBitmap(bmp1, new Rectangle(0, 0, canvasPanel.Width, canvasPanel.Height));
            bmp1.Save("d:\\test.jpg");

            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(canvasPanel.Width, canvasPanel.Height);
            canvasPanel.DrawToBitmap(bitmap, new System.Drawing.Rectangle(new Point(0, 0), canvasPanel.Size));
            myGraphics.DrawImage(bitmap, startXY);
            bitmap.Save("d:\\test2.jpg");
            gr1.Dispose();
            myGraphics = canvasPanel.CreateGraphics();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            initializeTools();
            Point newPoint = new Point(canvasPanel.Height, 0);
            Bitmap newBuffer = new Bitmap(canvasPanel.Width, canvasPanel.Height);
            angle = (float)nudAngle.Value;
            RotateImage(canvasPanel, newBuffer, angle);
            myGraphics = canvasPanel.CreateGraphics();
        }
        
    }
}
