using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTable
{
    public partial class PuzzlePage : UserControl
    {
        const int OFFSET = 5;
        const int X_START = 15;
        const int Y_START = 50;
        const int ELEM_HEIGHT = 40;
        const int ELEM_WIDTH = 70;

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
                p.Width = pSide.Width - 7*OFFSET;
                p.Left = 2*OFFSET;
                p.Top = OFFSET + ELEM_HEIGHT*i + OFFSET*i;
                Controls.Add(p);
                p.Parent = pSide;
            }
        }
    }
}
