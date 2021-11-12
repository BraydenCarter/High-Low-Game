namespace High_Low_Game
{
    partial class frmHighLow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblBestLowScore = new System.Windows.Forms.Label();
            this.lblNumberOfGuesses = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumGuesses = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(157, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "High/Low Game";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(9, 10);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(13, 13);
            this.lblRandomNumber.TabIndex = 0;
            this.lblRandomNumber.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(378, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(378, 309);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(64, 49);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Submit &Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(357, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "&Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblBestLowScore
            // 
            this.lblBestLowScore.AutoSize = true;
            this.lblBestLowScore.Location = new System.Drawing.Point(8, 41);
            this.lblBestLowScore.Name = "lblBestLowScore";
            this.lblBestLowScore.Size = new System.Drawing.Size(91, 13);
            this.lblBestLowScore.TabIndex = 0;
            this.lblBestLowScore.Text = "Best (Low) Score:";
            // 
            // lblNumberOfGuesses
            // 
            this.lblNumberOfGuesses.AutoSize = true;
            this.lblNumberOfGuesses.Location = new System.Drawing.Point(8, 11);
            this.lblNumberOfGuesses.Name = "lblNumberOfGuesses";
            this.lblNumberOfGuesses.Size = new System.Drawing.Size(103, 13);
            this.lblNumberOfGuesses.TabIndex = 0;
            this.lblNumberOfGuesses.Text = "Number of Guesses:";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(121, 309);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(40, 13);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess:";
            this.lblGuess.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(197, 309);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(132, 20);
            this.txtGuess.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBestScore);
            this.groupBox1.Controls.Add(this.lblNumGuesses);
            this.groupBox1.Controls.Add(this.lblNumberOfGuesses);
            this.groupBox1.Controls.Add(this.lblBestLowScore);
            this.groupBox1.Location = new System.Drawing.Point(61, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 68);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblNumGuesses
            // 
            this.lblNumGuesses.AutoSize = true;
            this.lblNumGuesses.Location = new System.Drawing.Point(173, 11);
            this.lblNumGuesses.Name = "lblNumGuesses";
            this.lblNumGuesses.Size = new System.Drawing.Size(13, 13);
            this.lblNumGuesses.TabIndex = 0;
            this.lblNumGuesses.Text = "0";
            this.lblNumGuesses.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Location = new System.Drawing.Point(173, 41);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(13, 13);
            this.lblBestScore.TabIndex = 0;
            this.lblBestScore.Text = "?";
            // 
            // frmHighLow
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.label1);
            this.Name = "frmHighLow";
            this.Text = "High/Low Game";
            this.Load += new System.EventHandler(this.frmHighLow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBestLowScore;
        private System.Windows.Forms.Label lblNumberOfGuesses;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumGuesses;
        private System.Windows.Forms.Label lblBestScore;
    }
}

