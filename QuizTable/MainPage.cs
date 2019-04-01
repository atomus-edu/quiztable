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
    public partial class MainPage : UserControl
    {
        static Color Violet = Color.FromArgb(90, 45, 174);
        static Color LightViolet = Color.FromArgb(242, 247, 253);
        static Color AccentLightViolet = Color.FromArgb(216, 227, 248);
        public MainPage()
        {
            InitializeComponent();
            bigPanel.BackColor = LightViolet;
            smalPanel.BackColor = LightViolet;

            lblMain.ForeColor = Violet;
            lblBigPanel.ForeColor = Violet;
            lblSmalPanel.ForeColor = Violet;

            bigRichTextBox.BackColor = LightViolet;
            //bigRichTextBox.ForeColor = AccentLightViolet;
            smallRichTextBox.BackColor = LightViolet;
            //smallRichTextBox.ForeColor = AccentLightViolet;
        }
    }
}
