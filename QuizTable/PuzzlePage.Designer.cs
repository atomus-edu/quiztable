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
            this.pDialog = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.pSuccess = new System.Windows.Forms.Panel();
            this.pbSuccess = new System.Windows.Forms.PictureBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pMainDialog = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pDialog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).BeginInit();
            this.pMainDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(231, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "-";
            // 
            // lblCorrectAnsw
            // 
            this.lblCorrectAnsw.AutoSize = true;
            this.lblCorrectAnsw.Location = new System.Drawing.Point(250, 33);
            this.lblCorrectAnsw.Name = "lblCorrectAnsw";
            this.lblCorrectAnsw.Size = new System.Drawing.Size(13, 13);
            this.lblCorrectAnsw.TabIndex = 4;
            this.lblCorrectAnsw.Text = "0";
            // 
            // lblWrongAnsw
            // 
            this.lblWrongAnsw.AutoSize = true;
            this.lblWrongAnsw.Location = new System.Drawing.Point(304, 33);
            this.lblWrongAnsw.Name = "lblWrongAnsw";
            this.lblWrongAnsw.Size = new System.Drawing.Size(13, 13);
            this.lblWrongAnsw.TabIndex = 5;
            this.lblWrongAnsw.Text = "0";
            // 
            // pDialog
            // 
            this.pDialog.BackColor = System.Drawing.Color.Indigo;
            this.pDialog.Controls.Add(this.panel1);
            this.pDialog.Location = new System.Drawing.Point(291, 142);
            this.pDialog.Name = "pDialog";
            this.pDialog.Size = new System.Drawing.Size(446, 257);
            this.pDialog.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pMainDialog);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.pSuccess);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 251);
            this.panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(440, 5);
            this.progressBar1.Step = 20;
            this.progressBar1.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Indigo;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(358, 216);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pSuccess
            // 
            this.pSuccess.Controls.Add(this.label3);
            this.pSuccess.Controls.Add(this.lblSuccess);
            this.pSuccess.Controls.Add(this.pbSuccess);
            this.pSuccess.Location = new System.Drawing.Point(0, 0);
            this.pSuccess.Name = "pSuccess";
            this.pSuccess.Size = new System.Drawing.Size(440, 210);
            this.pSuccess.TabIndex = 11;
            this.pSuccess.Visible = false;
            // 
            // pbSuccess
            // 
            this.pbSuccess.BackColor = System.Drawing.Color.Green;
            this.pbSuccess.Location = new System.Drawing.Point(188, 18);
            this.pbSuccess.Name = "pbSuccess";
            this.pbSuccess.Size = new System.Drawing.Size(64, 64);
            this.pbSuccess.TabIndex = 10;
            this.pbSuccess.TabStop = false;
            this.pbSuccess.Visible = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSuccess.ForeColor = System.Drawing.Color.Green;
            this.lblSuccess.Location = new System.Drawing.Point(128, 90);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(184, 30);
            this.lblSuccess.TabIndex = 11;
            this.lblSuccess.Text = "Гра завантажена!";
            this.lblSuccess.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(113, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Натиснiть \"Далi\", щоб розпочати.";
            this.label3.Visible = false;
            // 
            // pMainDialog
            // 
            this.pMainDialog.Controls.Add(this.label4);
            this.pMainDialog.Controls.Add(this.label5);
            this.pMainDialog.Controls.Add(this.pictureBox1);
            this.pMainDialog.Location = new System.Drawing.Point(0, 0);
            this.pMainDialog.Name = "pMainDialog";
            this.pMainDialog.Size = new System.Drawing.Size(440, 210);
            this.pMainDialog.TabIndex = 12;
            this.pMainDialog.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(113, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Натиснiть \"Далi\", щоб розпочати.";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(128, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Гра завантажена!";
            this.label5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Green;
            this.pictureBox1.Location = new System.Drawing.Point(188, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // PuzzlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pDialog);
            this.Controls.Add(this.lblWrongAnsw);
            this.Controls.Add(this.lblCorrectAnsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pSide);
            this.Name = "PuzzlePage";
            this.Size = new System.Drawing.Size(996, 542);
            this.VisibleChanged += new System.EventHandler(this.PuzzlePage_VisibleChanged);
            this.pDialog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pSuccess.ResumeLayout(false);
            this.pSuccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).EndInit();
            this.pMainDialog.ResumeLayout(false);
            this.pMainDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel pDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pSuccess;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.PictureBox pbSuccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pMainDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
