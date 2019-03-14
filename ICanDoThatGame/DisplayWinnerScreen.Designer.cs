namespace ICanDoThatGame
{
    partial class DisplayWinnerScreen
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
            this.txtGameOver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGameOver
            // 
            this.txtGameOver.BackColor = System.Drawing.Color.Black;
            this.txtGameOver.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGameOver.Enabled = false;
            this.txtGameOver.Font = new System.Drawing.Font("Rockwell Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameOver.ForeColor = System.Drawing.Color.White;
            this.txtGameOver.Location = new System.Drawing.Point(0, 0);
            this.txtGameOver.Name = "txtGameOver";
            this.txtGameOver.Size = new System.Drawing.Size(800, 120);
            this.txtGameOver.TabIndex = 0;
            this.txtGameOver.Text = "GAME OVER";
            this.txtGameOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblWins
            // 
            this.lblWins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWins.Font = new System.Drawing.Font("Papyrus", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.ForeColor = System.Drawing.Color.White;
            this.lblWins.Location = new System.Drawing.Point(0, 120);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(800, 330);
            this.lblWins.TabIndex = 3;
            this.lblWins.Text = "wins!";
            this.lblWins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWins.UseCompatibleTextRendering = true;
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.White;
            this.btnExitGame.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.Location = new System.Drawing.Point(607, 392);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(181, 34);
            this.btnExitGame.TabIndex = 19;
            this.btnExitGame.Text = "EXIT";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Aqua;
            this.btnPlayAgain.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(408, 392);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(181, 34);
            this.btnPlayAgain.TabIndex = 20;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // DisplayWinnerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGameOver);
            this.Name = "DisplayWinnerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayWinnerScreen";
            this.Load += new System.EventHandler(this.DisplayWinnerScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}