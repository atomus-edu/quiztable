using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTableCS
{
    public partial class PuzzlePage : UserControl
    {
        const int OFFSET = 5;
        const int X_START = 15;
        const int Y_START = 25;
        const int ELEM_HEIGHT = 45;
        const int ELEM_WIDTH = 80;

        public PuzzlePage()
        {
            InitializeComponent();
            InitializeGameField();
            InitializeSideElements();
        }

        private void InitializeGameField()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 && (j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 8 || j == 9))
                    {
                        // do nothing
                    }
                    else if((i == 1|| i == 2|| i == 4|| i == 6 || i == 8) && (j ==8 ||j==9))
                    {
                        // do nothing
                    }
                    else
                    {
                        Panel p = new Panel();
                        p.BackColor = Color.Gray;
                        p.Height = ELEM_HEIGHT;
                        p.Width = ELEM_WIDTH;
                        p.Left = pSide.Width + X_START + ELEM_WIDTH * j + OFFSET * j;
                        p.Top = Y_START + ELEM_HEIGHT * i + OFFSET * i;

                        

                        Label ls = new Label();
                        ls.Parent = p;
                        ls.ForeColor = Color.White;
                        ls.Location = new System.Drawing.Point(35, 3);
                        ls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        ls.Text = "Mn";// Symbol

                        Label ln = new Label();
                        ln.Parent = p;
                        ln.ForeColor = Color.White;
                        ln.Location = new System.Drawing.Point(0, 1);
                        ln.Text = "2234";// Number

                        Label lf = new Label();
                        lf.Parent = p;
                        lf.ForeColor = Color.White;
                        lf.Location = new System.Drawing.Point(0, 25);
                        lf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        lf.Text = "Heliumbumon";// Full Name

                        Controls.Add(p);
                    }
                }
            }
        }
        private void InitializeSideElements()
        {
            for (int i = 0; i < 80; i++)
            {
                Panel p = new Panel();
                
                p.BackColor = Color.Gray;
                p.Height = ELEM_HEIGHT;
                //p.Width = pSide.Width - 7 * OFFSET;
                p.Width = ELEM_WIDTH;
                p.Left = 2*OFFSET;
                p.Top = OFFSET + ELEM_HEIGHT*i + OFFSET*i;
                p.Cursor = Cursors.Hand;
                MoveControl.LearnToMove(p);

                Label l = new Label();
                l.ForeColor = Color.White;
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                //l.Location = new System.Drawing.Point(46, 7);
                l.Text = "He";
                l.Parent = p;

                Controls.Add(p);
                p.Parent = pSide;
            }
        }

    }
}
