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

        // Move
        bool isPress = false;
        bool IsPress { get { return isPress; } }
        Point startPst;
        int startTop;
        int startLeft;

        public PuzzlePage()
        {
            InitializeComponent();

            QuizTable.Initialize();
            InitializeGameField();
            InitializeSideElements();
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
                        p.BackColor = Color.Gray;
                        p.Height = ELEM_HEIGHT;
                        p.Width = ELEM_WIDTH;
                        p.Left = pSide.Width + X_START + ELEM_WIDTH * j + OFFSET * j;
                        p.Top = Y_START + ELEM_HEIGHT * i + OFFSET * i;
                        p.Tag = QuizTable.elements[i, j].Symbol;

                        Label ls = new Label();
                        ls.Parent = p;
                        ls.ForeColor = Color.White;
                        ls.Location = new System.Drawing.Point(35, 3);
                        ls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                        ls.Text = QuizTable.elements[i, j].Symbol;// Symbol

                        Label ln = new Label();
                        ln.Parent = p;
                        ln.ForeColor = Color.White;
                        ln.Location = new System.Drawing.Point(0, 1);
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
        private void InitializeSideElements()
        {
            List<Element> e = QuizTable.ShuffleList(QuizTable.elems);

            for (int i = 0; i < e.Count; i++)
            {
                Panel p = new Panel();
                p.BackColor = QuizTable.Violet;
                p.Height = ELEM_HEIGHT;
                p.Width = ELEM_WIDTH;

                Label l = new Label();
                l.ForeColor = Color.White;
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                l.Text = e[i].Symbol;
                l.Parent = p;

                Label lf = new Label();
                lf.Parent = p;
                lf.ForeColor = Color.White;
                lf.Location = new System.Drawing.Point(0, 25);
                lf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                lf.Text = e[i].Name;// Full Name

                // Bitmap
                Bitmap bm = new Bitmap(ELEM_WIDTH, ELEM_HEIGHT);
                p.DrawToBitmap(bm, new Rectangle(0, 0, ELEM_WIDTH, ELEM_HEIGHT));

                // PictureBox
                PictureBox pbx = new PictureBox();

                pbx.Height = ELEM_HEIGHT;
                pbx.Width = ELEM_WIDTH;
                pbx.Left = 2 * OFFSET;
                pbx.Top = OFFSET + ELEM_HEIGHT * i + OFFSET * i;
                pbx.Cursor = Cursors.Hand;
                pbx.Image = bm;
                
                Controls.Add(pbx);
                LearnToMove(pbx);
                pbx.Parent = pSide;
                pbx.Tag = e[i].Symbol;
            }

            PictureBox pb = new PictureBox();
            pb.Image = Image.FromFile("img\\mendeleev.jpg");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Location = new System.Drawing.Point(pSide.Width + X_START + 8 * ELEM_WIDTH + 8 * OFFSET, Y_START);
            pb.Height = 3 * ELEM_HEIGHT + 2 * OFFSET;
            pb.Width = 2 * ELEM_WIDTH + OFFSET;
            pb.BackColor = Color.Gray;

            Controls.Add(pb);
        }

        // Move
        // Функция выполняется при нажатии на перемещаемый контрол
        private void mDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;//проверка что нажата левая кнопка
            isPress = true;
            startPst = e.Location;

            PictureBox pb = (PictureBox)sender;
            startTop = pb.Top;
            startLeft = pb.Left;
        }

        // Функция выполняется при отжатии перемещаемого контрола
        private void mUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;//проверка что нажата левая кнопка
            isPress = false;

            PictureBox pb = (PictureBox)sender;
            Control selected = null;

            foreach (Control item in this.Controls)
                if (item.Tag == pb.Tag)
                    selected = item;

            if (selected != null)
            {
                

                if (pb.Left >= (selected.Left - 10)
                    && pb.Left <= (selected.Left + ELEM_WIDTH + 10)
                    && pb.Top >= (selected.Top - 10)
                    && pb.Top <= (selected.Top + ELEM_HEIGHT + 10))// keep element
                {
                    pb.Hide();
                    selected.BackColor = QuizTable.Violet;

                }
                else// return element to side panel
                {
                    pb.Show();
                    pb.Top = startTop;
                    pb.Left = startLeft;
                    pb.Parent = pSide;
                }
            }
            else
                MessageBox.Show("selected == null");
        }

        /// Функция выполняется при перемещении контрола
        private void mMove(object sender, MouseEventArgs e)
        {
            if (isPress)
            {
                PictureBox pb = (PictureBox)sender;
                pb.Top += e.Y - startPst.Y;
                pb.Left += e.X - startPst.X;

                //label1.Text = e.X + " - " + Cursor.Position.X + " - " + this.Left;

                if (pb.Left >= 20 && pb.Parent == pSide)
                {
                    pb.Parent = this;
                    pb.BringToFront();
                }
                else if (pb.Left < 20 && pb.Parent == this)
                {
                    pb.Parent = pSide;
                    pb.BringToFront();
                } 
                else if (pb.Left < 0 && pb.Parent == pSide)
                {
                    pb.Left = 0;
                }
                else if (pb.Top < 0)
                {
                    pb.Top = 0;
                }
            }
        }

        public void LearnToMove(object sender)
        {
            PictureBox pb = (PictureBox)sender;
            pb.MouseDown += new MouseEventHandler(mDown);
            pb.MouseUp += new MouseEventHandler(mUp);
            pb.MouseMove += new MouseEventHandler(mMove);
        }
    }
}