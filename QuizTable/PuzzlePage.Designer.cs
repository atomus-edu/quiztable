namespace QuizTableCS
{
    partial class PuzzlePage
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
            this.pSide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorrectAnsw = new System.Windows.Forms.Label();
            this.lblWrongAnsw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pSide
            // 
            this.pSide.AutoScroll = true;
            this.pSide.BackColor = System.Drawing.Color.White;
            this.pSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSide.Location = new System.Drawing.Point(0, 0);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(115, 542);
            this.pSide.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(115, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 542);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // lblCorrectAnsw
            // 
            this.lblCorrectAnsw.AutoSize = true;
            this.lblCorrectAnsw.Location = new System.Drawing.Point(359, 21);
            this.lblCorrectAnsw.Name = "lblCorrectAnsw";
            this.lblCorrectAnsw.Size = new System.Drawing.Size(13, 13);
            this.lblCorrectAnsw.TabIndex = 4;
            this.lblCorrectAnsw.Text = "0";
            // 
            // lblWrongAnsw
            // 
            this.lblWrongAnsw.AutoSize = true;
            this.lblWrongAnsw.Location = new System.Drawing.Point(522, 21);
            this.lblWrongAnsw.Name = "lblWrongAnsw";
            this.lblWrongAnsw.Size = new System.Drawing.Size(13, 13);
            this.lblWrongAnsw.TabIndex = 5;
            this.lblWrongAnsw.Text = "0";
            // 
            // PuzzlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWrongAnsw);
            this.Controls.Add(this.lblCorrectAnsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pSide);
            this.Name = "PuzzlePage";
            this.Size = new System.Drawing.Size(996, 542);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorrectAnsw;
        private System.Windows.Forms.Label lblWrongAnsw;
    }
}
