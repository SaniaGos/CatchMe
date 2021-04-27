using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point tmp = new Point(buttonMouse.Location.X + 20, buttonMouse.Location.Y + 20);
            int distance = Distanse(tmp, e.Location);
            if (distance < 50)
            {
                tmp.X += 10;
                if (tmp.X <= this.Width - 45 && Distanse(tmp, e.Location) >= 50)
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
                if (tmp.Y <= this.Height - 55 && Distanse(tmp, e.Location) >= 50)
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
        private void ChooseDoor()
        {
            int door = MyRand.GetRand(1, 4);
            switch (door)
            {
                case 1:
                    buttonMouse.Location = new Point(20, 20);
                    break;
                case 2:
                    buttonMouse.Location = new Point(Width - 80, 20);
                    break;
                case 3:
                    buttonMouse.Location = new Point(20, Height - 90);
                    break;
                case 4:
                    buttonMouse.Location = new Point(Width - 80, Height - 90);
                    break;
                default:
                    break;
            }
        }
        private bool IsHouse()
        {
            if (buttonMouse.Location.X < 40 && buttonMouse.Location.Y < 40)
                return true;
            if (buttonMouse.Location.X + 20 > Width - 60 && buttonMouse.Location.Y < 40)
                return true;
            if (buttonMouse.Location.X < 40 && buttonMouse.Location.Y + 20 > Height - 90)
                return true;
            if (buttonMouse.Location.X + 20 > Width - 60 && buttonMouse.Location.Y + 20 > Height - 90)
                return true;
            return false;

        }
        private int Distanse(Point a, Point b)
        {
            return (int)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вспіймали", "Яй!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonMouse.Location = new Point(Width / 2 - 20, Height / 2 - 20);
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
    }
}
