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
            this.txtActionItem = new System.Windows.Forms.TextBox();
            this.txtWhereItem = new System.Windows.Forms.TextBox();
            this.txtWithItem = new System.Windows.Forms.TextBox();
            this.lblActionItem = new System.Windows.Forms.Label();
            this.lblWhereItem = new System.Windows.Forms.Label();
            this.lblWithItem = new System.Windows.Forms.Label();
            this.btnCustomize = new System.Windows.Forms.Button();
            this.btnDeleteGameItems = new System.Windows.Forms.Button();
            this.groupAddGameItems = new System.Windows.Forms.GroupBox();
            this.groupAddGameItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtActionItem
            // 
            this.txtActionItem.Location = new System.Drawing.Point(113, 36);
            this.txtActionItem.Name = "txtActionItem";
            this.txtActionItem.Size = new System.Drawing.Size(202, 24);
            this.txtActionItem.TabIndex = 0;
            // 
            // txtWhereItem
            // 
            this.txtWhereItem.Location = new System.Drawing.Point(113, 97);
            this.txtWhereItem.Name = "txtWhereItem";
            this.txtWhereItem.Size = new System.Drawing.Size(202, 24);
            this.txtWhereItem.TabIndex = 1;
            // 
            // txtWithItem
            // 
            this.txtWithItem.Location = new System.Drawing.Point(113, 158);
            this.txtWithItem.Name = "txtWithItem";
            this.txtWithItem.Size = new System.Drawing.Size(202, 24);
            this.txtWithItem.TabIndex = 2;
            // 
            // lblActionItem
            // 
            this.lblActionItem.AutoSize = true;
            this.lblActionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionItem.Location = new System.Drawing.Point(110, 20);
            this.lblActionItem.Name = "lblActionItem";
            this.lblActionItem.Size = new System.Drawing.Size(93, 15);
            this.lblActionItem.TabIndex = 3;
            this.lblActionItem.Text = "Add new action:";
            // 
            // lblWhereItem
            // 
            this.lblWhereItem.AutoSize = true;
            this.lblWhereItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereItem.Location = new System.Drawing.Point(113, 81);
            this.lblWhereItem.Name = "lblWhereItem";
            this.lblWhereItem.Size = new System.Drawing.Size(90, 15);
            this.lblWhereItem.TabIndex = 4;
            this.lblWhereItem.Text = "Add new place:";
            // 
            // lblWithItem
            // 
            this.lblWithItem.AutoSize = true;
            this.lblWithItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithItem.Location = new System.Drawing.Point(113, 142);
            this.lblWithItem.Name = "lblWithItem";
            this.lblWithItem.Size = new System.Drawing.Size(141, 15);
            this.lblWithItem.TabIndex = 5;
            this.lblWithItem.Text = "Add new challenge item:";
            // 
            // btnCustomize
            // 
            this.btnCustomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomize.Location = new System.Drawing.Point(116, 208);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(202, 53);
            this.btnCustomize.TabIndex = 6;
            this.btnCustomize.Text = "Customize Game";
            this.btnCustomize.UseVisualStyleBackColor = true;
            this.btnCustomize.Click += new System.EventHandler(this.btnCustomize_Click);
            // 
            // btnDeleteGameItems
            // 
            this.btnDeleteGameItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGameItems.Location = new System.Drawing.Point(12, 12);
            this.btnDeleteGameItems.Name = "btnDeleteGameItems";
            this.btnDeleteGameItems.Size = new System.Drawing.Size(147, 27);
            this.btnDeleteGameItems.TabIndex = 7;
            this.btnDeleteGameItems.Text = "Delete Game Items";
            this.btnDeleteGameItems.UseVisualStyleBackColor = true;
            this.btnDeleteGameItems.Click += new System.EventHandler(this.btnDeleteGameItems_Click);
            // 
            // groupAddGameItems
            // 
            this.groupAddGameItems.Controls.Add(this.btnCustomize);
            this.groupAddGameItems.Controls.Add(this.lblWithItem);
            this.groupAddGameItems.Controls.Add(this.txtActionItem);
            this.groupAddGameItems.Controls.Add(this.lblWhereItem);
            this.groupAddGameItems.Controls.Add(this.txtWhereItem);
            this.groupAddGameItems.Controls.Add(this.lblActionItem);
            this.groupAddGameItems.Controls.Add(this.txtWithItem);
            this.groupAddGameItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAddGameItems.Location = new System.Drawing.Point(12, 54);
            this.groupAddGameItems.Name = "groupAddGameItems";
            this.groupAddGameItems.Size = new System.Drawing.Size(334, 272);
            this.groupAddGameItems.TabIndex = 8;
            this.groupAddGameItems.TabStop = false;
            this.groupAddGameItems.Text = "Insert Game Items";
            // 
            // CustomizeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 339);
            this.Controls.Add(this.btnDeleteGameItems);
            this.Controls.Add(this.groupAddGameItems);
            this.Name = "CustomizeGameForm";
            this.Text = "Customize Game";
            this.groupAddGameItems.ResumeLayout(false);
            this.groupAddGameItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtActionItem;
        private System.Windows.Forms.TextBox txtWhereItem;
        private System.Windows.Forms.TextBox txtWithItem;
        private System.Windows.Forms.Label lblActionItem;
        private System.Windows.Forms.Label lblWhereItem;
        private System.Windows.Forms.Label lblWithItem;
        private System.Windows.Forms.Button btnCustomize;
        private System.Windows.Forms.Button btnDeleteGameItems;
        private System.Windows.Forms.GroupBox groupAddGameItems;
    }
}

