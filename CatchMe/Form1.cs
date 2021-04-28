using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        private int point;
        private int time;
        public Form1()
        {
            InitializeComponent();
            point = 0;
            time = 0;
        }

        //
        // Mouse
        //
        private void buttonMouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вспіймали", "Яй!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonMouse.Location = new Point(panel.Width / 2 - 20, panel.Height / 2 - 20);
            point++;
            labelPoint.Text = $"Point: {point}";
        }
        private void buttonMouse_MouseMove(object sender, MouseEventArgs e)
        {
            Point tmp = new Point(buttonMouse.Location.X + 20, buttonMouse.Location.Y + 20);
            tmp.X += 50;
            if (tmp.X <= this.Width - 45)
            {
                buttonMouse.Location = new Point(tmp.X - 20, tmp.Y - 20);
                return;
            }
            tmp.X -= 100;
            if (tmp.X >= 30)
            {
                buttonMouse.Location = new Point(tmp.X - 20, tmp.Y - 20);
                return;
            }
            tmp.X += 50;
            tmp.Y += 50;
            if (tmp.Y <= this.Height - 55)
            {
                buttonMouse.Location = new Point(tmp.X - 20, tmp.Y - 20);
                return;
            }
            tmp.Y -= 100;
            if (tmp.Y >= 30)
            {
                buttonMouse.Location = new Point(tmp.X - 20, tmp.Y - 20);
                return;
            }

            if (IsHouse())
            {
                ChooseDoor();
            }
        }
        //
        // Strip Menu
        //
        private void StripMenu_Click(object sender, EventArgs e)
        {
            this.panel.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.buttonMouse.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.buttonMouse_MouseMove);
            timerFreeze.Start();
        }
        private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
        {
            contextMenuStrip.Close();
        }
        //
        // Timer Freeze
        //
        private void timer_Tick(object sender, EventArgs e)
        {
            timerFreeze.Stop();
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.buttonMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMouse_MouseMove);
        }
        //
        // Timer time
        //
        private void timerTime_Tick(object sender, EventArgs e)
        {
            time += 1;
            string tmp = Convert.ToString((double)time / 10);
            if ((time % 10) == 0)
                tmp += ".0";            
            labelTime.Text = tmp + " Time";
        }
        //
        // Panel game field
        //
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            Point tmp = new Point(buttonMouse.Location.X + 20, buttonMouse.Location.Y + 20);
            int distance = Distanse(tmp, e.Location);
            if (distance < 50)
            {
                tmp.X += 10;
                if (tmp.X <= panel.Width - 20 && Distanse(tmp, e.Location) >= 50)
                {
                    buttonMouse.Location = new Point(tmp.X - 20, tmp.Y - 20);
                    return;
                }
                tmp.X -= 20;
                if (tmp.X >= 30 && Distanse(tmp, e.Location) >= 50)
                {
                    buttonMouse.Location = new Point(tmp.X - 20, tmp.Y - 20);
                    return;
                }
                tmp.X += 10;
                tmp.Y += 10;
                if (tmp.Y <= panel.Height - 30 && Distanse(tmp, e.Location) >= 50)
                {
                    buttonMouse.Location = new Point(tmp.X - 20, tmp.Y - 20);
                    return;
                }
                tmp.Y -= 20;
                if (tmp.Y >= 30 && Distanse(tmp, e.Location) >= 50)
                {
                    buttonMouse.Location = new Point(tmp.X - 20, tmp.Y - 20);
                    return;
                }
            }
            if (distance < 50 && IsHouse())
            {
                ChooseDoor();
            }
        }
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip.Show(new Point(this.Location.X + e.X, this.Location.Y + e.Y + 50));
        }
        //
        // Support methods
        //
        private void ChooseDoor()
        {
            int door = MyRand.GetRand(1, 4);
            switch (door)
            {
                case 1:
                    buttonMouse.Location = new Point(20, 20);
                    break;
                case 2:
                    buttonMouse.Location = new Point(panel.Width - 50, 20);
                    break;
                case 3:
                    buttonMouse.Location = new Point(20, panel.Height - 50);
                    break;
                case 4:
                    buttonMouse.Location = new Point(panel.Width - 50, panel.Height - 50);
                    break;
                default:
                    break;
            }
        }
        private bool IsHouse()
        {
            if (buttonMouse.Location.X < 40 && buttonMouse.Location.Y < 40)
                return true;
            if (buttonMouse.Location.X + 40 > panel.Width - 50 && buttonMouse.Location.Y < 40)
                return true;
            if (buttonMouse.Location.X < 40 && buttonMouse.Location.Y + 40 > panel.Height - 70)
                return true;
            if (buttonMouse.Location.X + 40 > panel.Width - 50 && buttonMouse.Location.Y + 40 > panel.Height - 70)
                return true;
            return false;

        }
        private int Distanse(Point a, Point b)
        {
            return (int)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}
