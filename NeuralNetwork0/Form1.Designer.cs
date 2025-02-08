namespace NeuralNetwork0
{
    partial class Form1
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
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.bRight = new System.Windows.Forms.Button();
            this.bFalse = new System.Windows.Forms.Button();
            this.lGuess = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.pbWM = new System.Windows.Forms.PictureBox();
            this.bRandom = new System.Windows.Forms.Button();
            this.bGive = new System.Windows.Forms.Button();
            this.nudAlpha = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(128, 42);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(100, 100);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            // 
            // bRight
            // 
            this.bRight.Location = new System.Drawing.Point(70, 149);
            this.bRight.Name = "bRight";
            this.bRight.Size = new System.Drawing.Size(48, 23);
            this.bRight.TabIndex = 1;
            this.bRight.Text = "Да";
            this.bRight.UseVisualStyleBackColor = true;
            this.bRight.Click += new System.EventHandler(this.bRight_Click);
            // 
            // bFalse
            // 
            this.bFalse.Location = new System.Drawing.Point(16, 149);
            this.bFalse.Name = "bFalse";
            this.bFalse.Size = new System.Drawing.Size(48, 23);
            this.bFalse.TabIndex = 2;
            this.bFalse.Text = "Нет";
            this.bFalse.UseVisualStyleBackColor = true;
            this.bFalse.Click += new System.EventHandler(this.bFalse_Click);
            // 
            // lGuess
            // 
            this.lGuess.AutoSize = true;
            this.lGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGuess.Location = new System.Drawing.Point(18, 42);
            this.lGuess.MaximumSize = new System.Drawing.Size(100, 100);
            this.lGuess.MinimumSize = new System.Drawing.Size(100, 100);
            this.lGuess.Name = "lGuess";
            this.lGuess.Size = new System.Drawing.Size(100, 100);
            this.lGuess.TabIndex = 3;
            this.lGuess.Text = "X";
            this.lGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(128, 178);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(100, 23);
            this.bClear.TabIndex = 4;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // pbWM
            // 
            this.pbWM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWM.Location = new System.Drawing.Point(234, 42);
            this.pbWM.Name = "pbWM";
            this.pbWM.Size = new System.Drawing.Size(100, 100);
            this.pbWM.TabIndex = 0;
            this.pbWM.TabStop = false;
            this.pbWM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            // 
            // bRandom
            // 
            this.bRandom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bRandom.Location = new System.Drawing.Point(234, 148);
            this.bRandom.Name = "bRandom";
            this.bRandom.Size = new System.Drawing.Size(100, 43);
            this.bRandom.TabIndex = 8;
            this.bRandom.Text = "Задать новые веса";
            this.bRandom.UseVisualStyleBackColor = true;
            this.bRandom.Click += new System.EventHandler(this.bRandom_Click);
            // 
            // bGive
            // 
            this.bGive.Location = new System.Drawing.Point(128, 149);
            this.bGive.Name = "bGive";
            this.bGive.Size = new System.Drawing.Size(100, 23);
            this.bGive.TabIndex = 9;
            this.bGive.Text = "Дать";
            this.bGive.UseVisualStyleBackColor = true;
            this.bGive.Click += new System.EventHandler(this.bGive_Click);
            // 
            // nudAlpha
            // 
            this.nudAlpha.DecimalPlaces = 2;
            this.nudAlpha.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudAlpha.Location = new System.Drawing.Point(18, 16);
            this.nudAlpha.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAlpha.Name = "nudAlpha";
            this.nudAlpha.Size = new System.Drawing.Size(67, 22);
            this.nudAlpha.TabIndex = 10;
            this.nudAlpha.Value = new decimal(new int[] {
            30,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "- Альфа";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(355, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAlpha);
            this.Controls.Add(this.bGive);
            this.Controls.Add(this.bRandom);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lGuess);
            this.Controls.Add(this.bFalse);
            this.Controls.Add(this.bRight);
            this.Controls.Add(this.pbWM);
            this.Controls.Add(this.pbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button bRight;
        private System.Windows.Forms.Button bFalse;
        private System.Windows.Forms.Label lGuess;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.PictureBox pbWM;
        private System.Windows.Forms.Button bRandom;
        private System.Windows.Forms.Button bGive;
        private System.Windows.Forms.NumericUpDown nudAlpha;
        private System.Windows.Forms.Label label1;
    }
}

