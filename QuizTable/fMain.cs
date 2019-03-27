using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTableCS
{
    public partial class fMain : Form
    {
        static Color Violet = Color.FromArgb(90, 45, 174);
        static Color LightViolet = Color.FromArgb(242, 247, 253);

        // Move window
        private Point mouseOffset;
        private bool isMouseDown = false;

        // form shadow
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        public fMain()
        {
            
            InitializeComponent();
            sidePanel.BackColor = Violet;

            puzzlePage.BackColor = LightViolet;
            tablePage.BackColor = LightViolet;
            settingsPage.BackColor = LightViolet;


            DefaultPagePosition();
            btnHome.BackColor = Color.White;
            btnHome.Image = Image.FromFile(@"img\home_violet_24.png");
            mainPage.Visible = true;
        }

        public void DefaultPagePosition()
        {
            //hide all pages
            mainPage.Visible = false;
            puzzlePage.Visible = false;
            tablePage.Visible = false;
            settingsPage.Visible = false;

            //default back color
            btnHome.BackColor = Violet;
            bntGame.BackColor = Violet;
            btnTable.BackColor = Violet;
            btnSettings.BackColor = Violet;

            //default images
            btnHome.Image = Image.FromFile("img\\home_white_24.png");
            bntGame.Image = Image.FromFile(@"img\puzzle_white_24.png");
            btnTable.Image = Image.FromFile(@"img\table_white_24.png");
            btnSettings.Image = Image.FromFile(@"img\settings_white_24.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DefaultPagePosition();
            btnHome.BackColor = Color.White;
            btnHome.Image = Image.FromFile(@"img\home_violet_24.png");
            mainPage.Visible = true;
        }

        private void bntGame_Click(object sender, EventArgs e)
        {
            DefaultPagePosition();
            bntGame.BackColor = Color.White;
            bntGame.Image = Image.FromFile(@"img\puzzle_violet_24.png");
            puzzlePage.Visible = true;    
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            DefaultPagePosition();
            btnTable.BackColor = Color.White;
            btnTable.Image = Image.FromFile(@"img\table_violet_24.png");
            tablePage.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            DefaultPagePosition();
            btnSettings.BackColor = Color.White;
            btnSettings.Image = Image.FromFile(@"img\settings_violet_24.png");
            settingsPage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Move window
        private void pTop_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
        private void pTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void pTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        // Design
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
            btnExit.Image =Properties.Resources.close;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Transparent;
            btnExit.Image = Properties.Resources.close2;
        }

        // Form Shadow
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //if (btnMaximize.Tag == "0")
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //    btnMaximize.Tag = "1";
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Normal;
            //    btnMaximize.Tag = "0";
            //}
        }

        public static void RoundBorderForm(Form frm)
        {

            Rectangle Bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            int CornerRadius = 10;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            frm.Region = new Region(path);
            frm.Show();
        }
    }
}