using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizTableCS
{
    public partial class fMain : Form
    {
        static Color Violet = Color.FromArgb(90, 45, 174);
        static Color LightViolet = Color.FromArgb(242, 247, 253);
        
        public fMain()
        {
            InitializeComponent();
            sidePanel.BackColor = Violet;

            puzzlePage.BackColor = LightViolet;
            tablePage.BackColor = LightViolet;
            settingsPage.BackColor = LightViolet;
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
    }
}
