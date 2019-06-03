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
    public partial class TablePage : UserControl
    {
        const int OFFSET = 5;
        const int X_START = 15;
        const int Y_START = 15;
        const int ELEM_HEIGHT = 47;
        const int ELEM_WIDTH = 93;

        public TablePage()
        {
            InitializeComponent();
            QuizTable.Initialize();
            InitializeGameField();
        }

        private void InitializeGameField()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 && (j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 6 || j == 8 || j == 9))
                    {
                        // do nothing
                    }
                    else if ((i == 1 || i == 2 || i == 4 || i == 6 || i == 8) && (j == 8 || j == 9))
                    {
                        // do nothing
                    }
                    else
                    {
                        Panel p = new Panel();
                        p.BackColor = Color.Blue;
                        p.Height = ELEM_HEIGHT;
                        p.Width = ELEM_WIDTH;
                        p.Left = X_START + ELEM_WIDTH * j + OFFSET * j;
                        p.Top = Y_START + ELEM_HEIGHT * i + OFFSET * i;

                        Label ls = new Label();
                        ls.Parent = p;
                        ls.ForeColor = Color.White;
                        ls.Location = new System.Drawing.Point(55, 3);
                        ls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        ls.Text = QuizTable.elements[i, j].Symbol;// Symbol

                        Label ln = new Label();
                        ln.Parent = p;
                        ln.ForeColor = Color.White;
                        ln.Location = new System.Drawing.Point(0, 1);
                        ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        ln.Text = QuizTable.elements[i, j].Number.ToString();// Number

                        Label lf = new Label();
                        lf.Parent = p;
                        lf.ForeColor = Color.White;
                        lf.Location = new System.Drawing.Point(0, 25);
                        lf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        lf.Text = QuizTable.elements[i, j].Name;// Full Name

                        Controls.Add(p);
                    }
                }
            }
        }
    }
}