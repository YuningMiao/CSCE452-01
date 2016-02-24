using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        Pen p = new Pen(Color.Blue);
        SolidBrush sb = new SolidBrush(Color.Blue); //paint bursh & color
        SolidBrush sb2 = new SolidBrush(Color.Red);
        SolidBrush sb3 = new SolidBrush(Color.Purple);

        Rectangle rect = new Rectangle(400, 500, 20, 150); // arm1-3 respectively 
        Rectangle rect2 = new Rectangle(400, 400, 20, 100);
        Rectangle rect3 = new Rectangle(400, 325, 20, 75);

        Matrix arm1cw = new Matrix(); //the matrices associated with arms
        Matrix arm2cw = new Matrix();
        Matrix arm3cw = new Matrix();

        PointF axis1 = new PointF(400f, 650f); // i now use a fix point for rotation, this axis should rotate with the arm, i haven't figure out how to do it
        PointF axis2 = new PointF(400f, 500f);
        PointF axis3 = new PointF(400f, 400f);

        

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();

            //axis2.X = rect.Left;
            //axis2.Y = rect.Top;
            
            //g.DrawRectangle(p, rect);
            // draw rect
            g.FillRectangle(sb, rect);
            g.FillRectangle(sb2, rect2);
            g.FillRectangle(sb3, rect3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Graphics g2 = panel1.CreateGraphics();
            Graphics g3 = panel1.CreateGraphics();

            arm1cw.RotateAt(1, axis1, MatrixOrder.Append);
            arm2cw.RotateAt(1, axis1, MatrixOrder.Append);
            arm3cw.RotateAt(1, axis1, MatrixOrder.Append);

            g.Transform = arm1cw;
            g2.Transform = arm2cw;
            g3.Transform = arm3cw;

            
            g.Clear(Control.DefaultBackColor);
            g2.Clear(Control.DefaultBackColor);
            g3.Clear(Control.DefaultBackColor);

            g.FillRectangle(sb, 400, 500, 20, 150);
            g2.FillRectangle(sb2, axis2.X, axis2.Y - 100, 20, 100);
            g3.FillRectangle(sb3, axis3.X, axis3.Y - 75, 20, 75);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Graphics g2 = panel1.CreateGraphics();
            Graphics g3 = panel1.CreateGraphics();

            arm1cw.RotateAt(359, axis1, MatrixOrder.Append);
            arm2cw.RotateAt(359, axis1, MatrixOrder.Append);
            arm3cw.RotateAt(359, axis1, MatrixOrder.Append);

            g.Transform = arm1cw;
            g2.Transform = arm2cw;
            g3.Transform = arm3cw;

            g.Clear(Control.DefaultBackColor);
            g2.Clear(Control.DefaultBackColor);
            g3.Clear(Control.DefaultBackColor);

            g.FillRectangle(sb, 400, 500, 20, 150);
            g2.FillRectangle(sb2, axis2.X, axis2.Y - 100, 20, 100);
            g3.FillRectangle(sb3, axis3.X, axis3.Y - 75, 20, 75);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Graphics g2 = panel1.CreateGraphics();
            Graphics g3 = panel1.CreateGraphics();

            arm2cw.RotateAt(1, axis2, MatrixOrder.Append);
            arm3cw.RotateAt(1, axis2, MatrixOrder.Append);

            g.Transform = arm1cw;
            g2.Transform = arm2cw;
            g3.Transform = arm3cw;

            g.Clear(Control.DefaultBackColor);
            g2.Clear(Control.DefaultBackColor);
            g3.Clear(Control.DefaultBackColor);

            g.FillRectangle(sb, 400, 500, 20, 150);
            g2.FillRectangle(sb2, axis2.X, axis2.Y - 100, 20, 100);
            g3.FillRectangle(sb3, axis3.X, axis3.Y - 75, 20, 75);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Graphics g2 = panel1.CreateGraphics();
            Graphics g3 = panel1.CreateGraphics();

            arm2cw.RotateAt(359, axis2, MatrixOrder.Append);
            arm3cw.RotateAt(359, axis2, MatrixOrder.Append);

            g.Transform = arm1cw;
            g2.Transform = arm2cw;
            g3.Transform = arm3cw;

            g.Clear(Control.DefaultBackColor);
            g2.Clear(Control.DefaultBackColor);
            g3.Clear(Control.DefaultBackColor);

            g.FillRectangle(sb, 400, 500, 20, 150);
            g2.FillRectangle(sb2, axis2.X, axis2.Y - 100, 20, 100);
            g3.FillRectangle(sb3, axis3.X, axis3.Y - 75, 20, 75);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Graphics g2 = panel1.CreateGraphics();
            Graphics g3 = panel1.CreateGraphics();
            arm3cw.RotateAt(1, axis3, MatrixOrder.Append);
            g.Transform = arm1cw;
            g2.Transform = arm2cw;
            g3.Transform = arm3cw;


            g.Clear(Control.DefaultBackColor);
            g2.Clear(Control.DefaultBackColor);
            g3.Clear(Control.DefaultBackColor);

            g.FillRectangle(sb, 400, 500, 20, 150);
            g2.FillRectangle(sb2, axis2.X, axis2.Y - 100, 20, 100);
            g3.FillRectangle(sb3, axis3.X, axis3.Y - 75, 20, 75);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Graphics g2 = panel1.CreateGraphics();
            Graphics g3 = panel1.CreateGraphics();
            arm3cw.RotateAt(359, axis3, MatrixOrder.Append);
            g.Transform = arm1cw;
            g2.Transform = arm2cw;
            g3.Transform = arm3cw;


            g.Clear(Control.DefaultBackColor);
            g2.Clear(Control.DefaultBackColor);
            g3.Clear(Control.DefaultBackColor);

            g.FillRectangle(sb, 400, 500, 20, 150);
            g2.FillRectangle(sb2, axis2.X, axis2.Y - 100, 20, 100);
            g3.FillRectangle(sb3, axis3.X, axis3.Y - 75, 20, 75);
        }
    }
}
