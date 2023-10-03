using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_UnHoldButton
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private bool isEqualPoint(Point p)
        {
            var currentLoc = new Point(btnClickMe.Location.X, btnClickMe.Location.Y);
            if (currentLoc.X == p.X && currentLoc.Y == p.Y) return true;
            return false;

        }

        private int getPointIndex(int currentIndex)
        {
            while (true)
            {
                var index = random.Next(0, 5);
                if (index != currentIndex) return index;
            }
        }

        private void btnClickMe_MouseHover(object sender, EventArgs e)
        {
            var chcPointFlag = random.Next(0, 5);
            var midPoint = new Point(384, 293);
            var topLeftPoint = new Point(115, 106);
            var botLeftPoint = new Point(85, 487);
            var topRightPoint = new Point(703, 82);
            var botRightPoint = new Point(727, 516);
            var points = new Point[] { midPoint, topLeftPoint, botLeftPoint, topRightPoint, botRightPoint };

            if (chcPointFlag == 0)
            {
                if (!isEqualPoint(points[0])) btnClickMe.Location = new Point(points[0].X, points[0].Y);
                else
                {
                    btnClickMe.Location = new Point(points[getPointIndex(0)].X, points[getPointIndex(0)].Y);
                }
            }
            else if (chcPointFlag == 1)
            {
                if (!isEqualPoint(points[1])) btnClickMe.Location = new Point(points[1].X, points[1].Y);
                else
                {
                    btnClickMe.Location = new Point(points[getPointIndex(1)].X, points[getPointIndex(1)].Y);
                }
            }
            else if (chcPointFlag == 2)
            {
                if (!isEqualPoint(points[2])) btnClickMe.Location = new Point(points[2].X, points[2].Y);
                else
                {
                    btnClickMe.Location = new Point(points[getPointIndex(2)].X, points[getPointIndex(2)].Y);
                }
            }
            else if (chcPointFlag == 3)
            {
                if (!isEqualPoint(points[3])) btnClickMe.Location = new Point(points[3].X, points[3].Y);
                else
                {
                    btnClickMe.Location = new Point(points[getPointIndex(3)].X, points[getPointIndex(3)].Y);
                }
            }
            else if (chcPointFlag == 4)
            {
                if (!isEqualPoint(points[4])) btnClickMe.Location = new Point(points[4].X, points[4].Y);
                else
                {
                    btnClickMe.Location = new Point(points[getPointIndex(4)].X, points[getPointIndex(4)].Y);
                }
            }
            var randomColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            this.BackColor = randomColor;
        }
    }

}
