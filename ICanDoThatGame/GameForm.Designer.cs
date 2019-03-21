namespace ICanDoThatGame
{
    partial class GameForm
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
            this.btnAction = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnWith = new System.Windows.Forms.Button();
            this.btnOpenCustomizeForm = new System.Windows.Forms.Button();
            this.panelAction = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAction = new System.Windows.Forms.Label();
            this.panelWhere = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWhere = new System.Windows.Forms.Label();
            this.panelWith = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWith = new System.Windows.Forms.Label();
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2NameTextBox = new System.Windows.Forms.TextBox();
            this.p1NameTextBox = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblTurnLeftText = new System.Windows.Forms.Label();
            this.lblTurnLeftInt = new System.Windows.Forms.Label();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.p1panel = new System.Windows.Forms.Panel();
            this.p1ThumbsDown = new System.Windows.Forms.PictureBox();
            this.p1ThumbsUp = new System.Windows.Forms.PictureBox();
            this.p1SuccessText = new System.Windows.Forms.TextBox();
            this.p2panel = new System.Windows.Forms.Panel();
            this.p2ThumbsUp = new System.Windows.Forms.PictureBox();
            this.p2SuccessText = new System.Windows.Forms.TextBox();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.p2Picture = new System.Windows.Forms.PictureBox();
            this.p2ThumbsDown = new System.Windows.Forms.PictureBox();
            this.p1Picture = new System.Windows.Forms.PictureBox();
            this.panelAction.SuspendLayout();
            this.panelWhere.SuspendLayout();
            this.panelWith.SuspendLayout();
            this.p1panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1ThumbsDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1ThumbsUp)).BeginInit();
            this.p2panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2ThumbsUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2ThumbsDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAction.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAction.Location = new System.Drawing.Point(224, 63);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(182, 97);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Action";
            this.btnAction.UseCompatibleTextRendering = true;
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWhere.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhere.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWhere.Location = new System.Drawing.Point(447, 63);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(182, 97);
            this.btnWhere.TabIndex = 1;
            this.btnWhere.Text = "Place";
            this.btnWhere.UseCompatibleTextRendering = true;
            this.btnWhere.UseVisualStyleBackColor = false;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnWith
            // 
            this.btnWith.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWith.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWith.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWith.Location = new System.Drawing.Point(673, 63);
            this.btnWith.Name = "btnWith";
            this.btnWith.Size = new System.Drawing.Size(182, 97);
            this.btnWith.TabIndex = 2;
            this.btnWith.Text = "Challenge";
            this.btnWith.UseCompatibleTextRendering = true;
            this.btnWith.UseVisualStyleBackColor = false;
            this.btnWith.Click += new System.EventHandler(this.btnWith_Click);
            // 
            // btnOpenCustomizeForm
            // 
            this.btnOpenCustomizeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCustomizeForm.Location = new System.Drawing.Point(880, 407);
            this.btnOpenCustomizeForm.Name = "btnOpenCustomizeForm";
            this.btnOpenCustomizeForm.Size = new System.Drawing.Size(181, 31);
            this.btnOpenCustomizeForm.TabIndex = 3;
            this.btnOpenCustomizeForm.Text = "Customize Game";
            this.btnOpenCustomizeForm.UseVisualStyleBackColor = true;
            this.btnOpenCustomizeForm.Click += new System.EventHandler(this.btnOpenCustomizeForm_Click);
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAction.Controls.Add(this.lblAction);
            this.panelAction.Location = new System.Drawing.Point(224, 166);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(182, 100);
            this.panelAction.TabIndex = 4;
            this.panelAction.Visible = false;
            // 
            // lblAction
            // 
            this.lblAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAction.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(3, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(179, 100);
            this.lblAction.TabIndex = 0;
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWhere
            // 
            this.panelWhere.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWhere.Controls.Add(this.lblWhere);
            this.panelWhere.Location = new System.Drawing.Point(447, 166);
            this.panelWhere.Name = "panelWhere";
            this.panelWhere.Size = new System.Drawing.Size(182, 100);
            this.panelWhere.TabIndex = 5;
            this.panelWhere.Visible = false;
            // 
            // lblWhere
            // 
            this.lblWhere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWhere.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhere.Location = new System.Drawing.Point(3, 0);
            this.lblWhere.Name = "lblWhere";
            this.lblWhere.Size = new System.Drawing.Size(179, 100);
            this.lblWhere.TabIndex = 1;
            this.lblWhere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWith
            // 
            this.panelWith.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelWith.Controls.Add(this.lblWith);
            this.panelWith.Location = new System.Drawing.Point(673, 166);
            this.panelWith.Name = "panelWith";
            this.panelWith.Size = new System.Drawing.Size(182, 100);
            this.panelWith.TabIndex = 6;
            this.panelWith.Visible = false;
            // 
            // lblWith
            // 
            this.lblWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWith.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWith.Location = new System.Drawing.Point(3, 0);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(178, 100);
            this.lblWith.TabIndex = 1;
            this.lblWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.AutoSize = true;
            this.p1ScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p1ScoreLabel.Location = new System.Drawing.Point(71, 212);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(61, 76);
            this.p1ScoreLabel.TabIndex = 11;
            this.p1ScoreLabel.Text = "0";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2NameTextBox
            // 
            this.p2NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2NameTextBox.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2NameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.p2NameTextBox.Location = new System.Drawing.Point(892, 154);
            this.p2NameTextBox.MaxLength = 12;
            this.p2NameTextBox.Name = "p2NameTextBox";
            this.p2NameTextBox.Size = new System.Drawing.Size(137, 30);
            this.p2NameTextBox.TabIndex = 10;
            this.p2NameTextBox.Text = "Thing 2";
            this.p2NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2NameTextBox.TextChanged += new System.EventHandler(this.p2NameTextBox_TextChanged);
            // 
            // p1NameTextBox
            // 
            this.p1NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1NameTextBox.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1NameTextBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.p1NameTextBox.Location = new System.Drawing.Point(41, 154);
            this.p1NameTextBox.MaxLength = 12;
            this.p1NameTextBox.Name = "p1NameTextBox";
            this.p1NameTextBox.Size = new System.Drawing.Size(137, 30);
            this.p1NameTextBox.TabIndex = 9;
            this.p1NameTextBox.Text = "Thing 1";
            this.p1NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p1NameTextBox.TextChanged += new System.EventHandler(this.p1NameTextBox_TextChanged);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartGame.Font = new System.Drawing.Font("Rockwell Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(225, 58);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(629, 222);
            this.btnStartGame.TabIndex = 15;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblTurnLeftText
            // 
            this.lblTurnLeftText.AutoSize = true;
            this.lblTurnLeftText.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnLeftText.ForeColor = System.Drawing.Color.DimGray;
            this.lblTurnLeftText.Location = new System.Drawing.Point(486, 12);
            this.lblTurnLeftText.Name = "lblTurnLeftText";
            this.lblTurnLeftText.Size = new System.Drawing.Size(87, 23);
            this.lblTurnLeftText.TabIndex = 16;
            this.lblTurnLeftText.Text = "Turns left:";
            // 
            // lblTurnLeftInt
            // 
            this.lblTurnLeftInt.AutoSize = true;
            this.lblTurnLeftInt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnLeftInt.ForeColor = System.Drawing.Color.DimGray;
            this.lblTurnLeftInt.Location = new System.Drawing.Point(566, 12);
            this.lblTurnLeftInt.Name = "lblTurnLeftInt";
            this.lblTurnLeftInt.Size = new System.Drawing.Size(30, 23);
            this.lblTurnLeftInt.TabIndex = 17;
            this.lblTurnLeftInt.Text = "10";
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.White;
            this.btnExitGame.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.Location = new System.Drawing.Point(877, 404);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(181, 34);
            this.btnExitGame.TabIndex = 18;
            this.btnExitGame.Text = "EXIT";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Visible = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // p1panel
            // 
            this.p1panel.BackColor = System.Drawing.Color.Black;
            this.p1panel.Controls.Add(this.p1ThumbsDown);
            this.p1panel.Controls.Add(this.p1ThumbsUp);
            this.p1panel.Controls.Add(this.p1SuccessText);
            this.p1panel.Controls.Add(this.p1ScoreLabel);
            this.p1panel.Location = new System.Drawing.Point(12, 3);
            this.p1panel.Name = "p1panel";
            this.p1panel.Size = new System.Drawing.Size(200, 288);
            this.p1panel.TabIndex = 19;
            // 
            // p1ThumbsDown
            // 
            this.p1ThumbsDown.Image = global::ICanDoThatGame.Properties.Resources.bluethumbsdown;
            this.p1ThumbsDown.InitialImage = global::ICanDoThatGame.Properties.Resources.redthumbsdown;
            this.p1ThumbsDown.Location = new System.Drawing.Point(29, 227);
            this.p1ThumbsDown.Name = "p1ThumbsDown";
            this.p1ThumbsDown.Size = new System.Drawing.Size(40, 40);
            this.p1ThumbsDown.TabIndex = 21;
            this.p1ThumbsDown.TabStop = false;
            this.p1ThumbsDown.Visible = false;
            this.p1ThumbsDown.Click += new System.EventHandler(this.p1ThumbsDown_Click);
            // 
            // p1ThumbsUp
            // 
            this.p1ThumbsUp.Image = global::ICanDoThatGame.Properties.Resources.bluethumbsup;
            this.p1ThumbsUp.Location = new System.Drawing.Point(129, 227);
            this.p1ThumbsUp.Name = "p1ThumbsUp";
            this.p1ThumbsUp.Size = new System.Drawing.Size(40, 40);
            this.p1ThumbsUp.TabIndex = 22;
            this.p1ThumbsUp.TabStop = false;
            this.p1ThumbsUp.Visible = false;
            this.p1ThumbsUp.Click += new System.EventHandler(this.p1ThumbsUp_Click);
            // 
            // p1SuccessText
            // 
            this.p1SuccessText.BackColor = System.Drawing.Color.Black;
            this.p1SuccessText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1SuccessText.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1SuccessText.ForeColor = System.Drawing.Color.White;
            this.p1SuccessText.Location = new System.Drawing.Point(29, 196);
            this.p1SuccessText.Name = "p1SuccessText";
            this.p1SuccessText.Size = new System.Drawing.Size(137, 29);
            this.p1SuccessText.TabIndex = 1;
            this.p1SuccessText.Text = "Did you do it?";
            this.p1SuccessText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p1SuccessText.Visible = false;
            // 
            // p2panel
            // 
            this.p2panel.BackColor = System.Drawing.Color.Black;
            this.p2panel.Controls.Add(this.p2ThumbsUp);
            this.p2panel.Controls.Add(this.p2SuccessText);
            this.p2panel.Controls.Add(this.p2ScoreLabel);
            this.p2panel.Controls.Add(this.p2Picture);
            this.p2panel.Controls.Add(this.p2ThumbsDown);
            this.p2panel.Location = new System.Drawing.Point(861, 3);
            this.p2panel.Name = "p2panel";
            this.p2panel.Size = new System.Drawing.Size(200, 288);
            this.p2panel.TabIndex = 20;
            // 
            // p2ThumbsUp
            // 
            this.p2ThumbsUp.Image = global::ICanDoThatGame.Properties.Resources.redthumbsup;
            this.p2ThumbsUp.InitialImage = global::ICanDoThatGame.Properties.Resources.redthumbsup;
            this.p2ThumbsUp.Location = new System.Drawing.Point(130, 227);
            this.p2ThumbsUp.Name = "p2ThumbsUp";
            this.p2ThumbsUp.Size = new System.Drawing.Size(40, 40);
            this.p2ThumbsUp.TabIndex = 23;
            this.p2ThumbsUp.TabStop = false;
            this.p2ThumbsUp.Visible = false;
            this.p2ThumbsUp.Click += new System.EventHandler(this.p2ThumbsUp_Click);
            // 
            // p2SuccessText
            // 
            this.p2SuccessText.BackColor = System.Drawing.Color.Black;
            this.p2SuccessText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2SuccessText.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2SuccessText.ForeColor = System.Drawing.Color.White;
            this.p2SuccessText.Location = new System.Drawing.Point(31, 196);
            this.p2SuccessText.Name = "p2SuccessText";
            this.p2SuccessText.Size = new System.Drawing.Size(137, 29);
            this.p2SuccessText.TabIndex = 13;
            this.p2SuccessText.Text = "Did you do it?";
            this.p2SuccessText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2SuccessText.Visible = false;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.AutoSize = true;
            this.p2ScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p2ScoreLabel.Location = new System.Drawing.Point(77, 212);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(61, 76);
            this.p2ScoreLabel.TabIndex = 25;
            this.p2ScoreLabel.Text = "0";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2Picture
            // 
            this.p2Picture.Image = global::ICanDoThatGame.Properties.Resources.cover_98637_1280_red;
            this.p2Picture.Location = new System.Drawing.Point(31, 9);
            this.p2Picture.Name = "p2Picture";
            this.p2Picture.Size = new System.Drawing.Size(137, 126);
            this.p2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Picture.TabIndex = 24;
            this.p2Picture.TabStop = false;
            // 
            // p2ThumbsDown
            // 
            this.p2ThumbsDown.Image = global::ICanDoThatGame.Properties.Resources.redthumbsdown;
            this.p2ThumbsDown.InitialImage = global::ICanDoThatGame.Properties.Resources.redthumbsdown;
            this.p2ThumbsDown.Location = new System.Drawing.Point(31, 227);
            this.p2ThumbsDown.Name = "p2ThumbsDown";
            this.p2ThumbsDown.Size = new System.Drawing.Size(40, 40);
            this.p2ThumbsDown.TabIndex = 22;
            this.p2ThumbsDown.TabStop = false;
            this.p2ThumbsDown.Visible = false;
            this.p2ThumbsDown.Click += new System.EventHandler(this.p2ThumbsDown_Click);
            // 
            // p1Picture
            // 
            this.p1Picture.Image = global::ICanDoThatGame.Properties.Resources.cover_98637_1280;
            this.p1Picture.Location = new System.Drawing.Point(41, 12);
            this.p1Picture.Name = "p1Picture";
            this.p1Picture.Size = new System.Drawing.Size(137, 126);
            this.p1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1Picture.TabIndex = 7;
            this.p1Picture.TabStop = false;
            this.p1Picture.DoubleClick += new System.EventHandler(this.p1Picture_DoubleClick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.p1Picture);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.lblTurnLeftInt);
            this.Controls.Add(this.lblTurnLeftText);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.p2NameTextBox);
            this.Controls.Add(this.p1NameTextBox);
            this.Controls.Add(this.panelWith);
            this.Controls.Add(this.panelWhere);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.btnOpenCustomizeForm);
            this.Controls.Add(this.btnWith);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.p1panel);
            this.Controls.Add(this.p2panel);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.panelAction.ResumeLayout(false);
            this.panelWhere.ResumeLayout(false);
            this.panelWith.ResumeLayout(false);
            this.p1panel.ResumeLayout(false);
            this.p1panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1ThumbsDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1ThumbsUp)).EndInit();
            this.p2panel.ResumeLayout(false);
            this.p2panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2ThumbsUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2ThumbsDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnWith;
        private System.Windows.Forms.Button btnOpenCustomizeForm;
        private System.Windows.Forms.FlowLayoutPanel panelAction;
        private System.Windows.Forms.FlowLayoutPanel panelWhere;
        private System.Windows.Forms.FlowLayoutPanel panelWith;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblWhere;
        private System.Windows.Forms.Label lblWith;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.TextBox p2NameTextBox;
        private System.Windows.Forms.TextBox p1NameTextBox;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblTurnLeftText;
        private System.Windows.Forms.Label lblTurnLeftInt;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.PictureBox p1Picture;
        private System.Windows.Forms.Panel p1panel;
        private System.Windows.Forms.PictureBox p1ThumbsUp;
        private System.Windows.Forms.PictureBox p1ThumbsDown;
        private System.Windows.Forms.TextBox p1SuccessText;
        private System.Windows.Forms.Panel p2panel;
        private System.Windows.Forms.TextBox p2SuccessText;
        private System.Windows.Forms.PictureBox p2ThumbsDown;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.PictureBox p2Picture;
        private System.Windows.Forms.PictureBox p2ThumbsUp;
    }
}