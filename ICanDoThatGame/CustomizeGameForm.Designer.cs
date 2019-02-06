namespace ICanDoThatGame
{
    partial class CustomizeGameForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblActionItem = new System.Windows.Forms.Label();
            this.lblWhereItem = new System.Windows.Forms.Label();
            this.lblWithItem = new System.Windows.Forms.Label();
            this.btnCustomize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 20);
            this.textBox3.TabIndex = 2;
            // 
            // lblActionItem
            // 
            this.lblActionItem.AutoSize = true;
            this.lblActionItem.Location = new System.Drawing.Point(54, 24);
            this.lblActionItem.Name = "lblActionItem";
            this.lblActionItem.Size = new System.Drawing.Size(91, 13);
            this.lblActionItem.TabIndex = 3;
            this.lblActionItem.Text = "Insert new action:";
            // 
            // lblWhereItem
            // 
            this.lblWhereItem.AutoSize = true;
            this.lblWhereItem.Location = new System.Drawing.Point(54, 85);
            this.lblWhereItem.Name = "lblWhereItem";
            this.lblWhereItem.Size = new System.Drawing.Size(88, 13);
            this.lblWhereItem.TabIndex = 4;
            this.lblWhereItem.Text = "Insert new place:";
            // 
            // lblWithItem
            // 
            this.lblWithItem.AutoSize = true;
            this.lblWithItem.Location = new System.Drawing.Point(54, 146);
            this.lblWithItem.Name = "lblWithItem";
            this.lblWithItem.Size = new System.Drawing.Size(130, 13);
            this.lblWithItem.TabIndex = 5;
            this.lblWithItem.Text = "Insert new challenge item:";
            // 
            // btnCustomize
            // 
            this.btnCustomize.Location = new System.Drawing.Point(57, 223);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(202, 53);
            this.btnCustomize.TabIndex = 6;
            this.btnCustomize.Text = "Customize Game";
            this.btnCustomize.UseVisualStyleBackColor = true;
            // 
            // CustomizeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 321);
            this.Controls.Add(this.btnCustomize);
            this.Controls.Add(this.lblWithItem);
            this.Controls.Add(this.lblWhereItem);
            this.Controls.Add(this.lblActionItem);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "CustomizeGameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblActionItem;
        private System.Windows.Forms.Label lblWhereItem;
        private System.Windows.Forms.Label lblWithItem;
        private System.Windows.Forms.Button btnCustomize;
    }
}

