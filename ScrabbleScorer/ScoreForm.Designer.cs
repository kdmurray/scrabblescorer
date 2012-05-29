namespace ScrabbleScorer
{
    partial class ScoreForm
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
            this.txtWord = new System.Windows.Forms.TextBox();
            this.cmdScore = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.cmdDouble = new System.Windows.Forms.Button();
            this.cmdTriple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(12, 41);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(226, 20);
            this.txtWord.TabIndex = 0;
            // 
            // cmdScore
            // 
            this.cmdScore.Location = new System.Drawing.Point(244, 10);
            this.cmdScore.Name = "cmdScore";
            this.cmdScore.Size = new System.Drawing.Size(75, 23);
            this.cmdScore.TabIndex = 1;
            this.cmdScore.Text = "Score!";
            this.cmdScore.UseVisualStyleBackColor = true;
            this.cmdScore.Click += new System.EventHandler(this.cmdScore_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(62, 97);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 73);
            this.lblScore.TabIndex = 2;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdDouble
            // 
            this.cmdDouble.Location = new System.Drawing.Point(244, 39);
            this.cmdDouble.Name = "cmdDouble";
            this.cmdDouble.Size = new System.Drawing.Size(75, 23);
            this.cmdDouble.TabIndex = 3;
            this.cmdDouble.Text = "Double";
            this.cmdDouble.UseVisualStyleBackColor = true;
            this.cmdDouble.Click += new System.EventHandler(this.cmdDouble_Click);
            // 
            // cmdTriple
            // 
            this.cmdTriple.Location = new System.Drawing.Point(244, 68);
            this.cmdTriple.Name = "cmdTriple";
            this.cmdTriple.Size = new System.Drawing.Size(75, 23);
            this.cmdTriple.TabIndex = 4;
            this.cmdTriple.Text = "Triple";
            this.cmdTriple.UseVisualStyleBackColor = true;
            this.cmdTriple.Click += new System.EventHandler(this.cmdTriple_Click);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 193);
            this.Controls.Add(this.cmdTriple);
            this.Controls.Add(this.cmdDouble);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.cmdScore);
            this.Controls.Add(this.txtWord);
            this.Name = "ScoreForm";
            this.Text = "Scrabble Scorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button cmdScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button cmdDouble;
        private System.Windows.Forms.Button cmdTriple;
    }
}

