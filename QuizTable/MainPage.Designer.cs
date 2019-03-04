namespace QuizTableCS
{
    partial class MainPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.lblMain = new System.Windows.Forms.Label();
            this.bigPanel = new System.Windows.Forms.Panel();
            this.smalPanel = new System.Windows.Forms.Panel();
            this.lblBigPanel = new System.Windows.Forms.Label();
            this.lblSmalPanel = new System.Windows.Forms.Label();
            this.bigRichTextBox = new System.Windows.Forms.RichTextBox();
            this.smallRichTextBox = new System.Windows.Forms.RichTextBox();
            this.bigPanel.SuspendLayout();
            this.smalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.ForeColor = System.Drawing.Color.Indigo;
            this.lblMain.Location = new System.Drawing.Point(48, 32);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(148, 40);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "QuizTable";
            // 
            // bigPanel
            // 
            this.bigPanel.Controls.Add(this.bigRichTextBox);
            this.bigPanel.Controls.Add(this.lblBigPanel);
            this.bigPanel.Location = new System.Drawing.Point(55, 123);
            this.bigPanel.Name = "bigPanel";
            this.bigPanel.Size = new System.Drawing.Size(446, 275);
            this.bigPanel.TabIndex = 1;
            // 
            // smalPanel
            // 
            this.smalPanel.Controls.Add(this.smallRichTextBox);
            this.smalPanel.Controls.Add(this.lblSmalPanel);
            this.smalPanel.Location = new System.Drawing.Point(527, 123);
            this.smalPanel.Name = "smalPanel";
            this.smalPanel.Size = new System.Drawing.Size(200, 275);
            this.smalPanel.TabIndex = 2;
            // 
            // lblBigPanel
            // 
            this.lblBigPanel.AutoSize = true;
            this.lblBigPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBigPanel.ForeColor = System.Drawing.Color.Indigo;
            this.lblBigPanel.Location = new System.Drawing.Point(14, 9);
            this.lblBigPanel.Name = "lblBigPanel";
            this.lblBigPanel.Size = new System.Drawing.Size(247, 25);
            this.lblBigPanel.TabIndex = 3;
            this.lblBigPanel.Text = "Lorem ipsum dolor sit amet";
            // 
            // lblSmalPanel
            // 
            this.lblSmalPanel.AutoSize = true;
            this.lblSmalPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSmalPanel.ForeColor = System.Drawing.Color.Indigo;
            this.lblSmalPanel.Location = new System.Drawing.Point(9, 9);
            this.lblSmalPanel.Name = "lblSmalPanel";
            this.lblSmalPanel.Size = new System.Drawing.Size(181, 25);
            this.lblSmalPanel.TabIndex = 3;
            this.lblSmalPanel.Text = "Lorem ipsum dolor?";
            // 
            // bigRichTextBox
            // 
            this.bigRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bigRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bigRichTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigRichTextBox.Location = new System.Drawing.Point(11, 50);
            this.bigRichTextBox.Name = "bigRichTextBox";
            this.bigRichTextBox.ReadOnly = true;
            this.bigRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.bigRichTextBox.Size = new System.Drawing.Size(424, 214);
            this.bigRichTextBox.TabIndex = 4;
            this.bigRichTextBox.Text = resources.GetString("bigRichTextBox.Text");
            // 
            // smallRichTextBox
            // 
            this.smallRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.smallRichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.smallRichTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smallRichTextBox.Location = new System.Drawing.Point(14, 37);
            this.smallRichTextBox.Name = "smallRichTextBox";
            this.smallRichTextBox.ReadOnly = true;
            this.smallRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.smallRichTextBox.Size = new System.Drawing.Size(176, 227);
            this.smallRichTextBox.TabIndex = 5;
            this.smallRichTextBox.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua.";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.smalPanel);
            this.Controls.Add(this.bigPanel);
            this.Controls.Add(this.lblMain);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(760, 450);
            this.bigPanel.ResumeLayout(false);
            this.bigPanel.PerformLayout();
            this.smalPanel.ResumeLayout(false);
            this.smalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Panel bigPanel;
        private System.Windows.Forms.Panel smalPanel;
        private System.Windows.Forms.Label lblBigPanel;
        private System.Windows.Forms.Label lblSmalPanel;
        private System.Windows.Forms.RichTextBox bigRichTextBox;
        private System.Windows.Forms.RichTextBox smallRichTextBox;
    }
}
