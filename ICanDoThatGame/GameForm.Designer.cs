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
            this.panelAction.SuspendLayout();
            this.panelWhere.SuspendLayout();
            this.panelWith.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(37, 60);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(182, 97);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(260, 60);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(182, 97);
            this.btnWhere.TabIndex = 1;
            this.btnWhere.Text = "Place";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnWith
            // 
            this.btnWith.Location = new System.Drawing.Point(486, 60);
            this.btnWith.Name = "btnWith";
            this.btnWith.Size = new System.Drawing.Size(182, 97);
            this.btnWith.TabIndex = 2;
            this.btnWith.Text = "Challenge";
            this.btnWith.UseVisualStyleBackColor = true;
            this.btnWith.Click += new System.EventHandler(this.btnWith_Click);
            // 
            // btnOpenCustomizeForm
            // 
            this.btnOpenCustomizeForm.Location = new System.Drawing.Point(486, 404);
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
            this.panelAction.Location = new System.Drawing.Point(37, 163);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(182, 100);
            this.panelAction.TabIndex = 4;
            this.panelAction.Visible = false;
            // 
            // lblAction
            // 
            this.lblAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panelWhere.Location = new System.Drawing.Point(260, 163);
            this.panelWhere.Name = "panelWhere";
            this.panelWhere.Size = new System.Drawing.Size(182, 100);
            this.panelWhere.TabIndex = 5;
            this.panelWhere.Visible = false;
            // 
            // lblWhere
            // 
            this.lblWhere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panelWith.Location = new System.Drawing.Point(486, 163);
            this.panelWith.Name = "panelWith";
            this.panelWith.Size = new System.Drawing.Size(182, 100);
            this.panelWith.TabIndex = 6;
            this.panelWith.Visible = false;
            // 
            // lblWith
            // 
            this.lblWith.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWith.Location = new System.Drawing.Point(3, 0);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(178, 100);
            this.lblWith.TabIndex = 1;
            this.lblWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.panelWith);
            this.Controls.Add(this.panelWhere);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.btnOpenCustomizeForm);
            this.Controls.Add(this.btnWith);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnAction);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.panelAction.ResumeLayout(false);
            this.panelWhere.ResumeLayout(false);
            this.panelWith.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}