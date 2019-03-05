namespace QuizTableCS
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.bntGame = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPage = new QuizTableCS.MainPage();
            this.puzzlePage = new QuizTableCS.PuzzlePage();
            this.tablePage = new QuizTableCS.TablePage();
            this.settingsPage = new QuizTableCS.SettingsPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuestion
            // 
            this.btnQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuestion.FlatAppearance.BorderSize = 0;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Image = global::QuizTableCS.Properties.Resources.question_white_24;
            this.btnQuestion.Location = new System.Drawing.Point(0, 410);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(40, 40);
            this.btnQuestion.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnQuestion, "Довідник");
            this.btnQuestion.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::QuizTableCS.Properties.Resources.settings_white_24;
            this.btnSettings.Location = new System.Drawing.Point(0, 120);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSettings, "Налаштування");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTable
            // 
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Image = global::QuizTableCS.Properties.Resources.table_white_24;
            this.btnTable.Location = new System.Drawing.Point(0, 80);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(40, 40);
            this.btnTable.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnTable, "Періодична таблиця");
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // bntGame
            // 
            this.bntGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntGame.FlatAppearance.BorderSize = 0;
            this.bntGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGame.Image = global::QuizTableCS.Properties.Resources.puzzle_white_24;
            this.bntGame.Location = new System.Drawing.Point(0, 40);
            this.bntGame.Name = "bntGame";
            this.bntGame.Size = new System.Drawing.Size(40, 40);
            this.bntGame.TabIndex = 1;
            this.toolTip1.SetToolTip(this.bntGame, "Гра");
            this.bntGame.UseVisualStyleBackColor = true;
            this.bntGame.Click += new System.EventHandler(this.bntGame_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::QuizTableCS.Properties.Resources.home_white_24;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnHome, "Головна");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sidePanel.Controls.Add(this.btnQuestion);
            this.sidePanel.Controls.Add(this.btnHome);
            this.sidePanel.Controls.Add(this.btnSettings);
            this.sidePanel.Controls.Add(this.bntGame);
            this.sidePanel.Controls.Add(this.btnTable);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(40, 450);
            this.sidePanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainPage);
            this.panel1.Controls.Add(this.puzzlePage);
            this.panel1.Controls.Add(this.tablePage);
            this.panel1.Controls.Add(this.settingsPage);
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 450);
            this.panel1.TabIndex = 6;
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.White;
            this.mainPage.Location = new System.Drawing.Point(0, 0);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(760, 450);
            this.mainPage.TabIndex = 0;
            // 
            // puzzlePage
            // 
            this.puzzlePage.BackColor = System.Drawing.SystemColors.Control;
            this.puzzlePage.Location = new System.Drawing.Point(0, 0);
            this.puzzlePage.Name = "puzzlePage";
            this.puzzlePage.Size = new System.Drawing.Size(760, 450);
            this.puzzlePage.TabIndex = 1;
            // 
            // tablePage
            // 
            this.tablePage.BackColor = System.Drawing.SystemColors.Control;
            this.tablePage.Location = new System.Drawing.Point(0, 0);
            this.tablePage.Name = "tablePage";
            this.tablePage.Size = new System.Drawing.Size(760, 450);
            this.tablePage.TabIndex = 2;
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.SystemColors.Control;
            this.settingsPage.Location = new System.Drawing.Point(0, 0);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(760, 450);
            this.settingsPage.TabIndex = 3;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Text = "QuizTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button bntGame;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel1;
        private MainPage mainPage;
        private PuzzlePage puzzlePage;
        private TablePage tablePage;
        private SettingsPage settingsPage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

