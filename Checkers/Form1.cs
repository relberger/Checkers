using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form1 : Form
    {
        private const int SQUARE_SIDE_LEN = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void nudBoardSize_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown me = (NumericUpDown)sender;
            int size = (int)me.Value;  
            pnlBoard.Height = size * SQUARE_SIDE_LEN;
            pnlBoard.Width = size * SQUARE_SIDE_LEN;

            for (int row = 0; row < size; ++row)
            {
                for (int col = 0; col < size; ++col)
                {
                    PictureBox pb = new PictureBox();
                    pb.Width = pb.Height = SQUARE_SIDE_LEN;
                    pb.Image = (row + col) % 2 == 0 ? liteSquare.Image : darkSquare.Image;
                    pnlBoard.Controls.Add(pb);
                    pb.Location = new Point(col * SQUARE_SIDE_LEN, row * SQUARE_SIDE_LEN);
                    pb.MouseDown +=  pnlBoard_MouseDown;
                }
            }
        }

        private void pnlBoard_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = (Point)e.Location;
            lblLocation.Text = $"x = {point.X}   y = {point.Y}";
        }
    }
}
