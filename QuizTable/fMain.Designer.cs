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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.bntGame = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.mainPage = new QuizTableCS.MainPage();
            this.puzzlePage = new QuizTableCS.PuzzlePage();
            this.settingsPage = new QuizTableCS.SettingsPage();
            this.tablePage = new QuizTableCS.TablePage();
            this.sidePanel.SuspendLayout();
            this.pTop.SuspendLayout();
            this.SuspendLayout();
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
            this.sidePanel.Size = new System.Drawing.Size(40, 572);
            this.sidePanel.TabIndex = 5;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuestion.FlatAppearance.BorderSize = 0;
            this.btnQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestion.Image = global::QuizTableCS.Properties.Resources.question_white_24;
            this.btnQuestion.Location = new System.Drawing.Point(0, 532);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(40, 40);
            this.btnQuestion.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnQuestion, "Довідник");
            this.btnQuestion.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::QuizTableCS.Properties.Resources.home_white_24;
            this.btnHome.Location = new System.Drawing.Point(0, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnHome, "Головна");
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::QuizTableCS.Properties.Resources.settings_white_24;
            this.btnSettings.Location = new System.Drawing.Point(0, 147);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSettings, "Налаштування");
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // bntGame
            // 
            this.bntGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntGame.FlatAppearance.BorderSize = 0;
            this.bntGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGame.Image = global::QuizTableCS.Properties.Resources.puzzle_white_24;
            this.bntGame.Location = new System.Drawing.Point(0, 67);
            this.bntGame.Name = "bntGame";
            this.bntGame.Size = new System.Drawing.Size(40, 40);
            this.bntGame.TabIndex = 1;
            this.toolTip1.SetToolTip(this.bntGame, "Гра");
            this.bntGame.UseVisualStyleBackColor = true;
            this.bntGame.Click += new System.EventHandler(this.bntGame_Click);
            // 
            // btnTable
            // 
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Image = global::QuizTableCS.Properties.Resources.table_white_24;
            this.btnTable.Location = new System.Drawing.Point(0, 107);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(40, 40);
            this.btnTable.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnTable, "Періодична таблиця");
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.White;
            this.pTop.Controls.Add(this.btnMinimize);
            this.pTop.Controls.Add(this.btnMaximize);
            this.pTop.Controls.Add(this.label1);
            this.pTop.Controls.Add(this.btnExit);
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(1033, 27);
            this.pTop.TabIndex = 9;
            this.pTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseDown);
            this.pTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseMove);
            this.pTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pTop_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::QuizTableCS.Properties.Resources.minus_math_24px;
            this.btnMinimize.Location = new System.Drawing.Point(889, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 27);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::QuizTableCS.Properties.Resources.maximize_24px;
            this.btnMaximize.Location = new System.Drawing.Point(937, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(48, 27);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Tag = "0";
            this.btnMaximize.Text = " ";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "QuizTable";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::QuizTableCS.Properties.Resources.close2;
            this.btnExit.Location = new System.Drawing.Point(985, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.White;
            this.mainPage.Location = new System.Drawing.Point(39, 27);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(996, 542);
            this.mainPage.TabIndex = 0;
            // 
            // puzzlePage
            // 
            this.puzzlePage.Location = new System.Drawing.Point(39, 27);
            this.puzzlePage.Name = "puzzlePage";
            this.puzzlePage.Size = new System.Drawing.Size(996, 542);
            this.puzzlePage.TabIndex = 8;
            // 
            // settingsPage
            // 
            this.settingsPage.Location = new System.Drawing.Point(38, 27);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(997, 542);
            this.settingsPage.TabIndex = 7;
            // 
            // tablePage
            // 
            this.tablePage.Location = new System.Drawing.Point(38, 27);
            this.tablePage.Name = "tablePage";
            this.tablePage.Size = new System.Drawing.Size(997, 542);
            this.tablePage.TabIndex = 6;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1033, 572);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.mainPage);
            this.Controls.Add(this.puzzlePage);
            this.Controls.Add(this.settingsPage);
            this.Controls.Add(this.tablePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button bntGame;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Panel sidePanel;
        private MainPage mainPage;
        private System.Windows.Forms.ToolTip toolTip1;
        private TablePage tablePage;
        private SettingsPage settingsPage;
        private PuzzlePage puzzlePage;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}

