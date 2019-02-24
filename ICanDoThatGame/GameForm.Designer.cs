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
            this.p2Picture = new System.Windows.Forms.PictureBox();
            this.p2NameTextBox = new System.Windows.Forms.TextBox();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.p2Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.p1NameTextBox = new System.Windows.Forms.TextBox();
            this.p1Picture = new System.Windows.Forms.PictureBox();
            this.p1Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAction.SuspendLayout();
            this.panelWhere.SuspendLayout();
            this.panelWith.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAction.Font = new System.Drawing.Font("AR CARTER", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAction.Location = new System.Drawing.Point(224, 63);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(182, 97);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWhere.Font = new System.Drawing.Font("AR CARTER", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhere.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWhere.Location = new System.Drawing.Point(447, 63);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(182, 97);
            this.btnWhere.TabIndex = 1;
            this.btnWhere.Text = "Place";
            this.btnWhere.UseVisualStyleBackColor = false;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnWith
            // 
            this.btnWith.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWith.Font = new System.Drawing.Font("AR CARTER", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWith.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWith.Location = new System.Drawing.Point(673, 63);
            this.btnWith.Name = "btnWith";
            this.btnWith.Size = new System.Drawing.Size(182, 97);
            this.btnWith.TabIndex = 2;
            this.btnWith.Text = "Challenge";
            this.btnWith.UseVisualStyleBackColor = false;
            this.btnWith.Click += new System.EventHandler(this.btnWith_Click);
            // 
            // btnOpenCustomizeForm
            // 
            this.btnOpenCustomizeForm.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblAction.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblWhere.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblWith.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.p1ScoreLabel.Location = new System.Drawing.Point(86, 205);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(61, 76);
            this.p1ScoreLabel.TabIndex = 11;
            this.p1ScoreLabel.Text = "0";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p1ScoreLabel.Click += new System.EventHandler(this.p1ScoreLabel_Click);
            this.p1ScoreLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p1ScoreLabel_MouseUp);
            // 
            // p2Picture
            // 
            this.p2Picture.Image = global::ICanDoThatGame.Properties.Resources.cover_98637_1280_red;
            this.p2Picture.Location = new System.Drawing.Point(892, 12);
            this.p2Picture.Name = "p2Picture";
            this.p2Picture.Size = new System.Drawing.Size(137, 126);
            this.p2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2Picture.TabIndex = 8;
            this.p2Picture.TabStop = false;
            // 
            // p2NameTextBox
            // 
            this.p2NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p2NameTextBox.Enabled = false;
            this.p2NameTextBox.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2NameTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.p2NameTextBox.Location = new System.Drawing.Point(917, 154);
            this.p2NameTextBox.Multiline = true;
            this.p2NameTextBox.Name = "p2NameTextBox";
            this.p2NameTextBox.Size = new System.Drawing.Size(92, 36);
            this.p2NameTextBox.TabIndex = 10;
            this.p2NameTextBox.Text = "Thing 2";
            this.p2NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.AutoSize = true;
            this.p2ScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p2ScoreLabel.Location = new System.Drawing.Point(943, 205);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(61, 76);
            this.p2ScoreLabel.TabIndex = 12;
            this.p2ScoreLabel.Text = "0";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p2ScoreLabel.Click += new System.EventHandler(this.p2ScoreLabel_Click);
            this.p2ScoreLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p2ScoreLabel_MouseUp_1);
            // 
            // p2Panel
            // 
            this.p2Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2Panel.Location = new System.Drawing.Point(861, 3);
            this.p2Panel.Name = "p2Panel";
            this.p2Panel.Size = new System.Drawing.Size(200, 288);
            this.p2Panel.TabIndex = 13;
            this.p2Panel.Visible = false;
            // 
            // p1NameTextBox
            // 
            this.p1NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p1NameTextBox.Enabled = false;
            this.p1NameTextBox.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1NameTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.p1NameTextBox.Location = new System.Drawing.Point(62, 154);
            this.p1NameTextBox.Multiline = true;
            this.p1NameTextBox.Name = "p1NameTextBox";
            this.p1NameTextBox.Size = new System.Drawing.Size(93, 36);
            this.p1NameTextBox.TabIndex = 9;
            this.p1NameTextBox.Text = "Thing 1";
            this.p1NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // p1Panel
            // 
            this.p1Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1Panel.Location = new System.Drawing.Point(12, 3);
            this.p1Panel.Name = "p1Panel";
            this.p1Panel.Size = new System.Drawing.Size(200, 288);
            this.p1Panel.TabIndex = 14;
            this.p1Panel.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 450);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.Controls.Add(this.p2NameTextBox);
            this.Controls.Add(this.p1NameTextBox);
            this.Controls.Add(this.p2Picture);
            this.Controls.Add(this.p1Picture);
            this.Controls.Add(this.panelWith);
            this.Controls.Add(this.panelWhere);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.btnOpenCustomizeForm);
            this.Controls.Add(this.btnWith);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.p2Panel);
            this.Controls.Add(this.p1Panel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.panelAction.ResumeLayout(false);
            this.panelWhere.ResumeLayout(false);
            this.panelWith.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p2Picture)).EndInit();
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
        private System.Windows.Forms.PictureBox p2Picture;
        private System.Windows.Forms.TextBox p2NameTextBox;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.FlowLayoutPanel p2Panel;
        private System.Windows.Forms.TextBox p1NameTextBox;
        private System.Windows.Forms.PictureBox p1Picture;
        private System.Windows.Forms.FlowLayoutPanel p1Panel;
    }
}