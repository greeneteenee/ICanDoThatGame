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
            // 
            // btnWith
            // 
            this.btnWith.Location = new System.Drawing.Point(486, 60);
            this.btnWith.Name = "btnWith";
            this.btnWith.Size = new System.Drawing.Size(182, 97);
            this.btnWith.TabIndex = 2;
            this.btnWith.Text = "Challenge";
            this.btnWith.UseVisualStyleBackColor = true;
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.btnOpenCustomizeForm);
            this.Controls.Add(this.btnWith);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnAction);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnWith;
        private System.Windows.Forms.Button btnOpenCustomizeForm;
    }
}